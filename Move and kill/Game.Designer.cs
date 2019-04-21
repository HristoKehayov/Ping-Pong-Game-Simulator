namespace Ping_pong_game
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.twoplayer_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gameover = new System.Windows.Forms.Label();
            this.play_again_txt = new System.Windows.Forms.Label();
            this.playground = new System.Windows.Forms.PictureBox();
            this.game_score2 = new System.Windows.Forms.Label();
            this.game_score1 = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.name1 = new System.Windows.Forms.Label();
            this.name2 = new System.Windows.Forms.Label();
            this.oneplayer_btn = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.platform = new System.Windows.Forms.PictureBox();
            this.platform2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.paused_btn = new System.Windows.Forms.Label();
            this.help1 = new System.Windows.Forms.Label();
            this.help2 = new System.Windows.Forms.Label();
            this.esc_action_label = new System.Windows.Forms.Label();
            this.info_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pl2_profil = new System.Windows.Forms.Label();
            this.pl1_profil = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2)).BeginInit();
            this.SuspendLayout();
            // 
            // twoplayer_btn
            // 
            this.twoplayer_btn.BackColor = System.Drawing.Color.Transparent;
            this.twoplayer_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("twoplayer_btn.BackgroundImage")));
            this.twoplayer_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.twoplayer_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.twoplayer_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.twoplayer_btn.FlatAppearance.BorderSize = 0;
            this.twoplayer_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.twoplayer_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.twoplayer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twoplayer_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twoplayer_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.twoplayer_btn.Location = new System.Drawing.Point(452, 326);
            this.twoplayer_btn.Margin = new System.Windows.Forms.Padding(4);
            this.twoplayer_btn.Name = "twoplayer_btn";
            this.twoplayer_btn.Size = new System.Drawing.Size(147, 71);
            this.twoplayer_btn.TabIndex = 0;
            this.twoplayer_btn.TabStop = false;
            this.twoplayer_btn.Text = "2 Players";
            this.twoplayer_btn.UseVisualStyleBackColor = false;
            this.twoplayer_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.twoplayer_btn_MouseClick);
            this.twoplayer_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.twoplayer_btn_MouseDown);
            this.twoplayer_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.twoplayer_btn_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gameover
            // 
            this.gameover.AutoSize = true;
            this.gameover.BackColor = System.Drawing.Color.Transparent;
            this.gameover.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameover.Location = new System.Drawing.Point(392, 62);
            this.gameover.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(197, 36);
            this.gameover.TabIndex = 16;
            this.gameover.Text = "GAME OVER\r\n";
            this.gameover.Visible = false;
            // 
            // play_again_txt
            // 
            this.play_again_txt.AutoSize = true;
            this.play_again_txt.BackColor = System.Drawing.Color.Transparent;
            this.play_again_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.play_again_txt.Location = new System.Drawing.Point(249, 149);
            this.play_again_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.play_again_txt.Name = "play_again_txt";
            this.play_again_txt.Size = new System.Drawing.Size(546, 39);
            this.play_again_txt.TabIndex = 17;
            this.play_again_txt.Text = "Press  1 Player or 2 Players to play";
            // 
            // playground
            // 
            this.playground.BackColor = System.Drawing.Color.Transparent;
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Margin = new System.Windows.Forms.Padding(4);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(1045, 580);
            this.playground.TabIndex = 21;
            this.playground.TabStop = false;
            // 
            // game_score2
            // 
            this.game_score2.AutoSize = true;
            this.game_score2.BackColor = System.Drawing.Color.Transparent;
            this.game_score2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.game_score2.Location = new System.Drawing.Point(901, 97);
            this.game_score2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.game_score2.Name = "game_score2";
            this.game_score2.Size = new System.Drawing.Size(63, 69);
            this.game_score2.TabIndex = 15;
            this.game_score2.Text = "0";
            // 
            // game_score1
            // 
            this.game_score1.AutoSize = true;
            this.game_score1.BackColor = System.Drawing.Color.Transparent;
            this.game_score1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.game_score1.Location = new System.Drawing.Point(273, 89);
            this.game_score1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.game_score1.Name = "game_score1";
            this.game_score1.Size = new System.Drawing.Size(63, 69);
            this.game_score1.TabIndex = 13;
            this.game_score1.Text = "0";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
            this.ball.Location = new System.Drawing.Point(511, 284);
            this.ball.Margin = new System.Windows.Forms.Padding(4);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(37, 34);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ball.TabIndex = 23;
            this.ball.TabStop = false;
            // 
            // name1
            // 
            this.name1.AutoSize = true;
            this.name1.BackColor = System.Drawing.Color.Transparent;
            this.name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name1.Location = new System.Drawing.Point(251, 58);
            this.name1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(113, 31);
            this.name1.TabIndex = 24;
            this.name1.Text = "Player 1";
            // 
            // name2
            // 
            this.name2.AutoSize = true;
            this.name2.BackColor = System.Drawing.Color.Transparent;
            this.name2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name2.Location = new System.Drawing.Point(876, 66);
            this.name2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(113, 31);
            this.name2.TabIndex = 24;
            this.name2.Text = "Player 2";
            // 
            // oneplayer_btn
            // 
            this.oneplayer_btn.BackColor = System.Drawing.Color.Transparent;
            this.oneplayer_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("oneplayer_btn.BackgroundImage")));
            this.oneplayer_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.oneplayer_btn.FlatAppearance.BorderSize = 0;
            this.oneplayer_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.oneplayer_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.oneplayer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oneplayer_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oneplayer_btn.Location = new System.Drawing.Point(452, 204);
            this.oneplayer_btn.Margin = new System.Windows.Forms.Padding(4);
            this.oneplayer_btn.Name = "oneplayer_btn";
            this.oneplayer_btn.Size = new System.Drawing.Size(147, 73);
            this.oneplayer_btn.TabIndex = 25;
            this.oneplayer_btn.TabStop = false;
            this.oneplayer_btn.Text = "1 Player";
            this.oneplayer_btn.UseVisualStyleBackColor = false;
            this.oneplayer_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.oneplayer_btn_MouseClick);
            this.oneplayer_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.oneplayer_btn_MouseDown);
            this.oneplayer_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.oneplayer_btn_MouseUp);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // platform
            // 
            this.platform.BackColor = System.Drawing.Color.Transparent;
            this.platform.Image = ((System.Drawing.Image)(resources.GetObject("platform.Image")));
            this.platform.Location = new System.Drawing.Point(992, 239);
            this.platform.Margin = new System.Windows.Forms.Padding(4);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(37, 103);
            this.platform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.platform.TabIndex = 26;
            this.platform.TabStop = false;
            // 
            // platform2
            // 
            this.platform2.BackColor = System.Drawing.Color.Transparent;
            this.platform2.Image = ((System.Drawing.Image)(resources.GetObject("platform2.Image")));
            this.platform2.Location = new System.Drawing.Point(16, 239);
            this.platform2.Margin = new System.Windows.Forms.Padding(4);
            this.platform2.Name = "platform2";
            this.platform2.Size = new System.Drawing.Size(37, 103);
            this.platform2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.platform2.TabIndex = 26;
            this.platform2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox1.Location = new System.Drawing.Point(149, 59);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 22);
            this.textBox1.TabIndex = 27;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Player 1";
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Enter Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(636, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Enter Name:";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.HideSelection = false;
            this.textBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox2.Location = new System.Drawing.Point(775, 73);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(93, 22);
            this.textBox2.TabIndex = 27;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Player 2";
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // paused_btn
            // 
            this.paused_btn.AutoSize = true;
            this.paused_btn.BackColor = System.Drawing.Color.Transparent;
            this.paused_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paused_btn.Location = new System.Drawing.Point(443, 273);
            this.paused_btn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paused_btn.Name = "paused_btn";
            this.paused_btn.Size = new System.Drawing.Size(155, 46);
            this.paused_btn.TabIndex = 29;
            this.paused_btn.Text = "Paused";
            this.paused_btn.Visible = false;
            // 
            // help1
            // 
            this.help1.AutoSize = true;
            this.help1.BackColor = System.Drawing.Color.Transparent;
            this.help1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.help1.Location = new System.Drawing.Point(61, 260);
            this.help1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.help1.Name = "help1";
            this.help1.Size = new System.Drawing.Size(275, 62);
            this.help1.TabIndex = 30;
            this.help1.Text = "Use W and S Keys\r\n to move the platform.";
            // 
            // help2
            // 
            this.help2.AutoSize = true;
            this.help2.BackColor = System.Drawing.Color.Transparent;
            this.help2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.help2.Location = new System.Drawing.Point(641, 260);
            this.help2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.help2.Name = "help2";
            this.help2.Size = new System.Drawing.Size(326, 62);
            this.help2.TabIndex = 30;
            this.help2.Text = "Use Up and Down Arrows\r\n to move the platform.";
            // 
            // esc_action_label
            // 
            this.esc_action_label.AutoSize = true;
            this.esc_action_label.BackColor = System.Drawing.Color.Transparent;
            this.esc_action_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.esc_action_label.Location = new System.Drawing.Point(248, 523);
            this.esc_action_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.esc_action_label.Name = "esc_action_label";
            this.esc_action_label.Size = new System.Drawing.Size(560, 46);
            this.esc_action_label.TabIndex = 31;
            this.esc_action_label.Text = "Press ESC to restart the game";
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.BackColor = System.Drawing.Color.Transparent;
            this.info_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_label.Location = new System.Drawing.Point(201, 446);
            this.info_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(696, 31);
            this.info_label.TabIndex = 32;
            this.info_label.Text = "Press F1 to show your mouse and F6 to Pause the game";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Profile:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(833, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Profile:";
            // 
            // pl2_profil
            // 
            this.pl2_profil.AutoSize = true;
            this.pl2_profil.BackColor = System.Drawing.Color.Transparent;
            this.pl2_profil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pl2_profil.ForeColor = System.Drawing.Color.DarkBlue;
            this.pl2_profil.Location = new System.Drawing.Point(917, 11);
            this.pl2_profil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pl2_profil.Name = "pl2_profil";
            this.pl2_profil.Size = new System.Drawing.Size(77, 20);
            this.pl2_profil.TabIndex = 36;
            this.pl2_profil.Text = "pl2_profil";
            // 
            // pl1_profil
            // 
            this.pl1_profil.AutoSize = true;
            this.pl1_profil.BackColor = System.Drawing.Color.Transparent;
            this.pl1_profil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pl1_profil.ForeColor = System.Drawing.Color.DarkBlue;
            this.pl1_profil.Location = new System.Drawing.Point(97, 11);
            this.pl1_profil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pl1_profil.Name = "pl1_profil";
            this.pl1_profil.Size = new System.Drawing.Size(77, 20);
            this.pl1_profil.TabIndex = 36;
            this.pl1_profil.Text = "pl1_profil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "Game Wins:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(835, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(91, 18);
            this.label6.TabIndex = 37;
            this.label6.Text = "Game Wins:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Move_and_kill.Properties.Resources.test;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 580);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.info_label);
            this.Controls.Add(this.esc_action_label);
            this.Controls.Add(this.help2);
            this.Controls.Add(this.help1);
            this.Controls.Add(this.paused_btn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.platform2);
            this.Controls.Add(this.platform);
            this.Controls.Add(this.oneplayer_btn);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.play_again_txt);
            this.Controls.Add(this.twoplayer_btn);
            this.Controls.Add(this.game_score2);
            this.Controls.Add(this.gameover);
            this.Controls.Add(this.game_score1);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.name2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pl1_profil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pl2_profil);
            this.Controls.Add(this.playground);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ping Pong Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.playground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button twoplayer_btn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label gameover;
        private System.Windows.Forms.Label play_again_txt;
        private System.Windows.Forms.PictureBox playground;
        private System.Windows.Forms.Label game_score1;
        private System.Windows.Forms.Label game_score2;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Label name1;
        private System.Windows.Forms.Label name2;
        private System.Windows.Forms.Button oneplayer_btn;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox platform;
        private System.Windows.Forms.PictureBox platform2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label paused_btn;
        private System.Windows.Forms.Label help1;
        private System.Windows.Forms.Label help2;
        private System.Windows.Forms.Label esc_action_label;
        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label pl2_profil;
        public System.Windows.Forms.Label pl1_profil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}

