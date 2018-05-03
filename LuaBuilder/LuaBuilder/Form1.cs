using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuaBuilder
{
    public partial class Form1 : Form
    {
        private Config config;
        private bool running;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.config = Config.Load();
            if (this.config == null)
            {
                this.config = new Config();
            }

            this.seedDirInput.Text = this.config.SeedDir;
            this.libDirInput.Text = this.config.LibDir;
            this.outputDirInput.Text = this.config.OutputDir;
            this.checkBox1.Checked = this.config.IsAllBuild;
            this.isStartup.Checked = this.config.IsStartup;
            this.isClipNotify.Checked = this.config.IsClipNotify;

            this.libWatcher.NotifyFilter = System.IO.NotifyFilters.FileName |
                                            System.IO.NotifyFilters.DirectoryName |
                                            System.IO.NotifyFilters.LastWrite;
            this.libWatcher.IncludeSubdirectories = false;
            this.libWatcher.SynchronizingObject = this;


            this.seedWatcher.NotifyFilter = System.IO.NotifyFilters.FileName |
                                            System.IO.NotifyFilters.DirectoryName |
                                            System.IO.NotifyFilters.LastWrite;
            this.seedWatcher.IncludeSubdirectories = false;
            this.seedWatcher.SynchronizingObject = this;

            if (this.config.IsStartup)
            {
                this.startButton.PerformClick();
            }
            else
            {
                this.stopButton.PerformClick();
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.config.SeedDir = this.seedDirInput.Text;
            this.config.LibDir = this.libDirInput.Text;
            this.config.OutputDir = this.outputDirInput.Text;
            this.config.IsAllBuild = this.checkBox1.Checked;
            this.config.IsStartup = this.isStartup.Checked;
            this.config.IsClipNotify = this.isClipNotify.Checked;
            this.config.Save();

        }

        private void seedDirInput_TextChanged(object sender, EventArgs e)
        {
            this.ShowList();
        }

        private void ShowList()
        {
            var d = new DirectoryInfo(this.seedDirInput.Text);
            if (!d.Exists)
            {
                return;
            }

            var old = (string)this.targetList.SelectedItem;
            this.targetList.Items.Clear();
            foreach (var f in d.GetFiles())
            {
                this.targetList.Items.Add(f.Name);
                if (f.Name == old)
                {
                    this.targetList.SelectedItem = old;
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.BuildAll();
            }
            else
            {
                this.BuildOne();
            }
        }

        private void libWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.BuildAll();
            }
            else
            {
                this.BuildOne();
            }
        }

        private void seedWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            this.ShowList();

            if (this.checkBox1.Checked)
            {
                this.BuildAll();
            }
            else
            {
                this.BuildOne();
            }
        }
        private void BuildOne()
        {
            var fileName = (string)this.targetList.SelectedItem;
            if (fileName == null)
            {
                return;
            }
            var p = System.IO.Path.Combine(this.seedDirInput.Text, fileName);
            Builder.Build(p, this.libDirInput.Text, this.outputDirInput.Text, true);
            this.notifyIcon1.ShowBalloonTip(1000, "LuaBuilder", fileName + " is clipped", ToolTipIcon.Info);
        }

        private void BuildAll()
        {
            for (int i = 0; i < this.targetList.Items.Count; i++)
            {
                string item = (string)this.targetList.Items[i];
                var p = System.IO.Path.Combine(this.seedDirInput.Text, item);
                if (this.targetList.SelectedIndex == i)
                {
                    Builder.Build(p, this.libDirInput.Text, this.outputDirInput.Text, true);
                    this.notifyIcon1.ShowBalloonTip(1000, "LuaBuilder", item + " is clipped", ToolTipIcon.Info);
                }
                else
                {
                    Builder.Build(p, this.libDirInput.Text, this.outputDirInput.Text, false);
                }
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            ChangeEnabled(true);

            this.libWatcher.Path = this.libDirInput.Text;
            this.libWatcher.EnableRaisingEvents = true;

            this.seedWatcher.Path = this.seedDirInput.Text;
            this.seedWatcher.EnableRaisingEvents = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            this.seedWatcher.EnableRaisingEvents = false;
            this.libWatcher.EnableRaisingEvents = false;
            ChangeEnabled(false);
        }

        private void ChangeEnabled(bool isRun)
        {
            this.running = isRun;
            this.startButton.Enabled = !isRun;
            this.stopButton.Enabled = isRun;
            this.checkBox1.Enabled = !isRun;
            this.isStartup.Enabled = !isRun;
            this.seedDirInput.Enabled = !isRun;
            this.libDirInput.Enabled = !isRun;
            this.outputDirInput.Enabled = !isRun;
            this.targetList.Enabled = !isRun;
            this.isClipNotify.Enabled = !isRun;
        }
 
    }
}
