using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ColorGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl_state.Hide();
        }
        int level = 2;
        int score = 0;
        //order of colors
        List<int> orderOfColors = new List<int>();

        //order of colors by player
        List<int> playerInput = new List<int>();

        //Generate the random order of colors and display it
        public void GenerateRandomColorOrder()
        {
            Random rng = new Random();
            for (int i = 0; i < level; i++)
            {
                orderOfColors.Add(rng.Next(1, 5));
            }
        }

        //Start the game
        private void bnt_play_Click(object sender, EventArgs e)
        {
            lbl_state.Show();
            lbl_state.ForeColor = Color.Red;
            lbl_state.Text = "Wait";

            Thread.Sleep(900);

            //Display the order
            Thread thread = new Thread(() => DisplayColorOrder());
            thread.Start();
        }

        private void bnt_Red_Click(object sender, EventArgs e)
        {
            playerInput.Add(1);
        }

        private void bnt_Green_Click(object sender, EventArgs e)
        {
            playerInput.Add(2);
        }

        private void bnt_blue_Click(object sender, EventArgs e)
        {
            playerInput.Add(3);
        }

        private void bnt_yellow_Click(object sender, EventArgs e)
        {
            playerInput.Add(4);
        }

        //Change the color of the buttons to display the order in with they must be pressed
        public void DisplayColorOrder()
        {
            lbl_state.Show();
            lbl_state.ForeColor = Color.Red;
            lbl_state.Text = "Wait";

            GenerateRandomColorOrder();

            foreach (var item in orderOfColors)
            {
                if (item == 1)
                {
                    int argb = bnt_Red.BackColor.ToArgb();
                    bnt_Red.BackColor = Color.FromArgb(50,255,0,100);
                    Thread.Sleep(250);
                    bnt_Red.BackColor = Color.FromArgb(argb);
                }
                else if (item == 2)
                {
                    int argb = bnt_Green.BackColor.ToArgb();
                    bnt_Green.BackColor = Color.FromArgb(50,0,255,0);
                    Thread.Sleep(250);
                    bnt_Green.BackColor = Color.FromArgb(argb);
                }
                else if (item == 3)
                {
                    int argb = bnt_blue.BackColor.ToArgb();
                    bnt_blue.BackColor = Color.FromArgb(50, 0, 0, 255);
                    Thread.Sleep(250);
                    bnt_blue.BackColor = Color.FromArgb(argb);
                }
                else if (item == 4)
                {
                    int argb = bnt_yellow.BackColor.ToArgb();
                    bnt_yellow.BackColor = Color.FromArgb(50, 255, 255, 0);
                    Thread.Sleep(250);
                    bnt_yellow.BackColor = Color.FromArgb(argb);
                }
                Thread.Sleep(1000);
            }
            lbl_state.ForeColor = Color.Green;
            lbl_state.Text = "Go!";
        }
        //Check whether or not player's order is correct
        public void CheckPlayerInput()
        {
            if (orderOfColors.Count == 0)
            {
                MessageBox.Show("Click Play First");
                return;
            }
            if (orderOfColors.SequenceEqual(playerInput))
            {
                level += 1;
                score += 200;
                lbl_score.Text = $"Score:{score}";
                Thread thread = new Thread(() => DisplayColorOrder());
                thread.Start();
            }
            else
            {
                MessageBox.Show($"You Lost!\nYou Reached level {level - 2}\nYour score was {score}");
                level = 2;
                score = 0;
                lbl_score.Text = $"Score:{score}";
            }
        }
        private void bnt_checkOrder_Click(object sender, EventArgs e)
        {
            CheckPlayerInput();
            orderOfColors.Clear();
            playerInput.Clear();
            lbl_state.Hide();
        }
    }
}
