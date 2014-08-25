using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Net.Sockets;

namespace chattingOnline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string ip;//ip地址
        IPEndPoint ipep;
        string nick;//用户昵称
        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "PUBLIC|" + this.inputMessage.Text + "|" + nick + "|" + this.inputMessage.Text.Length;
            SendMessage(msg, ipep);
        }

        private void listen()
        {
            UdpClient uc = new UdpClient(9527);
            while(true)
            {
                IPEndPoint ipep = new IPEndPoint(IPAddress.Any,0);
                byte[] b = uc.Receive(ref ipep);
                string msg = Encoding.Default.GetString(b);
                string[] message = msg.Split('|');
                if (message[0] == "INROOM")
                {
                    this.richTextBox1.Text += message[1] + "上线了" + "\r\n";
                    this.listBox1.Items.Add(message[1]);
                }
                if (message[0] == "PUBLIC")
                {
                    if (message.Length > 4)
                    {
                        int talkcharnum = Convert.ToInt16(message[message.Length - 1]);
                        string talkContent = msg.Substring(7, talkcharnum);
                        string talker = message[message.Length - 2];
                        this.richTextBox1.Text += talker + "说：" + talkContent + "\r\n";
                    }
                    else
                    {
                        this.richTextBox1.Text += message[2] + "说："+ message[1] + "\r\n";
                    }
                }
                if (message[0] == "OUTROOM")
                {
                    this.richTextBox1.Text += message[1] + "下线了" + "\r\n";
                    this.listBox1.Items.Remove(message[1]);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1.CheckForIllegalCrossThreadCalls = false;
            Thread t = new Thread(new ThreadStart(listen));
            t.IsBackground = true;
            t.Start();
            nick = this.textbox_nick.Text;
            string msg = "INROOM|" + nick;
            ip = this.iptextBox.Text;
            ipep = new IPEndPoint(IPAddress.Parse(ip), 9527);
            SendMessage(msg, ipep);
        }

        private void SendMessage(string Message, IPEndPoint ipep)
        {
            Byte[] bt = Encoding.Default.GetBytes(Message);
            UdpClient udp = new UdpClient();
            udp.Send(bt, bt.Length, ipep);
            this.inputMessage.Clear();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string msg = "OUTROOM|" + nick;
            SendMessage(msg,ipep);
        }
    }
}
