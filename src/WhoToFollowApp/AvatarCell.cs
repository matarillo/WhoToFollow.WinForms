using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoToFollowApp
{
    public class AvatarCell : DataGridViewImageCell
    {
        private static object lockObj = new object();
        private static Dictionary<Uri, Bitmap> images = new Dictionary<Uri, Bitmap>();

        public AvatarCell()
        {
            this.ValueType = typeof(Uri);
        }

        protected override object GetFormattedValue(object value, int rowIndex, ref DataGridViewCellStyle cellStyle, TypeConverter valueTypeConverter, TypeConverter formattedValueTypeConverter, DataGridViewDataErrorContexts context)
        {
            if (!(value is Uri))
            {
                return null;
            }
            Uri url = (Uri)value;
            if (url == default(Uri))
            {
                return null;
            }
            Bitmap image;
            lock (lockObj)
            {
                if (images.TryGetValue(url, out image))
                {
                    return (object)image;
                }
                images[url] = null;
            }
            RetrieveImage(url);
            return null;
        }

        private void RetrieveImage(Uri url)
        {
            RetrieveImageAsync(url).ContinueWith(t => RepaintMe());
        }

        private void RepaintMe()
        {
            if (this.DataGridView != null)
            {
                this.DataGridView.Invoke((Action)this.DataGridView.Refresh);
            }
        }

        private async Task RetrieveImageAsync(Uri url)
        {
            var httpClient = new HttpClient();
            var stream = await httpClient.GetStreamAsync(url);

            var h = this.OwningRow.Height;
            var w = this.OwningColumn.Width;
            var diameter = Math.Min(h, w);
            var bitmap = ClipCircle(new Bitmap(stream), diameter);
            lock (lockObj)
            {
                images[url] = bitmap;
            }
        }

        public override object DefaultNewRowValue
        {
            get
            {
                return default(Uri);
            }
        }

        private static Bitmap ClipCircle(Bitmap source, int diameter)
        {
            int w = diameter;
            int h = diameter;
            Bitmap dest = new Bitmap(w, h);
            using (Graphics g = Graphics.FromImage(dest))
            {
                var path = new GraphicsPath();
                path.AddEllipse(0, 0, w, h);
                g.SetClip(path);
                g.InterpolationMode = InterpolationMode.HighQualityBilinear;
                g.DrawImage(source, 0, 0, w, h);
            }
            return dest;
        }
    }
}
