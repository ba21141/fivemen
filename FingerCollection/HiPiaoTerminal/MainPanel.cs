﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using HiPiaoTerminal.Account;
using HiPiaoTerminal.UserRegister;
using HiPiaoTerminal.CommonForm;
using HiPiaoTerminal.UserControlEx;
using HiPiaoTerminal.Maintain;
using HiPiaoTerminal.TestForm;
using HiPiaoTerminal.BuyTicket;
using HiPiaoInterface;
using HiPiaoTerminal.ConfigModel;

namespace HiPiaoTerminal
{
    public partial class MainPanel : SameBackgroudParentPanel
    {

        public MainPanel()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                   ControlStyles.ResizeRedraw |
                   ControlStyles.AllPaintingInWmPaint, true);
            //timerShowMovie.Start();
            Console.WriteLine("MainPanel_Load开始隐藏小键盘");
            GlobalTools.HideAllKeyBoard();
            GlobalTools.RegistUpdateUnOperationTime(null);
            GlobalTools.StopUnOperationCounter();
            if (GlobalTools.loginUser == null)
            {
                this.lbWelcome1.Visible = false;
                this.lbWelcomeName.Visible = false;
                this.lbWelcome3.Visible = false;
                this.btnQuit.Visible = false;
            }
            else
            {
                this.lbWelcome1.Visible = true;
                this.lbWelcomeName.Visible = true;
                this.lbWelcomeName.Text = GlobalTools.loginUser.Name;
                this.lbWelcome3.Visible = true;
                this.btnQuit.Visible = true;
                this.lbWelcomeName.Location = new Point(this.lbWelcome3.Location.X - this.lbWelcomeName.Width, this.lbWelcome3.Location.Y);
                this.lbWelcome1.Location = new Point(this.lbWelcomeName.Location.X - this.lbWelcome1.Width,this.lbWelcome3.Location.Y);
                //FT.Commons.Tools.WinFormHelper.LocationAfter(this.lbWelcomeName, this.lbWelcome3);
            }
            GlobalTools.CloseAllPopForms();
	    try
            {
            	if (this.DesignMode)
            	{
                	Cursor = Cursors.Default;
            	}
            	else
                	GlobalTools.SetCursor();

	    }
	    catch(Exception ex)
	    {
	    }
                 
        }

        private void btnLoginPassport_Click(object sender, EventArgs e)
        {
            GlobalTools.ReturnUserAccout();
        }

        private void btnBuyTicket_Click(object sender, EventArgs e)
        {
            if (GlobalTools.loginUser == null)
            {
                GlobalTools.GoPanel(new UserLoginPanel(1));
            }
            else
            GlobalTools.QuickBuyTicket();
        }

        private void btnTicketPrint_Click(object sender, EventArgs e)
        {
            GlobalTools.ReturnTicketPrint();
        }

        private void btnQuickRegister_Click(object sender, EventArgs e)
        {
            GlobalTools.QuickRegister();
        }

        private void btnUserTaste_Click(object sender, EventArgs e)
        {
            GlobalTools.UserTaste();
        }

        private void timerShowMovie_Tick(object sender, EventArgs e)
        {
            /*
            //timerShowMovie.Stop();
            SystemConfig config = FT.Commons.Cache.StaticCacheManager.GetConfig<SystemConfig>();
            List<AdvertisementObject> lists=HiPiaoCache.GetAdvertisement(config.Cinema);
            int len = lists.Count;
            if (len == 0)
            {
                
                return;
            }
            if (this.picShowMovies.Tag == null || this.picShowMovies.Tag.ToString() == (len - 1).ToString())
            {
                this.picShowMovies.Image = lists[0].AdvPic;
                this.picShowMovies.Tag = "0";
            }
            else
            {
                int currentIndex = Convert.ToInt32(this.picShowMovies.Tag.ToString());
                int nowIndex = currentIndex + 1;
                this.picShowMovies.Image = lists[nowIndex].AdvPic; 
                this.picShowMovies.Tag = nowIndex.ToString();
            }

            timerShowMovie.Start();
            */
        }

        

        private void MainPanel_Load(object sender, EventArgs e)
        {
           // ControlPaint.DrawButton(Graphics.FromHwnd(this.btnTicketPrint.Handle),
             //   new Rectangle(10, 10, btnTicketPrint.Width - 10, btnTicketPrint.Height - 10),
            //    ButtonState.Pushed);


          
            if(!adFullTimer.Enabled)
            {
                  SystemConfig config = FT.Commons.Cache.StaticCacheManager.GetConfig<SystemConfig>();
                  if (config.FullScreenSecond > 0)
                  {
                      adFullTimer.Interval = config.FullScreenSecond * 1000;
                      adFullTimer.Stop();
                      adFullTimer.Start();
                  }
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //GlobalTools.Pop(new UserRegisterSuccessPanel());
            GlobalTools.Pop(new BindMobilePanel());
            //GlobalTools.ReturnMaintain();
            //GlobalTools.ShowMessage(new QuickPassportPanel());
           // GlobalTools.ShowMessage("网络故障，请向影院工作人员垂询！\r\n或拨打400-601-556！", true);
           // Account.ConfirmQuitAccountForm form = new HiPiaoTerminal.Account.ConfirmQuitAccountForm();
            //Form form =null;
           // form= new UIdOrPwdErrorForm();
            //form = new RegisterSuccessForm();
            //form = new NotifyUserForm();
            //form.Show();
            //GlobalTools.Pop(new UserRegisterSuccessPanel2());
            //GlobalTools.ReturnMaintainWithPwd();
            //GlobalTools.GoPanel(new ManagerModifyPwdPanel());
            //GlobalTools.Pop(new UserControl1());
           // Form frm = new RoundForm();
           // frm.ShowDialog();
            //GlobalTools.PopFirstWpf(new UserRegisterSuccessWpf());

           // GlobalTools.Pop(new UserNeedKnowInfoPanel());
           // GlobalTools.Pop(new UserNeedKnowInfoPanel());
           // GlobalTools.PopNetError();
          //  GlobalTools.Pop(new ConfirmPayPwdPanel());
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            //GlobalTools.ShowInput(this.textBox1);
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            //GlobalTools.ShowInput(this.textBox2);
        }

        private void picToMaintain_Click(object sender, EventArgs e)
        {
            
        }

        private void picToMaintain2_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            GlobalTools.QuitAccount();
        }

        private bool allowToMaintain = false;

        private void picToMaintain_DoubleClick(object sender, EventArgs e)
        {
            allowToMaintain = true;
        }

        private void picToMaintain2_DoubleClick(object sender, EventArgs e)
        {
            if (allowToMaintain)
            {
                GlobalTools.ReturnMaintainWithPwd();
            }
        }

        public void StopAdTimer()
        {
#if DEBUG
            Console.WriteLine(System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "停止全屏广告计时!时间间隔为：" + adFullTimer.Interval);
#endif
            this.adFullTimer.Stop();
        }
        public void StartAdTimer()
        {
#if DEBUG
            Console.WriteLine(System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "启动全屏广告计时!时间间隔为："+adFullTimer.Interval);
#endif
            this.adFullTimer.Start();
        }

        private void adFullTimer_Tick(object sender, EventArgs e)
        {
           
            if (this.Visible)
            {
                adFullTimer.Stop();
#if DEBUG
                Console.WriteLine(System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "全屏广告展示时间到：");
#endif
                GlobalTools.ShowFullAdForm();
                adFullTimer.Start();
            }
        }

        
    }
}
