﻿namespace HiPiaoTerminal.UserControlEx
{
    partial class AdShowPanel
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
            if (this.adShowTimer != null)
            {
                this.adShowTimer.Stop();
                this.adShowTimer.Enabled = false;
            }
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.adShowTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // adShowTimer
            // 
            this.adShowTimer.Interval = 500;
            // 
            // AdShowPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Name = "AdShowPanel";
            this.Size = new System.Drawing.Size(376, 228);
            this.Load += new System.EventHandler(this.AdShowPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer adShowTimer;
    }
}