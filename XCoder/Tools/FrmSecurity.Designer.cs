﻿namespace XCoder.Tools
{
    partial class FrmSecurity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbFunc = new System.Windows.Forms.GroupBox();
            this.gbSource = new System.Windows.Forms.GroupBox();
            this.rtSource = new System.Windows.Forms.RichTextBox();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.rtResult = new System.Windows.Forms.RichTextBox();
            this.btnHex = new System.Windows.Forms.Button();
            this.btnHex2 = new System.Windows.Forms.Button();
            this.btnB642 = new System.Windows.Forms.Button();
            this.btnB64 = new System.Windows.Forms.Button();
            this.btnMD52 = new System.Windows.Forms.Button();
            this.btnMD5 = new System.Windows.Forms.Button();
            this.btnCRC2 = new System.Windows.Forms.Button();
            this.btnCRC = new System.Windows.Forms.Button();
            this.btnDES2 = new System.Windows.Forms.Button();
            this.btnDES = new System.Windows.Forms.Button();
            this.btnAES2 = new System.Windows.Forms.Button();
            this.btnAES = new System.Windows.Forms.Button();
            this.btnRC42 = new System.Windows.Forms.Button();
            this.btnRC4 = new System.Windows.Forms.Button();
            this.btnRSA2 = new System.Windows.Forms.Button();
            this.btnRSA = new System.Windows.Forms.Button();
            this.btnDSA2 = new System.Windows.Forms.Button();
            this.btnDSA = new System.Windows.Forms.Button();
            this.btnUrl2 = new System.Windows.Forms.Button();
            this.btnUrl = new System.Windows.Forms.Button();
            this.btnHtml2 = new System.Windows.Forms.Button();
            this.btnHtml = new System.Windows.Forms.Button();
            this.gbPass = new System.Windows.Forms.GroupBox();
            this.rtPass = new System.Windows.Forms.RichTextBox();
            this.btnExchange = new System.Windows.Forms.Button();
            this.gbFunc.SuspendLayout();
            this.gbSource.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.gbPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFunc
            // 
            this.gbFunc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbFunc.Controls.Add(this.btnHtml2);
            this.gbFunc.Controls.Add(this.btnHtml);
            this.gbFunc.Controls.Add(this.btnUrl2);
            this.gbFunc.Controls.Add(this.btnUrl);
            this.gbFunc.Controls.Add(this.btnDSA2);
            this.gbFunc.Controls.Add(this.btnDSA);
            this.gbFunc.Controls.Add(this.btnRSA2);
            this.gbFunc.Controls.Add(this.btnRSA);
            this.gbFunc.Controls.Add(this.btnRC42);
            this.gbFunc.Controls.Add(this.btnRC4);
            this.gbFunc.Controls.Add(this.btnAES2);
            this.gbFunc.Controls.Add(this.btnAES);
            this.gbFunc.Controls.Add(this.btnDES2);
            this.gbFunc.Controls.Add(this.btnDES);
            this.gbFunc.Controls.Add(this.btnCRC2);
            this.gbFunc.Controls.Add(this.btnCRC);
            this.gbFunc.Controls.Add(this.btnMD52);
            this.gbFunc.Controls.Add(this.btnMD5);
            this.gbFunc.Controls.Add(this.btnB642);
            this.gbFunc.Controls.Add(this.btnB64);
            this.gbFunc.Controls.Add(this.btnHex2);
            this.gbFunc.Controls.Add(this.btnHex);
            this.gbFunc.Location = new System.Drawing.Point(12, 12);
            this.gbFunc.Name = "gbFunc";
            this.gbFunc.Size = new System.Drawing.Size(243, 605);
            this.gbFunc.TabIndex = 0;
            this.gbFunc.TabStop = false;
            this.gbFunc.Text = "加密解密";
            // 
            // gbSource
            // 
            this.gbSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSource.Controls.Add(this.rtSource);
            this.gbSource.Location = new System.Drawing.Point(261, 12);
            this.gbSource.Name = "gbSource";
            this.gbSource.Size = new System.Drawing.Size(600, 250);
            this.gbSource.TabIndex = 3;
            this.gbSource.TabStop = false;
            this.gbSource.Text = "原文";
            // 
            // rtSource
            // 
            this.rtSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtSource.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtSource.Location = new System.Drawing.Point(3, 17);
            this.rtSource.Name = "rtSource";
            this.rtSource.Size = new System.Drawing.Size(594, 230);
            this.rtSource.TabIndex = 2;
            this.rtSource.Text = "学无先后达者为师";
            // 
            // gbResult
            // 
            this.gbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbResult.Controls.Add(this.rtResult);
            this.gbResult.Location = new System.Drawing.Point(261, 368);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(600, 250);
            this.gbResult.TabIndex = 4;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "结果";
            // 
            // rtResult
            // 
            this.rtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtResult.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtResult.Location = new System.Drawing.Point(3, 17);
            this.rtResult.Name = "rtResult";
            this.rtResult.Size = new System.Drawing.Size(594, 230);
            this.rtResult.TabIndex = 2;
            this.rtResult.Text = "";
            // 
            // btnHex
            // 
            this.btnHex.Location = new System.Drawing.Point(6, 20);
            this.btnHex.Name = "btnHex";
            this.btnHex.Size = new System.Drawing.Size(112, 34);
            this.btnHex.TabIndex = 0;
            this.btnHex.Text = "HEX编码";
            this.btnHex.UseVisualStyleBackColor = true;
            this.btnHex.Click += new System.EventHandler(this.btnHex_Click);
            // 
            // btnHex2
            // 
            this.btnHex2.Location = new System.Drawing.Point(125, 20);
            this.btnHex2.Name = "btnHex2";
            this.btnHex2.Size = new System.Drawing.Size(112, 34);
            this.btnHex2.TabIndex = 1;
            this.btnHex2.Text = "HEX解码";
            this.btnHex2.UseVisualStyleBackColor = true;
            this.btnHex2.Click += new System.EventHandler(this.btnHex2_Click);
            // 
            // btnB642
            // 
            this.btnB642.Location = new System.Drawing.Point(125, 60);
            this.btnB642.Name = "btnB642";
            this.btnB642.Size = new System.Drawing.Size(112, 34);
            this.btnB642.TabIndex = 3;
            this.btnB642.Text = "Base64解码";
            this.btnB642.UseVisualStyleBackColor = true;
            this.btnB642.Click += new System.EventHandler(this.btnB642_Click);
            // 
            // btnB64
            // 
            this.btnB64.Location = new System.Drawing.Point(6, 60);
            this.btnB64.Name = "btnB64";
            this.btnB64.Size = new System.Drawing.Size(112, 34);
            this.btnB64.TabIndex = 2;
            this.btnB64.Text = "Base64编码";
            this.btnB64.UseVisualStyleBackColor = true;
            this.btnB64.Click += new System.EventHandler(this.btnB64_Click);
            // 
            // btnMD52
            // 
            this.btnMD52.Location = new System.Drawing.Point(125, 100);
            this.btnMD52.Name = "btnMD52";
            this.btnMD52.Size = new System.Drawing.Size(112, 34);
            this.btnMD52.TabIndex = 5;
            this.btnMD52.Text = "MD5_16";
            this.btnMD52.UseVisualStyleBackColor = true;
            this.btnMD52.Click += new System.EventHandler(this.btnMD52_Click);
            // 
            // btnMD5
            // 
            this.btnMD5.Location = new System.Drawing.Point(6, 100);
            this.btnMD5.Name = "btnMD5";
            this.btnMD5.Size = new System.Drawing.Size(112, 34);
            this.btnMD5.TabIndex = 4;
            this.btnMD5.Text = "MD5_32";
            this.btnMD5.UseVisualStyleBackColor = true;
            this.btnMD5.Click += new System.EventHandler(this.btnMD5_Click);
            // 
            // btnCRC2
            // 
            this.btnCRC2.Location = new System.Drawing.Point(125, 140);
            this.btnCRC2.Name = "btnCRC2";
            this.btnCRC2.Size = new System.Drawing.Size(112, 34);
            this.btnCRC2.TabIndex = 7;
            this.btnCRC2.Text = "CRC_16";
            this.btnCRC2.UseVisualStyleBackColor = true;
            this.btnCRC2.Click += new System.EventHandler(this.btnCRC2_Click);
            // 
            // btnCRC
            // 
            this.btnCRC.Location = new System.Drawing.Point(6, 140);
            this.btnCRC.Name = "btnCRC";
            this.btnCRC.Size = new System.Drawing.Size(112, 34);
            this.btnCRC.TabIndex = 6;
            this.btnCRC.Text = "CRC_32";
            this.btnCRC.UseVisualStyleBackColor = true;
            this.btnCRC.Click += new System.EventHandler(this.btnCRC_Click);
            // 
            // btnDES2
            // 
            this.btnDES2.Location = new System.Drawing.Point(125, 180);
            this.btnDES2.Name = "btnDES2";
            this.btnDES2.Size = new System.Drawing.Size(112, 34);
            this.btnDES2.TabIndex = 9;
            this.btnDES2.Text = "DES解密";
            this.btnDES2.UseVisualStyleBackColor = true;
            this.btnDES2.Click += new System.EventHandler(this.btnDES2_Click);
            // 
            // btnDES
            // 
            this.btnDES.Location = new System.Drawing.Point(6, 180);
            this.btnDES.Name = "btnDES";
            this.btnDES.Size = new System.Drawing.Size(112, 34);
            this.btnDES.TabIndex = 8;
            this.btnDES.Text = "DES加密";
            this.btnDES.UseVisualStyleBackColor = true;
            this.btnDES.Click += new System.EventHandler(this.btnDES_Click);
            // 
            // btnAES2
            // 
            this.btnAES2.Location = new System.Drawing.Point(125, 220);
            this.btnAES2.Name = "btnAES2";
            this.btnAES2.Size = new System.Drawing.Size(112, 34);
            this.btnAES2.TabIndex = 11;
            this.btnAES2.Text = "AES解密";
            this.btnAES2.UseVisualStyleBackColor = true;
            this.btnAES2.Click += new System.EventHandler(this.btnAES2_Click);
            // 
            // btnAES
            // 
            this.btnAES.Location = new System.Drawing.Point(6, 220);
            this.btnAES.Name = "btnAES";
            this.btnAES.Size = new System.Drawing.Size(112, 34);
            this.btnAES.TabIndex = 10;
            this.btnAES.Text = "AES加密";
            this.btnAES.UseVisualStyleBackColor = true;
            this.btnAES.Click += new System.EventHandler(this.btnAES_Click);
            // 
            // btnRC42
            // 
            this.btnRC42.Location = new System.Drawing.Point(125, 260);
            this.btnRC42.Name = "btnRC42";
            this.btnRC42.Size = new System.Drawing.Size(112, 34);
            this.btnRC42.TabIndex = 13;
            this.btnRC42.Text = "RC4解密";
            this.btnRC42.UseVisualStyleBackColor = true;
            this.btnRC42.Click += new System.EventHandler(this.btnRC42_Click);
            // 
            // btnRC4
            // 
            this.btnRC4.Location = new System.Drawing.Point(6, 260);
            this.btnRC4.Name = "btnRC4";
            this.btnRC4.Size = new System.Drawing.Size(112, 34);
            this.btnRC4.TabIndex = 12;
            this.btnRC4.Text = "RC4加密";
            this.btnRC4.UseVisualStyleBackColor = true;
            this.btnRC4.Click += new System.EventHandler(this.btnRC4_Click);
            // 
            // btnRSA2
            // 
            this.btnRSA2.Location = new System.Drawing.Point(125, 303);
            this.btnRSA2.Name = "btnRSA2";
            this.btnRSA2.Size = new System.Drawing.Size(112, 34);
            this.btnRSA2.TabIndex = 15;
            this.btnRSA2.Text = "RSA解密";
            this.btnRSA2.UseVisualStyleBackColor = true;
            this.btnRSA2.Click += new System.EventHandler(this.btnRSA2_Click);
            // 
            // btnRSA
            // 
            this.btnRSA.Location = new System.Drawing.Point(6, 303);
            this.btnRSA.Name = "btnRSA";
            this.btnRSA.Size = new System.Drawing.Size(112, 34);
            this.btnRSA.TabIndex = 14;
            this.btnRSA.Text = "RSA加密";
            this.btnRSA.UseVisualStyleBackColor = true;
            this.btnRSA.Click += new System.EventHandler(this.btnRSA_Click);
            // 
            // btnDSA2
            // 
            this.btnDSA2.Location = new System.Drawing.Point(125, 343);
            this.btnDSA2.Name = "btnDSA2";
            this.btnDSA2.Size = new System.Drawing.Size(112, 34);
            this.btnDSA2.TabIndex = 17;
            this.btnDSA2.Text = "DSA验证";
            this.btnDSA2.UseVisualStyleBackColor = true;
            this.btnDSA2.Click += new System.EventHandler(this.btnDSA2_Click);
            // 
            // btnDSA
            // 
            this.btnDSA.Location = new System.Drawing.Point(6, 343);
            this.btnDSA.Name = "btnDSA";
            this.btnDSA.Size = new System.Drawing.Size(112, 34);
            this.btnDSA.TabIndex = 16;
            this.btnDSA.Text = "DSA签名";
            this.btnDSA.UseVisualStyleBackColor = true;
            this.btnDSA.Click += new System.EventHandler(this.btnDSA_Click);
            // 
            // btnUrl2
            // 
            this.btnUrl2.Location = new System.Drawing.Point(125, 383);
            this.btnUrl2.Name = "btnUrl2";
            this.btnUrl2.Size = new System.Drawing.Size(112, 34);
            this.btnUrl2.TabIndex = 19;
            this.btnUrl2.Text = "Url解码";
            this.btnUrl2.UseVisualStyleBackColor = true;
            this.btnUrl2.Click += new System.EventHandler(this.btnUrl2_Click);
            // 
            // btnUrl
            // 
            this.btnUrl.Location = new System.Drawing.Point(6, 383);
            this.btnUrl.Name = "btnUrl";
            this.btnUrl.Size = new System.Drawing.Size(112, 34);
            this.btnUrl.TabIndex = 18;
            this.btnUrl.Text = "Url编码";
            this.btnUrl.UseVisualStyleBackColor = true;
            this.btnUrl.Click += new System.EventHandler(this.btnUrl_Click);
            // 
            // btnHtml2
            // 
            this.btnHtml2.Location = new System.Drawing.Point(125, 423);
            this.btnHtml2.Name = "btnHtml2";
            this.btnHtml2.Size = new System.Drawing.Size(112, 34);
            this.btnHtml2.TabIndex = 21;
            this.btnHtml2.Text = "Html解码";
            this.btnHtml2.UseVisualStyleBackColor = true;
            this.btnHtml2.Click += new System.EventHandler(this.btnHtml2_Click);
            // 
            // btnHtml
            // 
            this.btnHtml.Location = new System.Drawing.Point(6, 423);
            this.btnHtml.Name = "btnHtml";
            this.btnHtml.Size = new System.Drawing.Size(112, 34);
            this.btnHtml.TabIndex = 20;
            this.btnHtml.Text = "Html编码";
            this.btnHtml.UseVisualStyleBackColor = true;
            this.btnHtml.Click += new System.EventHandler(this.btnHtml_Click);
            // 
            // gbPass
            // 
            this.gbPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPass.Controls.Add(this.rtPass);
            this.gbPass.Location = new System.Drawing.Point(261, 265);
            this.gbPass.Name = "gbPass";
            this.gbPass.Size = new System.Drawing.Size(525, 100);
            this.gbPass.TabIndex = 5;
            this.gbPass.TabStop = false;
            this.gbPass.Text = "密码";
            // 
            // rtPass
            // 
            this.rtPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtPass.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtPass.Location = new System.Drawing.Point(3, 17);
            this.rtPass.Name = "rtPass";
            this.rtPass.Size = new System.Drawing.Size(519, 80);
            this.rtPass.TabIndex = 2;
            this.rtPass.Text = "NewLife";
            // 
            // btnExchange
            // 
            this.btnExchange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExchange.Location = new System.Drawing.Point(789, 306);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(69, 34);
            this.btnExchange.TabIndex = 6;
            this.btnExchange.Text = "上下互换";
            this.btnExchange.UseVisualStyleBackColor = true;
            this.btnExchange.Click += new System.EventHandler(this.btnExchange_Click);
            // 
            // FrmSecurity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 629);
            this.Controls.Add(this.btnExchange);
            this.Controls.Add(this.gbPass);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.gbSource);
            this.Controls.Add(this.gbFunc);
            this.Name = "FrmSecurity";
            this.Text = "加密解密";
            this.gbFunc.ResumeLayout(false);
            this.gbSource.ResumeLayout(false);
            this.gbResult.ResumeLayout(false);
            this.gbPass.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFunc;
        private System.Windows.Forms.GroupBox gbSource;
        private System.Windows.Forms.RichTextBox rtSource;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.RichTextBox rtResult;
        private System.Windows.Forms.Button btnHex2;
        private System.Windows.Forms.Button btnHex;
        private System.Windows.Forms.Button btnB642;
        private System.Windows.Forms.Button btnB64;
        private System.Windows.Forms.Button btnMD52;
        private System.Windows.Forms.Button btnMD5;
        private System.Windows.Forms.Button btnCRC2;
        private System.Windows.Forms.Button btnCRC;
        private System.Windows.Forms.Button btnHtml2;
        private System.Windows.Forms.Button btnHtml;
        private System.Windows.Forms.Button btnUrl2;
        private System.Windows.Forms.Button btnUrl;
        private System.Windows.Forms.Button btnDSA2;
        private System.Windows.Forms.Button btnDSA;
        private System.Windows.Forms.Button btnRSA2;
        private System.Windows.Forms.Button btnRSA;
        private System.Windows.Forms.Button btnRC42;
        private System.Windows.Forms.Button btnRC4;
        private System.Windows.Forms.Button btnAES2;
        private System.Windows.Forms.Button btnAES;
        private System.Windows.Forms.Button btnDES2;
        private System.Windows.Forms.Button btnDES;
        private System.Windows.Forms.GroupBox gbPass;
        private System.Windows.Forms.RichTextBox rtPass;
        private System.Windows.Forms.Button btnExchange;
    }
}