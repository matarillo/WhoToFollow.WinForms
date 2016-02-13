namespace WhoToFollowApp
{
    partial class WhoToFollowControl
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.headerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.refreshLink = new System.Windows.Forms.LinkLabel();
            this.suggestionsGridView = new System.Windows.Forms.DataGridView();
            this.imageDataGridViewCustomColumn = new WhoToFollowApp.AvatarColumn();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Cancel = new WhoToFollowApp.SegoeUISymbolColumn();
            this.peopleToFollowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.segoeUISymbolColumn1 = new WhoToFollowApp.SegoeUISymbolColumn();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suggestionsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleToFollowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Controls.Add(this.refreshLink);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(320, 40);
            this.headerPanel.TabIndex = 0;
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.headerLabel.Location = new System.Drawing.Point(3, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(156, 30);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Who to follow";
            // 
            // refreshLink
            // 
            this.refreshLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refreshLink.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.refreshLink.Location = new System.Drawing.Point(165, 10);
            this.refreshLink.Name = "refreshLink";
            this.refreshLink.Size = new System.Drawing.Size(60, 20);
            this.refreshLink.TabIndex = 1;
            this.refreshLink.TabStop = true;
            this.refreshLink.Text = "Refresh";
            this.refreshLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.refreshLink_LinkClicked);
            // 
            // suggestionsGridView
            // 
            this.suggestionsGridView.AllowUserToAddRows = false;
            this.suggestionsGridView.AllowUserToDeleteRows = false;
            this.suggestionsGridView.AllowUserToResizeColumns = false;
            this.suggestionsGridView.AllowUserToResizeRows = false;
            this.suggestionsGridView.AutoGenerateColumns = false;
            this.suggestionsGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.suggestionsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.suggestionsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.suggestionsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.suggestionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suggestionsGridView.ColumnHeadersVisible = false;
            this.suggestionsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imageDataGridViewCustomColumn,
            this.urlDataGridViewTextBoxColumn,
            this.Cancel});
            this.suggestionsGridView.DataSource = this.peopleToFollowBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.suggestionsGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.suggestionsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suggestionsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.suggestionsGridView.Location = new System.Drawing.Point(0, 40);
            this.suggestionsGridView.MultiSelect = false;
            this.suggestionsGridView.Name = "suggestionsGridView";
            this.suggestionsGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.suggestionsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.suggestionsGridView.RowHeadersVisible = false;
            this.suggestionsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.suggestionsGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.suggestionsGridView.RowTemplate.Height = 50;
            this.suggestionsGridView.RowTemplate.ReadOnly = true;
            this.suggestionsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.suggestionsGridView.Size = new System.Drawing.Size(320, 110);
            this.suggestionsGridView.TabIndex = 1;
            this.suggestionsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.suggestionsGridView_CellContentClick);
            this.suggestionsGridView.SelectionChanged += new System.EventHandler(this.suggestionsGridView_SelectionChanged);
            // 
            // imageDataGridViewCustomColumn
            // 
            this.imageDataGridViewCustomColumn.DataPropertyName = "Image";
            this.imageDataGridViewCustomColumn.Frozen = true;
            this.imageDataGridViewCustomColumn.HeaderText = "Image";
            this.imageDataGridViewCustomColumn.Name = "imageDataGridViewCustomColumn";
            this.imageDataGridViewCustomColumn.ReadOnly = true;
            this.imageDataGridViewCustomColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.imageDataGridViewCustomColumn.Width = 40;
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.urlDataGridViewTextBoxColumn.Frozen = true;
            this.urlDataGridViewTextBoxColumn.HeaderText = "Name";
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            this.urlDataGridViewTextBoxColumn.ReadOnly = true;
            this.urlDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Cancel
            // 
            this.Cancel.Frozen = true;
            this.Cancel.HeaderText = "(Close)";
            this.Cancel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Cancel.Name = "Cancel";
            this.Cancel.ReadOnly = true;
            this.Cancel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cancel.Text = "";
            this.Cancel.TrackVisitedState = false;
            this.Cancel.UseColumnTextForLinkValue = true;
            this.Cancel.Width = 30;
            // 
            // peopleToFollowBindingSource
            // 
            this.peopleToFollowBindingSource.DataSource = typeof(WhoToFollowApp.PeopleToFollow);
            // 
            // segoeUISymbolColumn1
            // 
            this.segoeUISymbolColumn1.Frozen = true;
            this.segoeUISymbolColumn1.HeaderText = "";
            this.segoeUISymbolColumn1.Name = "segoeUISymbolColumn1";
            this.segoeUISymbolColumn1.Text = "";
            // 
            // WhoToFollowControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.suggestionsGridView);
            this.Controls.Add(this.headerPanel);
            this.Name = "WhoToFollowControl";
            this.Size = new System.Drawing.Size(320, 150);
            this.Load += new System.EventHandler(this.WhoToFollowControl_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suggestionsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleToFollowBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel headerPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.LinkLabel refreshLink;
        private System.Windows.Forms.DataGridView suggestionsGridView;
        private System.Windows.Forms.BindingSource peopleToFollowBindingSource;
        private SegoeUISymbolColumn segoeUISymbolColumn1;
        private AvatarColumn imageDataGridViewCustomColumn;
        private System.Windows.Forms.DataGridViewLinkColumn urlDataGridViewTextBoxColumn;
        private SegoeUISymbolColumn Cancel;

    }
}
