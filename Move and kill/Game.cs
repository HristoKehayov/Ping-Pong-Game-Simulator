using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;


namespace Ping_pong_game
{
    public partial class Form1 : Form
    {
        //public Form1(string userName)
        //{   
        //    InitializeComponent();
        //    pl1_profil.Text = userName;
        //}
        public Form1()
        {
            InitializeComponent();
        }
        //all variables for the game
        int platformspeed1 = 40;
        int platformspeed2 = 40;
        public int x1 = 388, y1 = 350, wid = 10, speed_x = 2, speed_y = 2;
        public int restball_x = 381;
        public int restball_y = 230;
        public int restspeed_y = 2;
        public int restspeed_x = 2;  
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            ///////MOVE BOTH PLATFORM WITH ARROW KEYS
            if (keyData == Keys.Up)
            {
                //Platform movement for right side
                if (platform.Top >= playground.Top)
                {
                    //Stop the platform not to go to the right more
                    platform.Top -= platformspeed1;
                }        
            }
            if (keyData == Keys.Down)
            {
                //Platfrom movement for left side
                if (platform.Bottom <= playground.Bottom)
                {
                    //Stop the platform not to go to the left more
                    platform.Top += platformspeed1;
                }
                //MessageBox.Show("pressed");
            }
            ////// FOR THE OTHER PLATFORM//////
            if (keyData == Keys.W)
            {
                //Platform movement for right side
                if (platform2.Top >= playground.Top)
                {
                    //Stop the platform not to go to the right more
                    platform2.Top -= platformspeed2;
                }
            }
            if (keyData == Keys.S)
            {
                //Platfrom movement for left side
                if (platform2.Bottom <= playground.Bottom)
                {
                    //Stop the platform not to go to the left more
                    platform2.Top += platformspeed2;
                }
            }

            //Capture if esc button pressed
            if (keyData == Keys.F1)
            {
                //Show curse when esc button pressed
                Cursor.Show();
            }
            //Go to Main menu
            if (keyData == Keys.Escape)
            {
                label1.Show();
                label2.Show();
                name1.Show();
                name2.Show();
                textBox1.Show();
                textBox2.Show();
                help1.Show();
                help2.Show();
                game_score1.Show();
                game_score2.Show();
                play_again_txt.Show();
                timer1.Stop();
                Cursor.Show();
                oneplayer_btn.Show();
                twoplayer_btn.Show();
                ball.Top = restball_y;
                ball.Left = restball_x;
                esc_action_label.Show();
                info_label.Show();
                paused_btn.Hide();
                platformspeed1 = 40;
                platformspeed2 = 40;
                game_score1.Text = "0";
                game_score2.Text = "0";
            }
            //Pause game
            if (keyData == Keys.F6)
            {
                if (timer1.Enabled)
                {
                    platformspeed1 = 0;
                    platformspeed2 = 0;
                    timer1.Stop();
                    paused_btn.Show();
                }
                else
                {
                    platformspeed1 = 40;
                    platformspeed2 = 40;
                    timer1.Start();
                    paused_btn.Hide();
                }
                if (keyData == Keys.Enter)
                {
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                }
                
            }
            //Return funcion
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //////////BALL MOVEMENT///////////
            ball.Left -= speed_x;
            ball.Top -= speed_y;
            //////////COLLISION WITH PLATFORMS////////
            if (ball.Bounds.IntersectsWith(platform2.Bounds) ||
               ball.Bounds.IntersectsWith(platform.Bounds))
            {
                speed_x = -speed_x;
                if (speed_x > 0)
                {
                    speed_x++;
                }
                else
                {
                    speed_x--;
                }
            }
            /////////COLLISION WITH WALLS//////////
            if (ball.Left <= playground.Left)
            {
                //for left wall collision
                timer1.Stop();
                timer2.Stop();
                oneplayer_btn.Show();
                twoplayer_btn.Show();
                ball.Top = restball_y;
                ball.Left = restball_x;
                game_score2.Text = (int.Parse(game_score2.Text) + 1).ToString(); //when ball is out right score +1
                Cursor.Show();
            }
            if (ball.Right >= playground.Right)
            {
                //for right wall collision
                timer1.Stop();
                timer2.Stop();
                oneplayer_btn.Show();
                twoplayer_btn.Show();
                ball.Top = restball_y;
                ball.Left = restball_x;
                game_score1.Text = (int.Parse(game_score1.Text) + 1).ToString(); //when ball is out left score +1
                Cursor.Show();
            }
            if (ball.Top <= playground.Top)
            {
                speed_y = -speed_y; //for top wall collision
            }
            if (ball.Bottom >= playground.Bottom)
            {
                speed_y = -speed_y; //for bottom wall collision
            }
            if (game_score1.Text == "5")
            {
                //string saveintouser = pl1_profil.Text;
                //string MyConectionString = "Server=sql4.freemysqlhosting.net;Database=sql474846;uid=sql474846;password=cD1%dZ9!;port=3306";
                //string Query = "update sql474846.data set Wins='" + +1 + "' where Username='" + saveintouser + "';";
                //MySqlConnection connection = new MySqlConnection(MyConectionString);
                //MySqlCommand cmd = new MySqlCommand(Query, connection);
                //MySqlDataReader myReader;

                //capture that he won and save it into database
                //try
                //{
                //    connection.Open();
                //    myReader = cmd.ExecuteReader();
                //    while (myReader.Read())
                //    {

                //    }
                //}
                //catch (Exception)
                //{
                //    MessageBox.Show("Please check your internet connection!");
                //}

                ////////IF PLAYER 1  SCORED 5 POINTS DO THIS ->////////////
                MessageBox.Show(textBox1.Text  + " won!");
                gameover.Show();
                game_score1.Text = "0";
                game_score2.Text = "0";
                help1.Show();
                help2.Show();
                label1.Show();
                label2.Show();
                textBox1.Show();
                textBox2.Show();
                esc_action_label.Show();
                play_again_txt.Show();
                info_label.Show();
            }
            ////////IF PLAYER 2  SCORED 5 POINTS DO THIS ->////////////
            else if (game_score2.Text == "5")
            {
                MessageBox.Show(textBox2.Text + " won!");
                gameover.Show();
                game_score1.Text = "0";
                game_score2.Text = "0";
                help1.Show();
                help2.Show();
                label1.Show();
                label2.Show();
                textBox1.Show();
                textBox2.Show();
                esc_action_label.Show();
                play_again_txt.Show();
                info_label.Show();
                //capture that he won and put it into database
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //////////AUTO MOVEMENT FOR COMPUTER PLATFORM//////////
            if (speed_x < 0)
            {
                if (ball.Top + 14 > platform.Top + 42)
                {
                    platform.Top += 4;
                }
                else if (ball.Bottom - 14 < platform.Bottom - 42)
                {
                    platform.Top -= 3;
                }
            }
        }

