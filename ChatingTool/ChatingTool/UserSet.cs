using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ChatingTool
{
    public partial class UserSet : Form
    {
        public UserSet()
        {
            InitializeComponent();
        }

        private UserInfo userinfo;

        public UserInfo Userinfo
        {
            get { return userinfo; }
            set { userinfo = value;}
        }

        private mainform frm;

        public mainform Frm
        {
            get { return frm; }
            set { frm = value; }
        }

        private void UserSet_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < frm.ilHeadImages.Images.Count; i++)
            {
                this.listImages.Items.Add("headimage"+i.ToString());
            }
            this.headImage.Image = Frm.ilHeadImages.Images[userinfo.HeadImageIndex];
            this.tb_nickname.Text = Userinfo.NickName;
            this.rtb_shuoshuo.Text = Userinfo.shuoshuo;
            this.listImages.SelectedIndex = Userinfo.HeadImageIndex;
        }

        private void listImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.headImage.Image = Frm.ilHeadImages.Images[listImages.SelectedIndex];
        }

        public delegate void delSyncUserInfo(UserInfo user);

        private void btn_save_Click(object sender, EventArgs e)
        {
            //将设置后的用户信息序列化到文件中
            UserInfo user = new UserInfo();
            user.NickName = this.tb_nickname.Text;
            user.shuoshuo = this.rtb_shuoshuo.Text;
            user.HeadImageIndex = this.listImages.SelectedIndex;
            this.Userinfo = user;
            IFormatter formater = new BinaryFormatter();
            Stream stream = new FileStream("UserInfo.bin", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            formater.Serialize(stream,user);
            stream.Close();
            //主窗体同步设置后的信息
            object[] pars = new object[1];
            pars[0] = user;
            frm.Invoke(new delSyncUserInfo(frm.SyncUserInfo), pars);
            this.Close();
        }
    }
}
