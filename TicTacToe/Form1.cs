using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe {

    public partial class Form1 : Form {
        //Startplayer Variable, accessable from every other needed method
        public int startplayer;
        //Player
        public int player;
        //Global dataArray|Position y  x
        String[,] data = new String[3, 3] {
            {"", "", ""} ,  
            {"", "", ""} , 
            {"", "", ""} 
        };

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //Start message
            MessageBox.Show("Choose your Player Number\nThe Computer choose a random beginner");

            //Choose a random Player
            Random rdom = new Random();
            startplayer = rdom.Next(2)+1;

            //Set who's playing now
            player = startplayer;

            //Set label2 to random choosen player
            this.label2.Text = "" + startplayer;
        }

        private void button1_Click(object sender, EventArgs e) {
            //Check if button was clicked before
            if (checkarray(0, 0) == 0)
            {
                return;
            }

            //Sets the X or O
            button1.Text = checkplayer();

            //Transmite position data and save to global dataArray
            add2array(0, 0);
        }

        private void button2_Click(object sender, EventArgs e) {
            //Check if button was clicked before
            if (checkarray(0, 1) == 0) {
                return;
            }

            //Sets the X or O
            button2.Text = checkplayer();

            //Transmite position data and save to global dataArray
            add2array(0, 1);
        }

        private void button3_Click(object sender, EventArgs e) {
            //Check if button was clicked before
            if (checkarray(0, 2) == 0) {
                return;
            }

            //Sets the X or O
            button3.Text = checkplayer();

            //Transmite position data and save to global dataArray
            add2array(0, 2);
        }

        private void button4_Click(object sender, EventArgs e) {
            //Check if button was clicked before
            if (checkarray(1, 0) == 0) {
                return;
            }

            //Sets the X or O
            button4.Text = checkplayer();

            //Transmite position data and save to global dataArray
            add2array(1, 0);
        }

        private void button5_Click(object sender, EventArgs e) {
            //Check if button was clicked before
            if (checkarray(1, 1) == 0) {
                return;
            }

            //Sets the X or O
            button5.Text = checkplayer();

            //Transmite position data and save to global dataArray
            add2array(1, 1);
        }

        private void button6_Click(object sender, EventArgs e) {
            //Check if button was clicked before
            if (checkarray(1, 2) == 0) {
                return;
            }

            //Sets the X or O
            button6.Text = checkplayer();

            //Transmite position data and save to global dataArray
            add2array(1, 2);
        }

        private void button7_Click(object sender, EventArgs e) {
            //Check if button was clicked before
            if (checkarray(2, 0) == 0) {
                return;
            }

            //Sets the X or O
            button7.Text = checkplayer();

            //Transmite position data and save to global dataArray
            add2array(2, 0);
        }

        private void button8_Click(object sender, EventArgs e) {
            //Check if button was clicked before
            if (checkarray(2, 1) == 0) {
                return;
            }

            //Sets the X or O
            button8.Text = checkplayer();

            //Transmite position data and save to global dataArray
            add2array(2, 1);
        }

        private void button9_Click(object sender, EventArgs e) {
            //Check if button was clicked before
            if (checkarray(2,2) == 0) {
                return;
            }

            //Sets the X or O
            button9.Text = checkplayer();

            //Transmite position data and save to global dataArray
            add2array(2, 2);
        }

        public int checkarray(int y, int x) {
            //Check if button was allready clicked
            if (data[y, x] != "") {
                return 0;
            }
            else {
                return 1;
            }
        }


        public String checkplayer() {
            //This method checks the playerstate and returns an X or O
            if (player == 1) {
                return "X";
            }
            else {
                return "O";
            }
        }

        public void add2array(int y, int x) {
            //save the input to the global dataArray
            data[y,x] = "" + player;

            //test arrayvalue
            //MessageBox.Show(data[y,x]);

            //Check if someone has allredy won
            checkwin();
        }

        public void checkwin() {
            //Check the dataArray
            if (data[0, 0] == "1" && data[0, 1] == "1" && data[0, 2] == "1" || data[0, 0] == "2" && data[0, 1] == "2" && data[0, 2] == "2") {
                MessageBox.Show("Player " + player + " won!");
                return;
            }
            if (data[1, 0] == "1" && data[1, 1] == "1" && data[1, 2] == "1" || data[1, 0] == "2" && data[1, 1] == "2" && data[1, 2] == "2") {
                MessageBox.Show("Player " + player + " won!");
                return;
            }
            if (data[0, 2] == "1" && data[1, 1] == "1" && data[2, 0] == "1" || data[0, 2] == "2" && data[1, 1] == "2" && data[2, 0] == "2") {
                MessageBox.Show("Player " + player + " won!");
                return;
            }
            if (data[2, 0] == "1" && data[2, 1] == "1" && data[2, 2] == "1" || data[2, 0] == "2" && data[2, 1] == "2" && data[2, 2] == "2") {
                MessageBox.Show("Player " + player + " won!");
                return;
            }
            if (data[0, 0] == "1" && data[1, 1] == "1" && data[2, 2] == "1" || data[0, 0] == "2" && data[1, 1] == "2" && data[2, 2] == "2") {
                MessageBox.Show("Player " + player + " won!");
                return;
            }
            if (data[0, 0] == "1" && data[1, 0] == "1" && data[2, 0] == "1" || data[0, 0] == "2" && data[1, 0] == "2" && data[2, 0] == "2") {
                MessageBox.Show("Player " + player + " won!");
                return;
            }
            if (data[0, 1] == "1" && data[1, 1] == "1" && data[2, 1] == "1" || data[0, 1] == "2" && data[1, 1] == "2" && data[2, 1] == "2")
            {
                MessageBox.Show("Player " + player + " won!");
                return;
            }
            if (data[0, 2] == "1" && data[1, 2] == "1" && data[2, 2] == "1" || data[0, 2] == "2" && data[1, 2] == "2" && data[2, 2] == "2") {
                MessageBox.Show("Player " + player + " won!");
                return;
            }

            //switchplayer
            switchplayer();
        }

        public void switchplayer() {
            //switch player
            if (player == 1) {
                player = 2;
            }
            else {
                player = 1;
            }

            //Set Label
            label2.Text = "" + player;
        }

        private void label3_Click(object sender, EventArgs e) {
            //Print Log Value
            String log = "Eventlog: \n\n";
            for (int i = 0; i < 3 ; i++) {
                log = log + "\t";
                for (int ii2 = 0; ii2 < 3; ii2++) {
                    log = log + data[i, ii2] + " ";
                }
                log = log + "\n";
            }
            MessageBox.Show(log);

            //Restart
            int i2 = 0;
            do {
                for (int i = 0; i < 3; i++) {
                    data[i2, i] = "";
                }
                i2++;
            } while (i2 < 3);

            //Clean btns
            button1.Text = "-";
            button2.Text = "-";
            button3.Text = "-";
            button4.Text = "-";
            button5.Text = "-";
            button6.Text = "-";
            button7.Text = "-";
            button8.Text = "-";
            button9.Text = "-";
        }

    }
}

/* By Darius Musiolik
 * https://www.github.com/MrFlyingToasterman
 * MrFlyingToasterman@yahoo.de
 * 
 *  In case you fork me just remove my credit.
 * 
*/
