namespace ShelterInstaller
{
    partial class Setup2
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.browserFolderBtn = new System.Windows.Forms.Button();
            this.gameDirTxt = new System.Windows.Forms.TextBox();
            this.installBtn = new System.Windows.Forms.Button();
            this.uninstallBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // browserFolderBtn
            // 
            this.browserFolderBtn.Location = new System.Drawing.Point(380, 94);
            this.browserFolderBtn.Name = "browserFolderBtn";
            this.browserFolderBtn.Size = new System.Drawing.Size(75, 23);
            this.browserFolderBtn.TabIndex = 0;
            this.browserFolderBtn.Text = "更改";
            this.browserFolderBtn.UseVisualStyleBackColor = true;
            this.browserFolderBtn.Click += new System.EventHandler(this.browserFolderBtn_Click);
            // 
            // gameDirTxt
            // 
            this.gameDirTxt.Location = new System.Drawing.Point(38, 94);
            this.gameDirTxt.Name = "gameDirTxt";
            this.gameDirTxt.Size = new System.Drawing.Size(326, 21);
            this.gameDirTxt.TabIndex = 1;
            this.gameDirTxt.Text = "D:\\地下城与勇士";
            // 
            // installBtn
            // 
            this.installBtn.Location = new System.Drawing.Point(284, 289);
            this.installBtn.Name = "installBtn";
            this.installBtn.Size = new System.Drawing.Size(75, 23);
            this.installBtn.TabIndex = 2;
            this.installBtn.Text = "安装";
            this.installBtn.UseVisualStyleBackColor = true;
            this.installBtn.Click += new System.EventHandler(this.Install);
            // 
            // uninstallBtn
            // 
            this.uninstallBtn.Location = new System.Drawing.Point(284, 250);
            this.uninstallBtn.Name = "uninstallBtn";
            this.uninstallBtn.Size = new System.Drawing.Size(75, 23);
            this.uninstallBtn.TabIndex = 3;
            this.uninstallBtn.Text = "卸载";
            this.uninstallBtn.UseVisualStyleBackColor = true;
            this.uninstallBtn.Click += new System.EventHandler(this.Uninstall);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(36, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "请复制粘贴游戏路径。或单击“更改”选择游戏路径。";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(188, 289);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "上一步";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // Setup2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 323);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uninstallBtn);
            this.Controls.Add(this.installBtn);
            this.Controls.Add(this.gameDirTxt);
            this.Controls.Add(this.browserFolderBtn);
            this.Name = "Setup2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Setup0_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browserFolderBtn;
        private System.Windows.Forms.TextBox gameDirTxt;
        private System.Windows.Forms.Button installBtn;
        private System.Windows.Forms.Button uninstallBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}

