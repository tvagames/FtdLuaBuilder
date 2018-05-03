namespace LuaBuilder
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.seedDirInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.libDirInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.outputDirInput = new System.Windows.Forms.TextBox();
            this.targetList = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.libWatcher = new System.IO.FileSystemWatcher();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.seedWatcher = new System.IO.FileSystemWatcher();
            this.isStartup = new System.Windows.Forms.CheckBox();
            this.isClipNotify = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.libWatcher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seedWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = " seed folder";
            // 
            // seedDirInput
            // 
            this.seedDirInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seedDirInput.Location = new System.Drawing.Point(84, 9);
            this.seedDirInput.Name = "seedDirInput";
            this.seedDirInput.Size = new System.Drawing.Size(322, 19);
            this.seedDirInput.TabIndex = 1;
            this.seedDirInput.TextChanged += new System.EventHandler(this.seedDirInput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = " lib folder";
            // 
            // libDirInput
            // 
            this.libDirInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.libDirInput.Location = new System.Drawing.Point(84, 34);
            this.libDirInput.Name = "libDirInput";
            this.libDirInput.Size = new System.Drawing.Size(322, 19);
            this.libDirInput.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "output folder";
            // 
            // outputDirInput
            // 
            this.outputDirInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputDirInput.Location = new System.Drawing.Point(84, 59);
            this.outputDirInput.Name = "outputDirInput";
            this.outputDirInput.Size = new System.Drawing.Size(322, 19);
            this.outputDirInput.TabIndex = 1;
            // 
            // targetList
            // 
            this.targetList.FormattingEnabled = true;
            this.targetList.ItemHeight = 12;
            this.targetList.Location = new System.Drawing.Point(452, 27);
            this.targetList.Name = "targetList";
            this.targetList.Size = new System.Drawing.Size(120, 148);
            this.targetList.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "select current";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(126, 126);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(207, 126);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "build";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 96);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 16);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "build all";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // libWatcher
            // 
            this.libWatcher.EnableRaisingEvents = true;
            this.libWatcher.SynchronizingObject = this;
            this.libWatcher.Changed += new System.IO.FileSystemEventHandler(this.libWatcher_Changed);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "LuaBuilder";
            this.notifyIcon1.Visible = true;
            // 
            // seedWatcher
            // 
            this.seedWatcher.EnableRaisingEvents = true;
            this.seedWatcher.SynchronizingObject = this;
            this.seedWatcher.Changed += new System.IO.FileSystemEventHandler(this.seedWatcher_Changed);
            // 
            // isStartup
            // 
            this.isStartup.AutoSize = true;
            this.isStartup.Location = new System.Drawing.Point(12, 130);
            this.isStartup.Name = "isStartup";
            this.isStartup.Size = new System.Drawing.Size(102, 16);
            this.isStartup.TabIndex = 4;
            this.isStartup.Text = "start at startup";
            this.isStartup.UseVisualStyleBackColor = true;
            // 
            // isClipNotify
            // 
            this.isClipNotify.AutoSize = true;
            this.isClipNotify.Location = new System.Drawing.Point(12, 159);
            this.isClipNotify.Name = "isClipNotify";
            this.isClipNotify.Size = new System.Drawing.Size(103, 16);
            this.isClipNotify.TabIndex = 4;
            this.isClipNotify.Text = "clipboard notify";
            this.isClipNotify.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 187);
            this.Controls.Add(this.isClipNotify);
            this.Controls.Add(this.isStartup);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.targetList);
            this.Controls.Add(this.outputDirInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.libDirInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.seedDirInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "LUA Builder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libWatcher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seedWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox seedDirInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox libDirInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox outputDirInput;
        private System.Windows.Forms.ListBox targetList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.IO.FileSystemWatcher libWatcher;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.IO.FileSystemWatcher seedWatcher;
        private System.Windows.Forms.CheckBox isStartup;
        private System.Windows.Forms.CheckBox isClipNotify;
    }
}

