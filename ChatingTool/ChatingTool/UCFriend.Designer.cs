namespace ChatingTool
{
    partial class UCFriend
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.picHeadImage = new System.Windows.Forms.PictureBox();
            this.friendShuoshuo = new System.Windows.Forms.Label();
            this.friendNick = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picHeadImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picHeadImage
            // 
            this.picHeadImage.BackColor = System.Drawing.SystemColors.Control;
            this.picHeadImage.Location = new System.Drawing.Point(3, 3);
            this.picHeadImage.Name = "picHeadImage";
            this.picHeadImage.Size = new System.Drawing.Size(60, 60);
            this.picHeadImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeadImage.TabIndex = 0;
            this.picHeadImage.TabStop = false;
            // 
            // friendShuoshuo
            // 
            this.friendShuoshuo.AutoEllipsis = true;
            this.friendShuoshuo.AutoSize = true;
            this.friendShuoshuo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.friendShuoshuo.Location = new System.Drawing.Point(80, 44);
            this.friendShuoshuo.MaximumSize = new System.Drawing.Size(155, 12);
            this.friendShuoshuo.Name = "friendShuoshuo";
            this.friendShuoshuo.Size = new System.Drawing.Size(53, 12);
            this.friendShuoshuo.TabIndex = 2;
            this.friendShuoshuo.Text = "好友说说";
            // 
            // friendNick
            // 
            this.friendNick.AutoSize = true;
            this.friendNick.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.friendNick.Location = new System.Drawing.Point(80, 15);
            this.friendNick.Name = "friendNick";
            this.friendNick.Size = new System.Drawing.Size(67, 14);
            this.friendNick.TabIndex = 3;
            this.friendNick.Text = "好友昵称";
            // 
            // UCFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.friendShuoshuo);
            this.Controls.Add(this.friendNick);
            this.Controls.Add(this.picHeadImage);
            this.Name = "UCFriend";
            this.Size = new System.Drawing.Size(245, 66);
            this.Load += new System.EventHandler(this.UCFriend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHeadImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHeadImage;
        private System.Windows.Forms.Label friendShuoshuo;
        private System.Windows.Forms.Label friendNick;
    }
}
