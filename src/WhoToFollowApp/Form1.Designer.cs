﻿namespace WhoToFollowApp
{
    partial class Form1
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.whoToFollowControl1 = new WhoToFollowApp.WhoToFollowControl();
            this.SuspendLayout();
            // 
            // whoToFollowControl1
            // 
            this.whoToFollowControl1.DataSource = typeof(WhoToFollowApp.PeopleToFollow);
            this.whoToFollowControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.whoToFollowControl1.Location = new System.Drawing.Point(0, 0);
            this.whoToFollowControl1.Name = "whoToFollowControl1";
            this.whoToFollowControl1.Size = new System.Drawing.Size(632, 361);
            this.whoToFollowControl1.TabIndex = 0;
            this.whoToFollowControl1.Link += new System.EventHandler<WhoToFollowApp.LinkEventArgs>(this.whoToFollowControl1_Link);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 361);
            this.Controls.Add(this.whoToFollowControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private WhoToFollowControl whoToFollowControl1;
    }
}

