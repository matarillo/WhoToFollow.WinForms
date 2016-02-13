using System.Drawing;
using System.Windows.Forms;

namespace WhoToFollowApp
{
    public class SegoeUISymbolCell : DataGridViewLinkCell
    {
        private Font symbolFont;

        protected override object GetFormattedValue(object value, int rowIndex, ref DataGridViewCellStyle cellStyle, System.ComponentModel.TypeConverter valueTypeConverter, System.ComponentModel.TypeConverter formattedValueTypeConverter, DataGridViewDataErrorContexts context)
        {
            if (symbolFont == null)
            {
                symbolFont = new Font("Segoe UI Symbol", cellStyle.Font.Size, cellStyle.Font.Style);
            }
            cellStyle.Font = symbolFont;
            return base.GetFormattedValue(value, rowIndex, ref cellStyle, valueTypeConverter, formattedValueTypeConverter, context);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (symbolFont != null)
                {
                    symbolFont.Dispose();
                    symbolFont = null;
                }
            }
            base.Dispose(disposing);
        }
    }
}
