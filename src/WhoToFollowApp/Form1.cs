using System.Diagnostics;
using System.Windows.Forms;

namespace WhoToFollowApp
{
    public partial class Form1 : Form
    {
        private readonly WhoToFollowWhatever whoToFollowWhatever1 = new WhoToFollowWhatever();

        public Form1()
        {
            InitializeComponent();
            this.whoToFollowControl1.RefreshAll += this.whoToFollowWhatever1.RefreshAll;
            this.whoToFollowControl1.CloseOne += this.whoToFollowWhatever1.CloseOne;
            this.whoToFollowControl1.DataSource = this.whoToFollowWhatever1.SuggestedPeople;
        }

        private void whoToFollowControl1_Link(object sender, LinkEventArgs e)
        {
            Process.Start(e.Url.ToString());
        }
    }
}
