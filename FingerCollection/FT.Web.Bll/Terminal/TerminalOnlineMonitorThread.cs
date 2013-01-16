﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Collections;

namespace FT.Web.Bll.Terminal
{
    /// <summary>
    /// 依据Terminal_Check_Thread_Time配置节的value进行线程处理
    /// </summary>
    public class TerminalOnlineMonitorThread
    {
        private static ArrayList lists = new ArrayList();
        private static Thread thread=null;

        private static object synObject=new object();

        private static int threadMiniSecond = 30;

        public static TerminalStatus GetTerminal(string ip)
        {
            if (lists.Count == 0)
            {
                lock (synObject)
                {
                    lists = FT.DAL.Orm.SimpleOrmOperator.QueryListAll(typeof(TerminalStatus));
                }
            }
            TerminalStatus terminal = null;
            for (int i = 0; i < lists.Count; i++)
            {
                terminal = lists[i] as TerminalStatus;
                if (terminal.MachineIp == ip)
                {
                    break;
                }
            }
            return terminal;
        }
        static TerminalOnlineMonitorThread()
        {
            try
            {
                threadMiniSecond = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["Terminal_Check_Thread_Time"]) * 1000;
                InitTerminalList();
            }
            catch
            {
            }
        }
        private  TerminalOnlineMonitorThread()
        {
        }

        public static void InitTerminalList()
        {
            lock (synObject)
            {
                lists = FT.DAL.Orm.SimpleOrmOperator.QueryListAll(typeof(TerminalStatus));
            }
        }

        private static void CheckTerminalOnline()
        {
            string oldStatus = string.Empty;
            string newStatus = string.Empty;
            TerminalStatus terminal = null;
            while (true)
            {
                for (int i = 0; i < lists.Count; i++)
                {
                    terminal = lists[i] as TerminalStatus;
                    oldStatus = terminal.OnlineStatus;
                    bool online = FT.Commons.Tools.WindowExHelper.CanConnectionTo(terminal.MachineIp);
                    newStatus = online ? "在线" : "不在线";

                    if (oldStatus.Length > 0)
                    {
                        if (online)
                        {
                            terminal.LastOnlineTime = System.DateTime.Now;
                            terminal.OnlineSeconds += threadMiniSecond / 1000;
                        }
                        if (oldStatus != newStatus)
                        {
                            if (online)
                            {
                                
                               // int onlineSec = (int)terminal.LastOutlineTime.Subtract(terminal.LastCheckTime).TotalSeconds;
                               // terminal.OnlineSeconds += onlineSec;
                            }
                            //在线变成不在线状态
                            else
                            {
                                terminal.LastOutlineTime = System.DateTime.Now;
                                //int onlineSec = (int)terminal.LastOutlineTime.Subtract(terminal.LastCheckTime).TotalSeconds;
                                //terminal.OnlineSeconds += onlineSec;
                                terminal.OnlineSeconds += threadMiniSecond / 1000;

                            }
                            FT.DAL.Orm.SimpleOrmOperator.Update(terminal);
                        }
                        
                    }
                    //else if(oldStatus.Length>0&&online)
                   // {
                       // int onlineSec = (int)terminal.LastOutlineTime.Subtract(terminal.LastCheckTime).TotalSeconds;
                       // terminal.OnlineSeconds += threadMiniSecond/1000;
                   // }
                    terminal.OnlineStatus = newStatus;
                    terminal.LastCheckTime = System.DateTime.Now;
                }
                System.Threading.Thread.Sleep(threadMiniSecond);
            }
        }

        public static void StartThread()
        {
            if (thread == null)
            {
                thread = new Thread(new ThreadStart(CheckTerminalOnline));
                thread.Start();
            }
        }

        public static void StopThread()
        {
            try
            {
                if (thread != null)
                {
                    thread.Abort();
                }
                string newStatus = string.Empty;
                TerminalStatus terminal = null;
                for (int i = 0; i < lists.Count; i++)
                {
                    terminal = lists[i] as TerminalStatus;
                    terminal.LastCheckTime = System.DateTime.Now;
                    bool online = FT.Commons.Tools.WindowExHelper.CanConnectionTo(terminal.MachineIp);
                    newStatus = online ? "在线" : "不在线";

                    if (online)
                        {
                            terminal.LastOnlineTime = System.DateTime.Now;
                           
                        }
                        //在线变成不在线状态
                        else
                        {
                            terminal.LastOutlineTime = System.DateTime.Now;
                           

                        }
                        FT.DAL.Orm.SimpleOrmOperator.Update(terminal);

                    
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
        }
    }
}