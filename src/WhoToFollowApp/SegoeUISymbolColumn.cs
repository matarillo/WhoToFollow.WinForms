using System.Drawing;
using System.Windows.Forms;

namespace WhoToFollowApp
{
    [ToolboxBitmapAttribute(typeof(DataGridViewLinkColumn), "DataGridViewLinkColumn.bmp")]
    public class SegoeUISymbolColumn : DataGridViewLinkColumn
    {
        public SegoeUISymbolColumn()
        {
            this.CellTemplate = new SegoeUISymbolCell();
        }
    }
}
