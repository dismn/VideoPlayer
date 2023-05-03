
namespace VideoPlayer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.next_btn = new System.Windows.Forms.Button();
            this.percent_lbl = new System.Windows.Forms.Label();
            this.volume_text = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.track_list = new System.Windows.Forms.ListBox();
            this.open_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.pause_btn = new System.Windows.Forms.Button();
            this.play_btn = new System.Windows.Forms.Button();
            this.prev_btn = new System.Windows.Forms.Button();
            this.msg_lbl = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.track_start_lbl = new System.Windows.Forms.Label();
            this.track_end_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(12, 12);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(850, 399);
            this.player.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.next_btn);
            this.groupBox1.Controls.Add(this.percent_lbl);
            this.groupBox1.Controls.Add(this.volume_text);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.track_list);
            this.groupBox1.Controls.Add(this.open_btn);
            this.groupBox1.Controls.Add(this.stop_btn);
            this.groupBox1.Controls.Add(this.pause_btn);
            this.groupBox1.Controls.Add(this.play_btn);
            this.groupBox1.Controls.Add(this.prev_btn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(12, 447);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 170);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // next_btn
            // 
            this.next_btn.BackColor = System.Drawing.Color.LightCyan;
            this.next_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.next_btn.Location = new System.Drawing.Point(257, 26);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(103, 31);
            this.next_btn.TabIndex = 8;
            this.next_btn.Text = "Next";
            this.next_btn.UseVisualStyleBackColor = false;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // percent_lbl
            // 
            this.percent_lbl.AutoSize = true;
            this.percent_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percent_lbl.Location = new System.Drawing.Point(795, 57);
            this.percent_lbl.Name = "percent_lbl";
            this.percent_lbl.Size = new System.Drawing.Size(35, 20);
            this.percent_lbl.TabIndex = 7;
            this.percent_lbl.Text = "0%";
            // 
            // volume_text
            // 
            this.volume_text.AutoSize = true;
            this.volume_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volume_text.Location = new System.Drawing.Point(759, 142);
            this.volume_text.Name = "volume_text";
            this.volume_text.Size = new System.Drawing.Size(71, 20);
            this.volume_text.TabIndex = 3;
            this.volume_text.Text = "Volume";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(745, 26);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(56, 124);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // track_list
            // 
            this.track_list.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.track_list.FormattingEnabled = true;
            this.track_list.ItemHeight = 20;
            this.track_list.Location = new System.Drawing.Point(11, 70);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(728, 84);
            this.track_list.TabIndex = 5;
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
            // 
            // open_btn
            // 
            this.open_btn.BackColor = System.Drawing.Color.LightCyan;
            this.open_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.open_btn.Location = new System.Drawing.Point(636, 26);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(103, 31);
            this.open_btn.TabIndex = 4;
            this.open_btn.Text = "Open";
            this.open_btn.UseVisualStyleBackColor = false;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.BackColor = System.Drawing.Color.LightCyan;
            this.stop_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.stop_btn.Location = new System.Drawing.Point(501, 26);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(103, 31);
            this.stop_btn.TabIndex = 3;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = false;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // pause_btn
            // 
            this.pause_btn.BackColor = System.Drawing.Color.LightCyan;
            this.pause_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pause_btn.Location = new System.Drawing.Point(377, 26);
            this.pause_btn.Name = "pause_btn";
            this.pause_btn.Size = new System.Drawing.Size(103, 31);
            this.pause_btn.TabIndex = 2;
            this.pause_btn.Text = "Pause";
            this.pause_btn.UseVisualStyleBackColor = false;
            this.pause_btn.Click += new System.EventHandler(this.pause_btn_Click);
            // 
            // play_btn
            // 
            this.play_btn.BackColor = System.Drawing.Color.LightCyan;
            this.play_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.play_btn.Location = new System.Drawing.Point(135, 26);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(103, 31);
            this.play_btn.TabIndex = 1;
            this.play_btn.Text = "Play";
            this.play_btn.UseVisualStyleBackColor = false;
            this.play_btn.Click += new System.EventHandler(this.play_btn_Click);
            // 
            // prev_btn
            // 
            this.prev_btn.BackColor = System.Drawing.Color.LightCyan;
            this.prev_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.prev_btn.Location = new System.Drawing.Point(6, 26);
            this.prev_btn.Name = "prev_btn";
            this.prev_btn.Size = new System.Drawing.Size(103, 31);
            this.prev_btn.TabIndex = 0;
            this.prev_btn.Text = "Previous";
            this.prev_btn.UseVisualStyleBackColor = false;
            this.prev_btn.Click += new System.EventHandler(this.prev_btn_Click);
            // 
            // msg_lbl
            // 
            this.msg_lbl.AutoSize = true;
            this.msg_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.msg_lbl.Location = new System.Drawing.Point(12, 0);
            this.msg_lbl.Name = "msg_lbl";
            this.msg_lbl.Size = new System.Drawing.Size(115, 20);
            this.msg_lbl.TabIndex = 2;
            this.msg_lbl.Text = "Video Player";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(107, 421);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(694, 16);
            this.progressBar1.TabIndex = 3;
            // 
            // track_start_lbl
            // 
            this.track_start_lbl.AutoSize = true;
            this.track_start_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.track_start_lbl.Location = new System.Drawing.Point(40, 419);
            this.track_start_lbl.Name = "track_start_lbl";
            this.track_start_lbl.Size = new System.Drawing.Size(55, 20);
            this.track_start_lbl.TabIndex = 8;
            this.track_start_lbl.Text = "00:00";
            // 
            // track_end_lbl
            // 
            this.track_end_lbl.AutoSize = true;
            this.track_end_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.track_end_lbl.Location = new System.Drawing.Point(807, 421);
            this.track_end_lbl.Name = "track_end_lbl";
            this.track_end_lbl.Size = new System.Drawing.Size(55, 20);
            this.track_end_lbl.TabIndex = 9;
            this.track_end_lbl.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(874, 618);
            this.Controls.Add(this.track_end_lbl);
            this.Controls.Add(this.track_start_lbl);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.msg_lbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label percent_lbl;
        private System.Windows.Forms.Label volume_text;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button pause_btn;
        private System.Windows.Forms.Button play_btn;
        private System.Windows.Forms.Button prev_btn;
        private System.Windows.Forms.Label msg_lbl;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label track_start_lbl;
        private System.Windows.Forms.Label track_end_lbl;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Timer timer1;
    }
}

