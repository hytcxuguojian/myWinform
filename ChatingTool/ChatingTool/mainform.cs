using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ChatingTool
{
    public partial class mainform : Form
    {
        

        public mainform()
        {
            InitializeComponent();
        }
        public List<UCFriend> ucflist = new List<UCFriend>();
        
        IPEndPoint ipep;
        //用户信息
        UserInfo user = new UserInfo();
        private Thread t;
        private void mainform_Load(object sender, EventArgs e)
        {
            IPAddress myIP = Operate.getMyIP();
            if(myIP==null)
            {
                MessageBox.Show("未找到可用网卡，请检查！");
                Application.Exit();
            }
            mainform.CheckForIllegalCrossThreadCalls = false;
            Operate ope = new Operate(this);
            t = new Thread(new ThreadStart(ope.listen));
            Thread.Sleep(100);
            t.IsBackground = true;
            t.Start();
            try
            {
                //将存储用户信息的文件反序列化出来
                IFormatter formater = new BinaryFormatter();
                Stream stream = new FileStream("UserInfo.bin", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                user = (UserInfo)formater.Deserialize(stream);
                stream.Close();
                this.userNick.Text = user.NickName;
                this.userHeadImage.Image = this.ilHeadImages.Images[user.HeadImageIndex];
                this.userShuoshuo.Text = user.shuoshuo;
            }
            catch
            {
                MessageBox.Show("您首次使用此软件，赶快去设置自己的资料让小伙伴识别你吧！");
            }
            string msg = "LOGIN|" + this.userNick.Text +"|19|" + this.userShuoshuo.Text;
            ipep = new IPEndPoint(IPAddress.Parse("255.255.255.255"), 9527);
            SendMessage(msg, ipep);
        }

        public void addUcf(Friend f)
        {
            UCFriend ucf = new UCFriend();
            ucf.Frm = this;
            ucf.CurFriend = f;
            ucf.Top = this.friendList.Controls.Count * ucf.Height;
            ucf.DoubleClick += ucf_DoubleClick;
            this.friendList.Controls.Add(ucf);
            ucflist.Add(ucf);
            if (this.friendList.Controls.Count >= 6)
            {
                for (int j = 0; j < this.friendList.Controls.Count; j++)
                {
                    this.friendList.Controls[j].Width = 230;
                }
            }
        }

        void ucf_DoubleClick(object sender, EventArgs e)
        {
            UCFriend ucf = (UCFriend)sender;
            if (ucf.CurFriend.istalking == false)
            {
                ChatForm chatform = new ChatForm((UCFriend)sender);
                chatform.Show();
                ucf.CurFriend.istalking = true;
            }
        }

        public void removeucf(IPAddress ip)
        {
            List<UCFriend> newlist = new List<UCFriend>();
            for (int i = 0; i < ucflist.Count; i++)
            {
                if (ucflist[i].CurFriend.IP.ToString()!= ip.ToString())
                {
                    newlist.Add(ucflist[i]);
                }
            }
            this.friendList.Controls.Clear();
            ucflist.Clear();
            for (int j = 0; j < newlist.Count; j++)
            {
                addUcf(newlist[j].CurFriend);
            }
        }

        public void SendMessage(string Message, IPEndPoint ipep)
        {
            Byte[] bt = Encoding.Default.GetBytes(Message);
            UdpClient udp = new UdpClient();
            udp.Send(bt, bt.Length, ipep);
        }

        public void SyncUserInfo(UserInfo user)
        {
            this.userNick.Text = user.NickName;
            this.userHeadImage.Image = this.ilHeadImages.Images[user.HeadImageIndex];
            this.userShuoshuo.Text = user.shuoshuo;
        }

        private void mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Abort();
            string msg = "LOGOUT|";
            SendMessage(msg, ipep);
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            UserSet us = new UserSet();
            us.Userinfo = user;
            us.Frm = this;
            us.ShowDialog();
        } 
    }
}
