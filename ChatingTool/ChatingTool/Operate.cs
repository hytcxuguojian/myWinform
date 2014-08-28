using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace ChatingTool
{
    public class Operate
    {
        private mainform form;
        public Operate(mainform f)
        {
            this.form = f;
        }

        public delegate void delAddFriend(Friend friend);
        public delegate void delRemoveFriend(IPAddress IP);

        public void listen()
        {
            UdpClient uc = new UdpClient(9527);
            while (true)
            {
                IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 0);
                byte[] b = uc.Receive(ref ipep);
                string msg = Encoding.Default.GetString(b);
                string[] datas = msg.Split('|');
                switch (datas[0])
                {
                    case "LOGIN":
                        if (datas.Length != 4)
                        {
                            continue;
                        }
                        if(ipep.Address.ToString()==getMyIP().ToString())
                        {
                            continue;
                        }
                        Friend friend = new Friend();
                        int curIndex = Convert.ToInt32(datas[2]);
                        if (curIndex < 0 || curIndex >= form.ilHeadImages.Images.Count)
                        {
                            curIndex = 0;
                        }
                        friend.HeadImageIndex = curIndex;
                        friend.NickName = datas[1];
                        friend.shuoshuo = datas[3];
                        friend.IP = ipep.Address;
                        friend.istalking = false;
                        object[] loginPars = new object[1];
                        loginPars[0] = friend;
                        form.Invoke(new delAddFriend(form.addUcf), loginPars);

                        //回发，通知其他人自己已经上线
                        string returnmsg = "ALSOON|子胥吾有|19|轻轻的我来了！";
                        ipep = new IPEndPoint(ipep.Address, 9527);
                        form.SendMessage(returnmsg, ipep);
                        break;

                    case "ALSOON":
                        if (datas.Length != 4)
                        {
                            continue;
                        }
                        Friend alsofriend = new Friend();
                        int alsocurIndex = Convert.ToInt32(datas[2]);
                        if (alsocurIndex < 0 || alsocurIndex >= form.ilHeadImages.Images.Count)
                        {
                            alsocurIndex = 0;
                        }
                        alsofriend.HeadImageIndex = alsocurIndex;
                        alsofriend.NickName = datas[1];
                        alsofriend.shuoshuo = datas[3];
                        alsofriend.IP = ipep.Address;
                        alsofriend.istalking = false;
                        object[] ALSOONpars = new object[1];
                        ALSOONpars[0] = alsofriend;
                        form.Invoke(new delAddFriend(form.addUcf), ALSOONpars);
                        break;

                    case "LOGOUT":
                        object[] logoutpars = new object[1];
                        logoutpars[0] = ipep.Address;
                        form.Invoke(new delRemoveFriend(form.removeucf), logoutpars);
                        break;
                    default:
                        break;
                }
                
            }
        }

        public static IPAddress getMyIP()
        {
            IPAddress myIP = null ;
            IPAddress[] addrIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach(var item in addrIP)
            {
                if(item.AddressFamily==AddressFamily.InterNetwork)
                {
                    myIP = item;
                    break;
                }
            }
            return myIP;
        }
    }
}
