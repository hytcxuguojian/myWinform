namespace ChatingTool
{
    partial class UserSet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headImage = new System.Windows.Forms.PictureBox();
            this.shuoshuo = new System.Windows.Forms.Label();
            this.nickname = new System.Windows.Forms.Label();
            this.tb_nickname = new System.Windows.Forms.TextBox();
            this.rtb_shuoshuo = new System.Windows.Forms.RichTextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.listImages = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.headImage)).BeginInit();
            this.SuspendLayout();
            // 
            // headImage
            // 
            this.headImage.Location = new System.Drawing.Point(21, 12);
            this.headImage.Name = "headImage";
            this.headImage.Size = new System.Drawing.Size(100, 100);
            this.headImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headImage.TabIndex = 0;
            this.headImage.TabStop = false;
            // 
            // shuoshuo
            // 
            this.shuoshuo.AutoSize = true;
            this.shuoshuo.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.shuoshuo.Location = new System.Drawing.Point(12, 188);
            this.shuoshuo.Name = "shuoshuo";
            this.shuoshuo.Size = new System.Drawing.Size(109, 19);
            this.shuoshuo.TabIndex = 2;
            this.shuoshuo.Text = "个性签名：";
            // 
            // nickname
            // 
            this.nickname.AutoSize = true;
            this.nickname.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nickname.Location = new System.Drawing.Point(17, 128);
            this.nickname.Name = "nickname";
            this.nickname.Size = new System.Drawing.Size(69, 19);
            this.nickname.TabIndex = 2;
            this.nickname.Text = "昵称：";
            // 
            // tb_nickname
            // 
            this.tb_nickname.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_nickname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_nickname.Location = new System.Drawing.Point(92, 125);
            this.tb_nickname.Name = "tb_nickname";
            this.tb_nickname.Size = new System.Drawing.Size(287, 29);
            this.tb_nickname.TabIndex = 3;
            // 
            // rtb_shuoshuo
            // 
            this.rtb_shuoshuo.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtb_shuoshuo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rtb_shuoshuo.Location = new System.Drawing.Point(117, 188);
            this.rtb_shuoshuo.Name = "rtb_shuoshuo";
            this.rtb_shuoshuo.Size = new System.Drawing.Size(262, 59);
            this.rtb_shuoshuo.TabIndex = 4;
            this.rtb_shuoshuo.Text = "";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(304, 256);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // listImages
            // 
            this.listImages.FormattingEnabled = true;
            this.listImages.ItemHeight = 12;
            this.listImages.Location = new System.Drawing.Point(152, 12);
            this.listImages.Name = "listImages";
            this.listImages.Size = new System.Drawing.Size(227, 100);
            this.listImages.TabIndex = 6;
            this.listImages.SelectedIndexChanged += new System.EventHandler(this.listImages_SelectedIndexChanged);
            // 
            // UserSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 291);
            this.Controls.Add(this.listImages);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.rtb_shuoshuo);
            this.Controls.Add(this.tb_nickname);
            this.Controls.Add(this.nickname);
            this.Controls.Add(this.shuoshuo);
            this.Controls.Add(this.headImage);
            this.Name = "UserSet";
            this.Text = "用户设置";
            this.Load += new System.EventHandler(this.UserSet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.headImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox headImage;
        private System.Windows.Forms.Label shuoshuo;
        private System.Windows.Forms.Label nickname;
        private System.Windows.Forms.TextBox tb_nickname;
        private System.Windows.Forms.RichTextBox rtb_shuoshuo;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ListBox listImages;
    }
}