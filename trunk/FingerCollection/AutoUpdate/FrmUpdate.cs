using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Xml;
using System.Net;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace AutoUpdate
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class FrmUpdate : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ColumnHeader chFileName;
		private System.Windows.Forms.ColumnHeader chVersion;
		private System.Windows.Forms.ColumnHeader chProgress;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListView lvUpdateList;
		private System.Windows.Forms.Label lbFileListHint;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.ProgressBar pbDownFile;
        private System.Windows.Forms.Button btnFinish;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private LinkLabel linkLabel1;
        private Label label5;

		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;


		public FrmUpdate()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
			//
			// TODO: �� InitializeComponent ���ú������κι��캯������
			//
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdate));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbFileListHint = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvUpdateList = new System.Windows.Forms.ListView();
            this.chFileName = new System.Windows.Forms.ColumnHeader();
            this.chVersion = new System.Windows.Forms.ColumnHeader();
            this.chProgress = new System.Windows.Forms.ColumnHeader();
            this.pbDownFile = new System.Windows.Forms.ProgressBar();
            this.lbState = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 240);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbFileListHint);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.lvUpdateList);
            this.panel1.Controls.Add(this.pbDownFile);
            this.panel1.Controls.Add(this.lbState);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(120, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 240);
            this.panel1.TabIndex = 2;
            // 
            // lbFileListHint
            // 
            this.lbFileListHint.AutoSize = true;
            this.lbFileListHint.Location = new System.Drawing.Point(16, 16);
            this.lbFileListHint.Name = "lbFileListHint";
            this.lbFileListHint.Size = new System.Drawing.Size(113, 12);
            this.lbFileListHint.TabIndex = 9;
            this.lbFileListHint.Text = "����Ϊ�����ļ��б�";
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 2);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lvUpdateList
            // 
            this.lvUpdateList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFileName,
            this.chVersion,
            this.chProgress});
            this.lvUpdateList.Location = new System.Drawing.Point(3, 48);
            this.lvUpdateList.Name = "lvUpdateList";
            this.lvUpdateList.Size = new System.Drawing.Size(272, 120);
            this.lvUpdateList.TabIndex = 6;
            this.lvUpdateList.UseCompatibleStateImageBehavior = false;
            this.lvUpdateList.View = System.Windows.Forms.View.Details;
            // 
            // chFileName
            // 
            this.chFileName.Text = "�����";
            this.chFileName.Width = 123;
            // 
            // chVersion
            // 
            this.chVersion.Text = "�汾��";
            this.chVersion.Width = 98;
            // 
            // chProgress
            // 
            this.chProgress.Text = "����";
            this.chProgress.Width = 47;
            // 
            // pbDownFile
            // 
            this.pbDownFile.Location = new System.Drawing.Point(3, 200);
            this.pbDownFile.Name = "pbDownFile";
            this.pbDownFile.Size = new System.Drawing.Size(274, 17);
            this.pbDownFile.TabIndex = 5;
            // 
            // lbState
            // 
            this.lbState.Location = new System.Drawing.Point(3, 176);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(240, 16);
            this.lbState.TabIndex = 4;
            this.lbState.Text = "�������һ������ʼ�����ļ�";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 8);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(224, 264);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(80, 24);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "��һ��(&N)>";
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(312, 264);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 24);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "ȡ��(&C)";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(136, 264);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(80, 24);
            this.btnFinish.TabIndex = 3;
            this.btnFinish.Text = "���(&F)";
            this.btnFinish.Visible = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(0, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(280, 8);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(112, 2);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox2";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(24, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 48);
            this.label2.TabIndex = 10;
            this.label2.Text = "     ����������,�����������ڼ䱻�ر�,���\"���\"�Զ����³�����Զ���������ϵͳ��";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(24, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "��ӭ�Ժ������ע���ǵĲ�Ʒ��";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(144, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "�й����������";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Location = new System.Drawing.Point(8, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 24);
            this.panel2.TabIndex = 5;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(0, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(100, 23);
            this.linkLabel1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(16, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "��лʹ����������";
            // 
            // FrmUpdate
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(424, 301);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFinish);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "�Զ�����";
            this.Load += new System.EventHandler(this.FrmUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private string updateUrl = string.Empty;
		private string tempUpdatePath = string.Empty;
		XmlFiles updaterXmlFiles = null;
		private int availableUpdate = 0;
		bool isRun = false;
		string mainAppExe = "";

		/// <summary>
		/// Ӧ�ó��������ڵ㡣
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new FrmUpdate());
        }

        #region Load�¼�
        private void FrmUpdate_Load(object sender, System.EventArgs e)
		{
			
			panel2.Visible = false;
			btnFinish.Visible = false;
            
			string localXmlFile = Application.StartupPath + "\\UpdateList.xml";
			string serverXmlFile = string.Empty;

            
			try
			{
				//�ӱ��ض�ȡ���������ļ���Ϣ
                TempLog.Debug("׼����������·���µ�UpdateList.xml�����ļ���");
                updaterXmlFiles = new XmlFiles(localXmlFile);
                mainAppExe = updaterXmlFiles.GetNodeValue("//EntryPoint");
                TempLog.Debug("��������·���µ�UpdateList.xml�����ļ�����ȡ��������ִ�е�exe�ļ�����ϣ�");
				
                
			}
			catch(Exception ex)
			{
                TempLog.Info("����UpdateList.xml�����쳣��"+ex);
				//MessageBox.Show("�����ļ�����!","����",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.StartMainApplication();
				return;
			}
			//��ȡ��������ַ
			updateUrl = updaterXmlFiles.GetNodeValue("//Url");

			AppUpdater appUpdater = new AppUpdater();
			appUpdater.UpdaterUrl = updateUrl + "UpdateList.xml";

			//�����������,���ظ��������ļ�
			try
			{
                TempLog.Debug("׼�����ظ��������ļ��б�UpdateList.xml");
				tempUpdatePath = Environment.GetEnvironmentVariable("Temp") + "\\"+ "_"+ updaterXmlFiles.FindNode("//Application").Attributes["applicationId"].Value+"_"+"y"+"_"+"x"+"_"+"m"+"_"+"\\";
				appUpdater.DownAutoUpdateFile(tempUpdatePath);
                TempLog.Debug("������ظ��������ļ��б�UpdateList.xml");
			}
			catch(Exception ex)
			{
                TempLog.Info("���ظ��������ļ��б�UpdateList.xml�����쳣��" + ex);
				//MessageBox.Show("�����������ʧ��,������ʱ!","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.StartMainApplication();
				return;

			}

			//��ȡ�����ļ��б�
			Hashtable htUpdateFile = new Hashtable();

			serverXmlFile = tempUpdatePath + "\\UpdateList.xml";
			if(!File.Exists(serverXmlFile))
			{
				return;
			}

			availableUpdate = appUpdater.CheckForUpdate(serverXmlFile,localXmlFile,out htUpdateFile);
			if (availableUpdate > 0)
			{
				for(int i=0;i<htUpdateFile.Count;i++)
				{
					string [] fileArray =(string []) htUpdateFile[i];
					lvUpdateList.Items.Add(new ListViewItem(fileArray));
				}
			}
            this.lbFileListHint.Text = string.Format("��{0}���ļ�������,׼��������{1}",lvUpdateList.Items.Count.ToString(),string.Empty);
            btnNext_Click(null, null);
//			else
//				btnNext.Enabled = false;
        }

        #endregion

        private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
			Application.ExitThread();
			Application.Exit();
		}

		private void btnNext_Click(object sender, System.EventArgs e)
		{
			if (availableUpdate > 0)
			{
					Thread threadDown=new Thread(new ThreadStart(DownUpdateFile));
					threadDown.IsBackground = true;
					threadDown.Start();
			}
			else
			{
				//MessageBox.Show("û�п��õĸ���!","�Զ�����",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.StartMainApplication();
				return;
			}
		}

       

		private void DownUpdateFile()
		{
			mainAppExe = updaterXmlFiles.GetNodeValue("//EntryPoint");
			Process [] allProcess = Process.GetProcesses();
			foreach(Process p in allProcess)
			{
				if (p.ProcessName.ToLower() + ".exe" == mainAppExe.ToLower() )
				{
					for(int i=0;i<p.Threads.Count;i++)
						p.Threads[i].Dispose();
					p.Kill();
					isRun = true;
				}
			}
            bool isFinish = false;
			WebClient wcClient = AppUpdater.CreateClient();
            WebResponse webRes=null;
            WebRequest webReq=null;
			for(int i = 0;i < this.lvUpdateList.Items.Count;i++)
			{
                
				string UpdateFile = lvUpdateList.Items[i].Text.Trim();
                //string UpdateFile = WindowFormDelegate.GetListViewText(lvUpdateList, i);
                string updateFileUrl = updateUrl + UpdateFile;
				long fileLength = 0;
                WindowFormDelegate.SetMainThreadHint(lbFileListHint,string.Format("��{0}���ļ�������,׼�����µ�{1}���ļ���", lvUpdateList.Items.Count.ToString(), (i + 1).ToString()));
                try
                {
                    TempLog.Debug(string.Format("���ظ����ļ�{0},����WebRequest", updateFileUrl));
                    webReq = AppUpdater.Create(updateFileUrl);
                    TempLog.Debug("��ɴ���WebRequest");
                    TempLog.Debug("���ظ����ļ���׼����ȡWebResponse");
                    webRes = webReq.GetResponse();
                    TempLog.Debug("���ظ����ļ�����ɻ�ȡWebResponse");
                    fileLength = webRes.ContentLength;
                    WindowFormDelegate.SetMainThreadHint(this.lbState, "�������ظ����ļ�,���Ժ�...");
                    //lbState.Text = "�������ظ����ļ�,���Ժ�...";
                    pbDownFile.Value = 0;
                    pbDownFile.Maximum = (int)fileLength;

                    TempLog.Debug("���ظ����ļ�����ȡGetResponseStream");
                    Stream srm = webRes.GetResponseStream();
                    TempLog.Debug("���ظ����ļ�����ɻ�ȡGetResponseStream");
                    StreamReader srmReader = new StreamReader(srm);
                    byte[] bufferbyte = new byte[fileLength];
                    int allByte = (int)bufferbyte.Length;
                    int startByte = 0;
                    while (fileLength > 0)
                    {
                        Application.DoEvents();
                        int downByte = srm.Read(bufferbyte, startByte, allByte);
                        if (downByte == 0) { break; };
                        startByte += downByte;
                        allByte -= downByte;
                        pbDownFile.Value += downByte;

                        float part = (float)startByte / 1024;
                        float total = (float)bufferbyte.Length / 1024;
                        int percent = Convert.ToInt32((part / total) * 100);

                        this.lvUpdateList.Items[i].SubItems[2].Text = percent.ToString() + "%";

                    }

                    string tempPath = tempUpdatePath + UpdateFile;
                    CreateDirtory(tempPath);
                    FileStream fs = new FileStream(tempPath, FileMode.OpenOrCreate, FileAccess.Write);
                    fs.Write(bufferbyte, 0, bufferbyte.Length);
                    srm.Close();
                    srmReader.Close();
                    fs.Close();
                }
                catch (WebException ex)
                {
                    //MessageBox.Show("�����ļ�����ʧ�ܣ�" + ex.Message.ToString(), "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  //  isFinish = false;
                   // continue;
                    Console.WriteLine("�����쳣��"+ex.ToString());
                }
                finally
                {
                    if (webRes != null)
                    {
                        webRes.Close();
                        webReq.Abort();
                    }
                }
                if (i == this.lvUpdateList.Items.Count - 1)
                {
                    isFinish = true;
                   //this.btnFinish_Click(null, null);
                }
			}
			InvalidateControl();
            if (isFinish)
            {
                this.CopyFileThread();
            }
                //btnFinish_Click(null, null);
            else
            {
                this.StartMainApplication();
            }
		}

        private void StartMainApplication()
        {
            
            if (!File.Exists(mainAppExe))
            {
                MessageBox.Show("�޷����г���" + mainAppExe + "����ʧ�ܣ�","��ʾ");

            }
            else
            {
                try
                {
                    Process.Start(mainAppExe);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("�޷���������\r\n" + ex.ToString());
                }
            }
            this.Close();
        }

		//����Ŀ¼
		private void CreateDirtory(string path)
		{
			if(!File.Exists(path))
			{
                path = path.Replace("/","\\");
				string [] dirArray = path.Split('\\'); 
				string temp = string.Empty;
				for(int i = 0;i<dirArray.Length - 1;i++)
				{
					temp += dirArray[i].Trim() + "\\";
					if(!Directory.Exists(temp))
						Directory.CreateDirectory(temp);
				}
			}
		}

        private static int FileCopyCounter = 0;

		//�����ļ�;
		public void CopyFile(string sourcePath,string objPath)
		{
			if(!Directory.Exists(objPath))
			{
				Directory.CreateDirectory(objPath);
			}
            string[] files = Directory.GetFiles(sourcePath);
            for (int i = 0; i < files.Length; i++)
            {
                string[] childfile = files[i].Split('\\');
                FileCopyCounter++;
                WindowFormDelegate.SetMainThreadHint(this.lbFileListHint, string.Format("���ڸ��Ƶ�{0}���ļ�{1}", FileCopyCounter.ToString(), childfile[childfile.Length - 1]));
                File.Copy(files[i], objPath + @"\" + childfile[childfile.Length - 1], true);
                
            }
            string[] dirs = Directory.GetDirectories(sourcePath);
            for (int i = 0; i < dirs.Length; i++)
            {
                string[] childdir = dirs[i].Split('\\');
                CopyFile(dirs[i], objPath + @"\" + childdir[childdir.Length - 1]);
            }
			
			
		}

        private void CopyFileThread()
        {
            Thread thread = new Thread(new ThreadStart(CopyAllTempFiles));
            thread.IsBackground = true;
            thread.Start();
        }

        private void CopyAllTempFiles()
        {
            try
            {

                FileCopyCounter = 0;
                CopyFile(tempUpdatePath, Directory.GetCurrentDirectory());
                System.IO.Directory.Delete(tempUpdatePath, true);
                //this.Close();
                //this.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("�߳̿��������쳣:"+ex.ToString());
                //MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                this.Close();
                this.Dispose();
                if (true!= this.isRun) Process.Start(mainAppExe);

            }
        }

		//�����ɸ��Ƹ����ļ���Ӧ�ó���Ŀ¼
		private void btnFinish_Click(object sender, System.EventArgs e)
		{


            try
            {
                
                FileCopyCounter = 0;
                CopyFile(tempUpdatePath, Directory.GetCurrentDirectory());
                System.IO.Directory.Delete(tempUpdatePath, true);
                //this.Close();
                //this.Dispose();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                this.Close();
                this.Dispose();
                if (true == this.isRun) Process.Start(mainAppExe);
                
            }
			
		}
		
		//���»��ƴ��岿�ֿؼ�����
		private void InvalidateControl()
		{
			panel2.Location = panel1.Location;
			panel2.Size = panel1.Size;
			panel1.Visible = false;
			panel2.Visible = true;

			btnNext.Visible = false;
			btnCancel.Visible = false;
			btnFinish.Location = btnCancel.Location;
			btnFinish.Visible = true;
		}

		//�ж���Ӧ�ó����Ƿ���������
		private bool IsMainAppRun()
		{
			string mainAppExe = updaterXmlFiles.GetNodeValue("//EntryPoint");
			bool isRun = false;
			Process [] allProcess = Process.GetProcesses();
			foreach(Process p in allProcess)
			{
				if (p.ProcessName.ToLower() + ".exe" == mainAppExe.ToLower() )
				{
					isRun = true;
				}
			}
			return isRun;
		}
	}
}