using System;
using System.Windows.Forms;

namespace WhoToFollowApp
{
    public partial class WhoToFollowControl : UserControl
    {
        public WhoToFollowControl()
        {
            InitializeComponent();
        }

        public event EventHandler<RefreshEventArgs> RefreshAll;

        public event EventHandler<CloseEventArgs> CloseOne;

        public event EventHandler<LinkEventArgs> Link;

        protected void OnRefreshAll()
        {
            var handler = this.RefreshAll;
            if (handler != null)
            {
                handler(this, RefreshEventArgs.Empty);
            }
        }

        protected void OnCloseOne(int rowIndex)
        {
            var handler = this.CloseOne;
            if (handler != null)
            {
                handler(this, new CloseEventArgs(rowIndex));
            }
        }

        protected void OnLink(Uri url)
        {
            var handler = this.Link;
            if (handler != null)
            {
                handler(this, new LinkEventArgs(url));
            }
        }

        private void WhoToFollowControl_Load(object sender, EventArgs e)
        {
            var f = GetForm();
            if (f != null)
            {
                f.Load += Form_Load;
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            this.OnRefreshAll();
        }

        private Form GetForm()
        {
            for (var c = this.Parent; c != null; c = c.Parent)
            {
                var f = c as Form;
                if (f != null) return f;
            }
            return null;
        }

        private void refreshLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.OnRefreshAll();
        }

        public object DataSource
        {
            get { return this.peopleToFollowBindingSource.DataSource; }
            set { this.peopleToFollowBindingSource.DataSource = value; }
        }

        private void suggestionsGridView_SelectionChanged(object sender, EventArgs e)
        {
            var row = this.suggestionsGridView.CurrentRow;
            if (row != null)
            {
                row.Selected = false;
            }
        }

        private void suggestionsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        // image is clicked
                        break;
                    }
                case 1:
                    {
                        var p = suggestionsGridView.Rows[e.RowIndex].DataBoundItem as PersonToFollow;
                        if (p != null)
                        {
                            OnLink(p.Url);
                        }
                        break;
                    }
                case 2:
                    {
                        OnCloseOne(e.RowIndex);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
    }
}
