namespace ChatingTool
{
    partial class ChatForm
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
            this.rtb_msgRecord = new System.Windows.Forms.RichTextBox();
            this.rtb_writeMsg = new System.Windows.Forms.RichTextBox();
            this.friendheadimg = new System.Windows.Forms.PictureBox();
            this.btn_send = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.friendheadimg)).BeginInit();
            this.SuspendLayout();
            // 
            // rtb_msgRecord
            // 
            this.rtb_msgRecord.Location = new System.Drawing.Point(3, 31);
            this.rtb_msgRecord.Name = "rtb_msgRecord";
            this.rtb_msgRecord.ReadOnly = true;
            this.rtb_msgRecord.Size = new System.Drawing.Size(445, 289);
            this.rtb_msgRecord.TabIndex = 0;
            this.rtb_msgRecord.Text = "";
            // 
            // rtb_writeMsg
            // 
            this.rtb_writeMsg.Location = new System.Drawing.Point(3, 346);
            this.rtb_writeMsg.Name = "rtb_writeMsg";
            this.rtb_writeMsg.Size = new System.Drawing.Size(445, 40);
            this.rtb_writeMsg.TabIndex = 1;
            this.rtb_writeMsg.Text = "";
            // 
            // friendheadimg
            // 
            this.friendheadimg.Location = new System.Drawing.Point(463, 31);
            this.friendheadimg.Name = "friendheadimg";
            this.friendheadimg.Size = new System.Drawing.Size(100, 100);
            this.friendheadimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.friendheadimg.TabIndex = 2;
            this.friendheadimg.TabStop = false;
            // 
            // btn_send
            // 
            this.btn_send.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_send.Location = new System.Drawing.Point(463, 346);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(100, 40);
            this.btn_send.TabIndex = 3;
            this.btn_send.Text = "发送消息";
            this.btn_send.UseVisualStyleBackColor = true;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 397);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.friendheadimg);
            this.Controls.Add(this.rtb_writeMsg);
            this.Controls.Add(this.rtb_msgRecord);
            this.Name = "ChatForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.friendheadimg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_msgRecord;
        private System.Windows.Forms.RichTextBox rtb_writeMsg;
        private System.Windows.Forms.PictureBox friendheadimg;
        private System.Windows.Forms.Button btn_send;
    }
}