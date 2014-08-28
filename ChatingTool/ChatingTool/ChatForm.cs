using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChatingTool
{
    public partial class ChatForm : Form
    {
        public ChatForm()
        {
            InitializeComponent();
        }

        private Friend friend;

        public Friend Friend
        {
            get { return friend; }
            set { friend = value; }
        }

        public ChatForm(UCFriend ucf)
        {
            InitializeComponent();
            this.Text="与"+ ucf.CurFriend.NickName +"聊天中";
            this.friendheadimg.Image = ucf.Frm.ilHeadImages.Images[ucf.CurFriend.HeadImageIndex];
        }

        
        private void ChatForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
