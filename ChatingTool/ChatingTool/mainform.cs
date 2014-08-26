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

namespace ChatingTool
{
    public partial class mainform : Form
    {
        public delegate void delAddFriend(Friend friend);

        public mainform()
        {
            InitializeComponent();
        }
        List<Friend> ucflist = new List<Friend>();
        string ip;//ip地址
        IPEndPoint ipep;
        string nick;//用户昵称

        private void mainform_Load(object sender, EventArgs e)
        {
            mainform.CheckForIllegalCrossThreadCalls = false;
            Thread t = new Thread(new ThreadStart(listen));
            Thread.Sleep(100);
            t.IsBackground = true;
            t.Start();
            nick = this.userNick.Text;
            string msg = "LOGIN|" + nick + "|19|轻轻的我来了！";
            ip = "255.255.255.255";
            ipep = new IPEndPoint(IPAddress.Parse(ip), 9527);
            SendMessage(msg, ipep);
        }

        private void listen()
        {
            UdpClient uc = new UdpClient(9527);
            while (true)
            {
                IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 0);
                byte[] b = uc.Receive(ref ipep);
                string msg = Encoding.Default.GetString(b);
                string[] datas = msg.Split('|');
                if (datas.Length > 4)
                {
                    continue;
                }
                if (datas[0] == "LOGIN")
                {
                    Friend friend = new Friend();
                    int curIndex = Convert.ToInt32(datas[2]);
                    if (curIndex<0||curIndex>=this.ilHeadImages.Images.Count)
                    {
                        curIndex=0;
                    }
                    friend.HeadImageIndex = curIndex;
                    friend.NickName = datas[1];
                    friend.shuoshuo = datas[3];
                    object[] pars=new object[1];
                    pars[0]=friend;
                    this.Invoke(new delAddFriend(this.addUcf), pars);
                }
                if (datas[0] == "LOGOUT")
                {
                    Friend friend = new Friend();
                    int curIndex = Convert.ToInt32(datas[2]);
                    if (curIndex < 0 || curIndex >= this.ilHeadImages.Images.Count)
                    {
                        curIndex = 0;
                    }
                    friend.HeadImageIndex = curIndex;
                    friend.NickName = datas[1];
                    friend.shuoshuo = datas[3];
                    //object[] pars = new object[1];
                    //pars[0] = friend;
                    //this.Invoke(new delAddFriend(this.removeucf), pars);
                    removeucf(friend);
                }
            }
        }

        public void addUcf(Friend f)
        {
            UCFriend ucf = new UCFriend();
            ucf.Frm = this;
            ucf.CurFriend = f;
            ucf.Top = this.friendList.Controls.Count * ucf.Height;
            this.friendList.Controls.Add(ucf);
            ucflist.Add(f);
            if (this.friendList.Controls.Count >= 6)
            {
                for (int j = 0; j < this.friendList.Controls.Count; j++)
                {
                    this.friendList.Controls[j].Width = 230;
                }
            }
        }

        public void removeucf(Friend f)
        {
            for (int i = 0; i < ucflist.Count; i++)
            {
                if (ucflist[i].NickName==f.NickName)
                {
                    ucflist.RemoveAt(i);
                    this.friendList.Controls.RemoveAt(i);
                }
            }
            for (int i = 0; i < ucflist.Count; i++)
            {
                this.friendList.Controls[i].Top = i * Controls[i].Height;
            }
        }

        private void SendMessage(string Message, IPEndPoint ipep)
        {
            Byte[] bt = Encoding.Default.GetBytes(Message);
            UdpClient udp = new UdpClient();
            udp.Send(bt, bt.Length, ipep);
        }

        private void mainform_FormClosed(object sender, FormClosedEventArgs e)
        {
            string msg = "LOGOUT|" + nick + "|19|轻轻的我走了！";
            SendMessage(msg, ipep);
        }
    }
}
