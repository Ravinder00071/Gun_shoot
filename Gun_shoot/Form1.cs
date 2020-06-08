using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Media;
namespace Gun_shoot
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gun.Hide();
            bullet.Hide();
            gun_load_img.Show();
            blast.Hide();
            man.Hide();
            spin.Hide();
            SoundPlayer splayer = new SoundPlayer(Gun_shoot.Properties.Resources.Load);
            splayer.Play();
        }

        private void gun_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gun_load_img.Hide();
            bullet.Hide();
            blast.Hide();
            spin.Hide();
        }

   
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        


        private void timer1_tick_1(object sender, EventArgs e)
        {

            int x = bullet.Location.X;
            int y = bullet.Location.Y;

            bullet.Location = new Point(x + 25, y);

            if (x > 455)
                timer1.Stop();
            man.Hide();
            blast.Show();
            bullet.Hide();
            spin.Hide();

        }

        private void timer2_tick_1(object sender, EventArgs e)
        {

            int x = bullet.Location.X;
            int y = bullet.Location.Y;

            bullet.Location = new Point(x + 25, y);

            if (x > 455)
                timer2.Stop();
            blast.Hide();
            man.Show();
            //blast.Show();
            bullet.Hide();
            spin.Hide();


        }

        private void button4_Click(object sender, EventArgs e)
        {

            String Score = "10";
            gun_load_img.Hide();
            gun.Show();
            bullet.Show();
            man.Show();
            spin.Hide();
            timer1.Interval = 15;
            timer1.Tick += new EventHandler(timer1_tick_1);

            timer1.Start();

            SoundPlayer splayer = new SoundPlayer(Gun_shoot.Properties.Resources._1);
            splayer.Play();

            MessageBox.Show("YOU Have Shot The Target!! Your Score is " + Score , "Hurrah You Have Won");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            bullet.Location = new Point(79, 116);
            bullet.Hide();
            gun_load_img.Hide();
            gun.Show();
            blast.Hide();
            man.Show();
            spin.Hide();
            MessageBox.Show("YOU ARE ABOUT TO PLAY GAME AGAIN" , "Try Your Luck Again");
          
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutCreatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created By Manik Vaid" , "About Creator");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gun_load_img.Hide();
            gun.Hide();
            man.Hide();
            spin.Show();
            SoundPlayer splayer = new SoundPlayer(Gun_shoot.Properties.Resources.Spin1);
            splayer.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            String Score2 = "0";
            timer2.Start();

            timer2.Interval = 15;
            timer2.Tick += new EventHandler(timer2_tick_1);

            

            gun_load_img.Hide();
            gun.Show();
            bullet.Show();
            man.Show();
            blast.Hide();
            spin.Hide();


            SoundPlayer splayer = new SoundPlayer(Gun_shoot.Properties.Resources._1);
            splayer.Play();

            
            MessageBox.Show("You Have Missed the Shot , Your Score is " + Score2, "Alas! You Lost");

        }
    }
}