        private void oneplayer_btn_MouseClick(object sender, MouseEventArgs e)
        {
            platformspeed1 = 0;
            oneplayer_btn.Hide();
            twoplayer_btn.Hide();
            gameover.Hide();
            play_again_txt.Hide();
            textBox1.Hide();
            label1.Hide();
            textBox2.Hide();
            label2.Hide();
            help1.Hide();
            help2.Hide();
            Cursor.Hide();
            speed_x = restspeed_x;
            timer1.Start();
            timer2.Start();
            esc_action_label.Hide();
            info_label.Hide();
            name2.Text = "Co-Player";
            textBox2.Text = name2.Text;
        }

        private void twoplayer_btn_MouseClick(object sender, MouseEventArgs e)
        {
            //when start_game_btn pressed do this ->
            twoplayer_btn.Hide();
            timer2.Stop();
            Cursor.Hide();
            timer1.Start();
            gameover.Hide();
            textBox1.Hide();
            label1.Hide();
            textBox2.Hide();
            label2.Hide();
            help1.Hide();
            help2.Hide();
            speed_x = restspeed_x;
            oneplayer_btn.Hide();
            play_again_txt.Hide();
            esc_action_label.Hide();
            info_label.Hide();
            platformspeed1 = 40;
            textBox2.Text = name2.Text;
        }

        private void oneplayer_btn_MouseDown(object sender, MouseEventArgs e)
        {
            oneplayer_btn.Image = Move_and_kill.Properties.Resources.player1_btn_clicked;
        }

        private void twoplayer_btn_MouseDown(object sender, MouseEventArgs e)
        {
            twoplayer_btn.Image = Move_and_kill.Properties.Resources.player2_btn_clicked;
        }

        private void oneplayer_btn_MouseUp(object sender, MouseEventArgs e)
        {
            oneplayer_btn.Image = Move_and_kill.Properties.Resources.player1_button;
        }

        private void twoplayer_btn_MouseUp(object sender, MouseEventArgs e)
        {
            twoplayer_btn.Image = Move_and_kill.Properties.Resources.player2_button;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                name1.Text = textBox1.Text;
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                name2.Text = textBox2.Text;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Form2 loginmainf = new Form2();
            //form2.Show();
            //if (loginmainf.Visible == false)
            //{
            //    loginmainf.Show();
            //}
            //loginmainf.Show();
        }

        private void SaveinDatabase()
        {
            //string saveintouser = pl1_profil.Text;
            //string MyConectionString = "Server=localhost;Database=ping_pong_game;uid=root;password=root";
            //MySqlConnection connection = new MySqlConnection(MyConectionString);
            //MySqlCommand cmd;
            //if (game_score1.Text == "5" /*|| game_score2.Text == "5"*/)
            //{
            //    //capture that he won and save it into database
            //    connection.Open();
            //    cmd = connection.CreateCommand();
            //    cmd.CommandText = "update database.ping_pong_game set (Username,Wins) (where Username='" + this.pl1_profil.Text + "'@Wins)";
            //    //cmd.Parameters.AddWithValue("@Username", saveintouser);
            //    cmd.Parameters.AddWithValue("@Wins", +1);
            //    cmd.ExecuteNonQuery();
            //    connection.Close();
            //}
        }
    }
}