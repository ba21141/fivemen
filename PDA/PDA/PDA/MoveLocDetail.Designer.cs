﻿namespace PDA
{
    partial class MoveLocDetail
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
            this.btn_Finish = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_OldLoc = new System.Windows.Forms.TextBox();
            this.txt_Product = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Count = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NewLoc = new System.Windows.Forms.TextBox();
            this.dg_ScanList = new System.Windows.Forms.DataGrid();
            this.label5 = new System.Windows.Forms.Label();
            this.ck_Rollback = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_Finish
            // 
            this.btn_Finish.BackColor = System.Drawing.Color.Beige;
            this.btn_Finish.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.btn_Finish.Location = new System.Drawing.Point(157, 241);
            this.btn_Finish.Name = "btn_Finish";
            this.btn_Finish.Size = new System.Drawing.Size(64, 22);
            this.btn_Finish.TabIndex = 7;
            this.btn_Finish.Text = "提交";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.Text = "原库位：";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(3, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.Text = "产品：";
            // 
            // txt_OldLoc
            // 
            this.txt_OldLoc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.txt_OldLoc.Location = new System.Drawing.Point(62, 8);
            this.txt_OldLoc.Name = "txt_OldLoc";
            this.txt_OldLoc.Size = new System.Drawing.Size(168, 20);
            this.txt_OldLoc.TabIndex = 0;
            this.txt_OldLoc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_OldLoc_KeyUp);
            // 
            // txt_Product
            // 
            this.txt_Product.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.txt_Product.Location = new System.Drawing.Point(62, 34);
            this.txt_Product.Name = "txt_Product";
            this.txt_Product.Size = new System.Drawing.Size(96, 20);
            this.txt_Product.TabIndex = 1;
            this.txt_Product.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Product_KeyUp);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(161, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.Text = "数量：";
            // 
            // txt_Count
            // 
            this.txt_Count.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.txt_Count.Location = new System.Drawing.Point(203, 34);
            this.txt_Count.Name = "txt_Count";
            this.txt_Count.Size = new System.Drawing.Size(27, 20);
            this.txt_Count.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Beige;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.button1.Location = new System.Drawing.Point(18, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 22);
            this.button1.TabIndex = 6;
            this.button1.Text = "临时保存";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.label4.Location = new System.Drawing.Point(3, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.Text = "新库位：";
            // 
            // txt_NewLoc
            // 
            this.txt_NewLoc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.txt_NewLoc.Location = new System.Drawing.Point(62, 63);
            this.txt_NewLoc.Name = "txt_NewLoc";
            this.txt_NewLoc.Size = new System.Drawing.Size(168, 20);
            this.txt_NewLoc.TabIndex = 3;
            this.txt_NewLoc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_NewLoc_KeyUp);
            // 
            // dg_ScanList
            // 
            this.dg_ScanList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dg_ScanList.ColumnHeadersVisible = false;
            this.dg_ScanList.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.dg_ScanList.Location = new System.Drawing.Point(8, 111);
            this.dg_ScanList.Name = "dg_ScanList";
            this.dg_ScanList.Size = new System.Drawing.Size(222, 124);
            this.dg_ScanList.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label5.Location = new System.Drawing.Point(3, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.Text = "扫描记录：";
            // 
            // ck_Rollback
            // 
            this.ck_Rollback.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.ck_Rollback.ForeColor = System.Drawing.Color.Red;
            this.ck_Rollback.Location = new System.Drawing.Point(125, 88);
            this.ck_Rollback.Name = "ck_Rollback";
            this.ck_Rollback.Size = new System.Drawing.Size(110, 20);
            this.ck_Rollback.TabIndex = 4;
            this.ck_Rollback.Text = "撤销产品扫描";
            this.ck_Rollback.CheckStateChanged += new System.EventHandler(this.ck_Rollback_CheckStateChanged);
            // 
            // MoveLocDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(238, 270);
            this.Controls.Add(this.ck_Rollback);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_OldLoc);
            this.Controls.Add(this.dg_ScanList);
            this.Controls.Add(this.txt_NewLoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Finish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Product);
            this.Name = "MoveLocDetail";
            this.Text = "无托移库";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Finish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_OldLoc;
        private System.Windows.Forms.TextBox txt_Product;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Count;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_NewLoc;
        private System.Windows.Forms.DataGrid dg_ScanList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ck_Rollback;
    }
}