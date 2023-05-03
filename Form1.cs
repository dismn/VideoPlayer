using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        string[] paths, files;

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[track_list.SelectedIndex];
            player.Ctlcontrols.play();
            msg_lbl.Text = "Playing...";
            timer1.Start();
            trackBar1.Value = 15;
            percent_lbl.Text = trackBar1.Value.ToString() + "%";
        }

        private void play_btn_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
            msg_lbl.Text = "Playing...";

        }

        private void pause_btn_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
            msg_lbl.Text = "Pause";
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            msg_lbl.Text = "Stop";
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if(track_list.SelectedIndex < track_list.Items.Count - 1)
            {
                track_list.SelectedIndex = track_list.SelectedIndex + 1;
            }
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex>0)
            {
                track_list.SelectedIndex = track_list.SelectedIndex - 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                progressBar1.Value = (int)player.Ctlcontrols.currentPosition;

            }

            track_start_lbl.Text = player.Ctlcontrols.currentPositionString;
            track_end_lbl.Text = player.Ctlcontrols.currentItem.durationString.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackBar1.Value;
            percent_lbl.Text = trackBar1.Value.ToString();
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                for(int x=0; x<files.Length; x++)
                {
                    track_list.Items.Add(files[x]);
                }
            }
        }
    }
}
