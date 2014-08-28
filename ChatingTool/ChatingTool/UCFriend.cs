using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChatingTool
{
    public partial class UCFriend : UserControl
    {
        public UCFriend()
        {
            InitializeComponent();
        }
        private mainform frm;

        public mainform Frm
        { 
            get { return frm; }
            set { frm = value; }
        }

        //private ChatForm chatform;

        //public ChatForm Chatform
        //{
        //    get { return chatform; }
        //    set { chatform = value; }
        //}

        private Friend curFriend;

        public Friend CurFriend
        {
            get { return curFriend; }
            set 
            { 
                curFriend = value;
                this.friendNick.Text = curFriend.NickName;
                this.friendShuoshuo.Text = curFriend.shuoshuo;
                this.picHeadImage.Image = this.frm.ilHeadImages.Images[curFriend.HeadImageIndex];
            }
        }

        private void UCFriend_Load(object sender, EventArgs e)
        {
            
        }

        public event EventHandler myDBclick;
    }
}
