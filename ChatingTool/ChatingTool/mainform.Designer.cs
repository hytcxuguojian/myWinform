namespace ChatingTool
{
    partial class mainform
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.userHeadImage = new System.Windows.Forms.PictureBox();
            this.userNick = new System.Windows.Forms.Label();
            this.userShuoshuo = new System.Windows.Forms.Label();
            this.friendList = new System.Windows.Forms.Panel();
            this.ilHeadImages = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.userHeadImage)).BeginInit();
            this.SuspendLayout();
            // 
            // userHeadImage
            // 
            this.userHeadImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userHeadImage.BackgroundImage")));
            this.userHeadImage.Image = ((System.Drawing.Image)(resources.GetObject("userHeadImage.Image")));
            this.userHeadImage.Location = new System.Drawing.Point(22, 12);
            this.userHeadImage.Name = "userHeadImage";
            this.userHeadImage.Size = new System.Drawing.Size(60, 60);
            this.userHeadImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userHeadImage.TabIndex = 0;
            this.userHeadImage.TabStop = false;
            // 
            // userNick
            // 
            this.userNick.AutoSize = true;
            this.userNick.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userNick.Location = new System.Drawing.Point(96, 19);
            this.userNick.Name = "userNick";
            this.userNick.Size = new System.Drawing.Size(67, 14);
            this.userNick.TabIndex = 1;
            this.userNick.Text = "子胥吾有";
            // 
            // userShuoshuo
            // 
            this.userShuoshuo.AutoEllipsis = true;
            this.userShuoshuo.AutoSize = true;
            this.userShuoshuo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userShuoshuo.Location = new System.Drawing.Point(95, 51);
            this.userShuoshuo.MaximumSize = new System.Drawing.Size(155, 12);
            this.userShuoshuo.Name = "userShuoshuo";
            this.userShuoshuo.Size = new System.Drawing.Size(113, 12);
            this.userShuoshuo.TabIndex = 1;
            this.userShuoshuo.Text = "最近生活比较苦逼。";
            // 
            // friendList
            // 
            this.friendList.AutoScroll = true;
            this.friendList.Location = new System.Drawing.Point(2, 92);
            this.friendList.Name = "friendList";
            this.friendList.Size = new System.Drawing.Size(255, 381);
            this.friendList.TabIndex = 2;
            // 
            // ilHeadImages
            // 
            this.ilHeadImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilHeadImages.ImageStream")));
            this.ilHeadImages.TransparentColor = System.Drawing.Color.Transparent;
            this.ilHeadImages.Images.SetKeyName(0, "0.png");
            this.ilHeadImages.Images.SetKeyName(1, "1.png");
            this.ilHeadImages.Images.SetKeyName(2, "2.png");
            this.ilHeadImages.Images.SetKeyName(3, "3.png");
            this.ilHeadImages.Images.SetKeyName(4, "4.png");
            this.ilHeadImages.Images.SetKeyName(5, "5.png");
            this.ilHeadImages.Images.SetKeyName(6, "6.png");
            this.ilHeadImages.Images.SetKeyName(7, "7.png");
            this.ilHeadImages.Images.SetKeyName(8, "8.png");
            this.ilHeadImages.Images.SetKeyName(9, "9.png");
            this.ilHeadImages.Images.SetKeyName(10, "10.png");
            this.ilHeadImages.Images.SetKeyName(11, "Chogath_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(12, "Corki_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(13, "Darius_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(14, "Diana_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(15, "Draven_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(16, "DrMundo_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(17, "Evelynn_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(18, "Ezreal_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(19, "19.jpg");
            this.ilHeadImages.Images.SetKeyName(20, "Fiddlesticks_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(21, "Fiora_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(22, "Fizz_square_0.png");
            this.ilHeadImages.Images.SetKeyName(23, "Galio_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(24, "Gangplank_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(25, "Garen_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(26, "Gragas_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(27, "Graves_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(28, "Hecarim_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(29, "Heimerdinger_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(30, "Irelia_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(31, "Janna_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(32, "JarvanIV_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(33, "Jax_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(34, "Jayce_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(35, "Karma_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(36, "Karthus_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(37, "Kassadin_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(38, "Katarina_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(39, "Kayle_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(40, "Kennen_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(41, "KogMaw_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(42, "Leblanc_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(43, "LeeSin_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(44, "Leona_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(45, "Lulu_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(46, "Lux_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(47, "Malphite_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(48, "Malzahar_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(49, "Maokai_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(50, "MasterYi_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(51, "MissFortune_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(52, "MonkeyKing_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(53, "Mordekaiser_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(54, "Morgana_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(55, "Nasus_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(56, "Nautilus_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(57, "Nidalee_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(58, "Nocturne_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(59, "Nunu_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(60, "Olaf_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(61, "Orianna_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(62, "Pantheon_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(63, "Poppy_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(64, "Rammus_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(65, "Renekton_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(66, "Rengar_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(67, "Riven_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(68, "Rumble_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(69, "Ryze_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(70, "Sejuani_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(71, "Shaco_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(72, "Shen_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(73, "Shyvana_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(74, "Singed_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(75, "Sion_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(76, "Sivir_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(77, "Skarner_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(78, "Sona_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(79, "Soraka_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(80, "Swain_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(81, "Syndra_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(82, "Talon_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(83, "Taric_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(84, "Teemo_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(85, "Tristana_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(86, "Trundle_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(87, "Tryndamere_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(88, "TwistedFate_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(89, "Twitch_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(90, "Udyr_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(91, "Urgot_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(92, "Varus_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(93, "Vayne_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(94, "Veigar_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(95, "Viktor_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(96, "Vladimir_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(97, "Volibear_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(98, "Warwick_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(99, "Xerath_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(100, "XinZhao_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(101, "Yorick_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(102, "Ziggs_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(103, "Zilean_Square_0.png");
            this.ilHeadImages.Images.SetKeyName(104, "Zyra_Square_0.png");
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(258, 506);
            this.Controls.Add(this.friendList);
            this.Controls.Add(this.userShuoshuo);
            this.Controls.Add(this.userNick);
            this.Controls.Add(this.userHeadImage);
            this.Name = "mainform";
            this.Text = "局域聊天器";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainform_FormClosed);
            this.Load += new System.EventHandler(this.mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userHeadImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox userHeadImage;
        private System.Windows.Forms.Label userNick;
        private System.Windows.Forms.Label userShuoshuo;
        private System.Windows.Forms.Panel friendList;
        public System.Windows.Forms.ImageList ilHeadImages;
    }
}

