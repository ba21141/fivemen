﻿namespace HiPiaoTerminal.UserRegister
{
    partial class UserRegisterSuccessPanel
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnQuitAccount = new System.Windows.Forms.PictureBox();
            this.btnQueryAccount = new System.Windows.Forms.PictureBox();
            this.btnReturnHome = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuitAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQueryAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuitAccount
            // 
            this.btnQuitAccount.Image = global::HiPiaoTerminal.Properties.Resources.Register_QuitAccount;
            this.btnQuitAccount.Location = new System.Drawing.Point(739, 577);
            this.btnQuitAccount.Name = "btnQuitAccount";
            this.btnQuitAccount.Size = new System.Drawing.Size(260, 83);
            this.btnQuitAccount.TabIndex = 0;
            this.btnQuitAccount.TabStop = false;
            this.btnQuitAccount.Click += new System.EventHandler(this.btnQuitAccount_Click);
            // 
            // btnQueryAccount
            // 
            this.btnQueryAccount.Image = global::HiPiaoTerminal.Properties.Resources.Register_QueryAccount;
            this.btnQueryAccount.Location = new System.Drawing.Point(422, 577);
            this.btnQueryAccount.Name = "btnQueryAccount";
            this.btnQueryAccount.Size = new System.Drawing.Size(260, 83);
            this.btnQueryAccount.TabIndex = 0;
            this.btnQueryAccount.TabStop = false;
            this.btnQueryAccount.Click += new System.EventHandler(this.btnQueryAccount_Click);
            // 
            // btnReturnHome
            // 
            this.btnReturnHome.Image = global::HiPiaoTerminal.Properties.Resources.Register_ReturnHome;
            this.btnReturnHome.Location = new System.Drawing.Point(100, 577);
            this.btnReturnHome.Name = "btnReturnHome";
            this.btnReturnHome.Size = new System.Drawing.Size(260, 83);
            this.btnReturnHome.TabIndex = 0;
            this.btnReturnHome.TabStop = false;
            this.btnReturnHome.Click += new System.EventHandler(this.btnReturnHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HiPiaoTerminal.Properties.Resources.Register_Success;
            this.pictureBox1.Location = new System.Drawing.Point(138, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 530);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UserRegisterSuccessPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.btnQuitAccount);
            this.Controls.Add(this.btnQueryAccount);
            this.Controls.Add(this.btnReturnHome);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserRegisterSuccessPanel";
            this.Size = new System.Drawing.Size(1100, 680);
            ((System.ComponentModel.ISupportInitialize)(this.btnQuitAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQueryAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnReturnHome;
        private System.Windows.Forms.PictureBox btnQueryAccount;
        private System.Windows.Forms.PictureBox btnQuitAccount;
    }
}
