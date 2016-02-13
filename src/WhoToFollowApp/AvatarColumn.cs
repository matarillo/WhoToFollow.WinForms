using System.Drawing;
using System.Windows.Forms;

namespace WhoToFollowApp
{
    [ToolboxBitmapAttribute(typeof(DataGridViewImageColumn), "DataGridViewImageColumn.bmp")]
    public class AvatarColumn : DataGridViewImageColumn
    {
        public AvatarColumn()
        {
            this.CellTemplate = new AvatarCell();
            this.ValueType = this.CellTemplate.ValueType;
        }
    }
}
