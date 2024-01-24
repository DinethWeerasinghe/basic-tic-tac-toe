using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }





        private void btn_1_Click(object sender, EventArgs e)
        {

            if (btn_1.Text == "")
            {
                int buttonsWithTextCount = 0;
                foreach (Control control in this.Controls)
                {
                    if (control is Button button)
                    {
                        if (!string.IsNullOrWhiteSpace(button.Text))
                        {
                            buttonsWithTextCount++;
                        }
                    }
                }

                DoTurn(buttonsWithTextCount);

                switch (buttonsWithTextCount)
                {
                    case 0:
                        btn_1.Text = "X";
                        break;
                    case 1:
                        btn_1.Text = "O";
                        break;
                    case 2:
                        btn_1.Text = "X"; ;
                        break;
                    case 3:
                        btn_1.Text = "O";
                        break;
                    case 4:
                        btn_1.Text = "X";
                        break;
                    case 5:
                        btn_1.Text = "O";
                        break;
                    case 6:
                        btn_1.Text = "X";
                        break;
                    case 7:
                        btn_1.Text = "O";
                        break;
                    case 8:
                        btn_1.Text = "X";
                        break;

                }
            }

            if (btn_1.Text == "X")
            {
                if (btn_2.Text == "X" && btn_3.Text == "X")
                {
                    btn_1.ForeColor = Color.Red;
                    btn_2.ForeColor = Color.Red;
                    btn_3.ForeColor = Color.Red;
                }

                if (btn_4.Text == "X" && btn_7.Text == "X")
                {
                    btn_1.ForeColor = Color.Red;
                    btn_4.ForeColor = Color.Red;
                    btn_7.ForeColor = Color.Red;
                }

                if (btn_5.Text == "X" && btn_9.Text == "X")
                {
                    btn_1.ForeColor = Color.Red;
                    btn_5.ForeColor = Color.Red;
                    btn_9.ForeColor = Color.Red;
                }
            }

            if (btn_1.Text == "O")
            {
                if (btn_2.Text == "O" && btn_3.Text == "O")
                {
                    btn_1.ForeColor = Color.Red;
                    btn_2.ForeColor = Color.Red;
                    btn_3.ForeColor = Color.Red;
                }

                if (btn_4.Text == "O" && btn_7.Text == "O")
                {
                    btn_1.ForeColor = Color.Red;
                    btn_4.ForeColor = Color.Red;
                    btn_7.ForeColor = Color.Red;
                }

                if (btn_5.Text == "O" && btn_9.Text == "O")
                {
                    btn_1.ForeColor = Color.Red;
                    btn_5.ForeColor = Color.Red;
                    btn_9.ForeColor = Color.Red;
                }
            }

            if (btn_2.ForeColor == Color.Red || btn_4.ForeColor == Color.Red || btn_5.ForeColor == Color.Red || btn_6.ForeColor == Color.Red || btn_8.ForeColor == Color.Red)
            {
                EndGame();
            }

        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (btn_2.Text == "")
            {
                int buttonsWithTextCount = 0;
                foreach (Control control in this.Controls)
                {
                    if (control is Button button)
                    {
                        if (!string.IsNullOrWhiteSpace(button.Text))
                        {
                            buttonsWithTextCount++;
                        }
                    }
                }

                DoTurn(buttonsWithTextCount);

                switch (buttonsWithTextCount)
                {
                    case 0:
                        btn_2.Text = "X";
                        break;
                    case 1:
                        btn_2.Text = "O";
                        break;
                    case 2:
                        btn_2.Text = "X"; ;
                        break;
                    case 3:
                        btn_2.Text = "O";
                        break;
                    case 4:
                        btn_2.Text = "X";
                        break;
                    case 5:
                        btn_2.Text = "O";
                        break;
                    case 6:
                        btn_2.Text = "X";
                        break;
                    case 7:
                        btn_2.Text = "O";
                        break;
                    case 8:
                        btn_2.Text = "X";
                        break;

                }
            }

            if (btn_2.Text == "X")
            {
                if (btn_1.Text == "X" && btn_3.Text == "X")
                {
                    btn_1.ForeColor = Color.Red;
                    btn_2.ForeColor = Color.Red;
                    btn_3.ForeColor = Color.Red;
                }

                if (btn_5.Text == "X" && btn_8.Text == "X")
                {
                    btn_2.ForeColor = Color.Red;
                    btn_5.ForeColor = Color.Red;
                    btn_8.ForeColor = Color.Red;
                }
            }

            if (btn_2.Text == "O")
            {
                if (btn_1.Text == "O" && btn_3.Text == "O")
                {
                    btn_1.ForeColor = Color.Red;
                    btn_2.ForeColor = Color.Red;
                    btn_3.ForeColor = Color.Red;
                }

                if (btn_5.Text == "O" && btn_8.Text == "O")
                {
                    btn_2.ForeColor = Color.Red;
                    btn_5.ForeColor = Color.Red;
                    btn_8.ForeColor = Color.Red;
                }
            }

            if (btn_2.ForeColor == Color.Red || btn_4.ForeColor == Color.Red || btn_5.ForeColor == Color.Red || btn_6.ForeColor == Color.Red || btn_8.ForeColor == Color.Red)
            {
                EndGame();
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (btn_3.Text == "")
            {
                int buttonsWithTextCount = 0;
                foreach (Control control in this.Controls)
                {
                    if (control is Button button)
                    {
                        if (!string.IsNullOrWhiteSpace(button.Text))
                        {
                            buttonsWithTextCount++;
                        }
                    }
                }

                DoTurn(buttonsWithTextCount);

                switch (buttonsWithTextCount)
                {
                    case 0:
                        btn_3.Text = "X";
                        break;
                    case 1:
                        btn_3.Text = "O";
                        break;
                    case 2:
                        btn_3.Text = "X"; ;
                        break;
                    case 3:
                        btn_3.Text = "O";
                        break;
                    case 4:
                        btn_3.Text = "X";
                        break;
                    case 5:
                        btn_3.Text = "O";
                        break;
                    case 6:
                        btn_3.Text = "X";
                        break;
                    case 7:
                        btn_3.Text = "O";
                        break;
                    case 8:
                        btn_3.Text = "X";
                        break;

                }

            }

            if (btn_3.Text == "X")
            {
                if (btn_1.Text == "X" && btn_2.Text == "X")
                {
                    btn_1.ForeColor = Color.Red;
                    btn_2.ForeColor = Color.Red;
                    btn_3.ForeColor = Color.Red;
                }

                if (btn_5.Text == "X" && btn_7.Text == "X")
                {
                    btn_3.ForeColor = Color.Red;
                    btn_5.ForeColor = Color.Red;
                    btn_7.ForeColor = Color.Red;
                }

                if (btn_6.Text == "X" && btn_9.Text == "X")
                {
                    btn_3.ForeColor = Color.Red;
                    btn_6.ForeColor = Color.Red;
                    btn_9.ForeColor = Color.Red;
                }
            }

            if (btn_3.Text == "O")
            {
                if (btn_1.Text == "O" && btn_2.Text == "O")
                {
                    btn_1.ForeColor = Color.Red;
                    btn_2.ForeColor = Color.Red;
                    btn_3.ForeColor = Color.Red;
                }

                if (btn_5.Text == "O" && btn_7.Text == "O")
                {
                    btn_3.ForeColor = Color.Red;
                    btn_5.ForeColor = Color.Red;
                    btn_7.ForeColor = Color.Red;
                }

                if (btn_6.Text == "O" && btn_9.Text == "O")
                {
                    btn_3.ForeColor = Color.Red;
                    btn_6.ForeColor = Color.Red;
                    btn_9.ForeColor = Color.Red;
                }
            }

            if (btn_2.ForeColor == Color.Red || btn_4.ForeColor == Color.Red || btn_5.ForeColor == Color.Red || btn_6.ForeColor == Color.Red || btn_8.ForeColor == Color.Red)
            {
                EndGame();
            }
        }
        private void btn_4_Click(object sender, EventArgs e)
        {
            if (btn_4.Text == "")
            {
                int buttonsWithTextCount = 0;
                foreach (Control control in this.Controls)
                {
                    if (control is Button button)
                    {
                        if (!string.IsNullOrWhiteSpace(button.Text))
                        {
                            buttonsWithTextCount++;
                        }
                    }
                }

                DoTurn(buttonsWithTextCount);

                switch (buttonsWithTextCount)
                {
                    case 0:
                        btn_4.Text = "X";
                        break;
                    case 1:
                        btn_4.Text = "O";
                        break;
                    case 2:
                        btn_4.Text = "X"; ;
                        break;
                    case 3:
                        btn_4.Text = "O";
                        break;
                    case 4:
                        btn_4.Text = "X";
                        break;
                    case 5:
                        btn_4.Text = "O";
                        break;
                    case 6:
                        btn_4.Text = "X";
                        break;
                    case 7:
                        btn_4.Text = "O";
                        break;
                    case 8:
                        btn_4.Text = "X";
                        break;

                }
            }

            if (btn_4.Text == "X")
            {
                if (btn_5.Text == "X" && btn_6.Text == "X")
                {
                    btn_4.ForeColor = Color.Red;
                    btn_5.ForeColor = Color.Red;
                    btn_6.ForeColor = Color.Red;
                }

                if (btn_1.Text == "X" && btn_7.Text == "X")
                {
                    btn_1.ForeColor = Color.Red;
                    btn_4.ForeColor = Color.Red;
                    btn_7.ForeColor = Color.Red;
                }
            }

            if (btn_4.Text == "O")
            {
                if (btn_5.Text == "O" && btn_6.Text == "O")
                {
                    btn_4.ForeColor = Color.Red;
                    btn_5.ForeColor = Color.Red;
                    btn_6.ForeColor = Color.Red;
                }

                if (btn_1.Text == "O" && btn_7.Text == "O")
                {
                    btn_1.ForeColor = Color.Red;
                    btn_4.ForeColor = Color.Red;
                    btn_7.ForeColor = Color.Red;
                }
            }

            if (btn_2.ForeColor == Color.Red || btn_4.ForeColor == Color.Red || btn_5.ForeColor == Color.Red || btn_6.ForeColor == Color.Red || btn_8.ForeColor == Color.Red)
            {
                EndGame();
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (btn_5.Text == "")
            {
                int buttonsWithTextCount = 0;
                foreach (Control control in this.Controls)
                {
                    if (control is Button button)
                    {
                        if (!string.IsNullOrWhiteSpace(button.Text))
                        {
                            buttonsWithTextCount++;
                        }
                    }
                }

                DoTurn(buttonsWithTextCount);

                switch (buttonsWithTextCount)
                {
                    case 0:
                        btn_5.Text = "X";
                        break;
                    case 1:
                        btn_5.Text = "O";
                        break;
                    case 2:
                        btn_5.Text = "X"; ;
                        break;
                    case 3:
                        btn_5.Text = "O";
                        break;
                    case 4:
                        btn_5.Text = "X";
                        break;
                    case 5:
                        btn_5.Text = "O";
                        break;
                    case 6:
                        btn_5.Text = "X";
                        break;
                    case 7:
                        btn_5.Text = "O";
                        break;
                    case 8:
                        btn_5.Text = "X";
                        break;

                }
            }

            if (btn_5.Text == "X")
            {
                if (btn_1.Text == "X" && btn_9.Text == "X")
                {
                    btn_1.ForeColor = Color.Red;
                    btn_5.ForeColor = Color.Red;
                    btn_9.ForeColor = Color.Red;
                }

                if (btn_3.Text == "X" && btn_7.Text == "X")
                {
                    btn_3.ForeColor = Color.Red;
                    btn_5.ForeColor = Color.Red;
                    btn_7.ForeColor = Color.Red;
                }

                if (btn_2.Text == "X" && btn_8.Text == "X")
                {
                    btn_2.ForeColor = Color.Red;
                    btn_5.ForeColor = Color.Red;
                    btn_8.ForeColor = Color.Red;
                }

                if (btn_4.Text == "X" && btn_6.Text == "X")
                {
                    btn_4.ForeColor = Color.Red;
                    btn_5.ForeColor = Color.Red;
                    btn_6.ForeColor = Color.Red;
                }
            }

            if (btn_5.Text == "O")
            {
                if (btn_1.Text == "O" && btn_9.Text == "O")
                {
                    btn_1.ForeColor = Color.Red;
                    btn_5.ForeColor = Color.Red;
                    btn_9.ForeColor = Color.Red;
                }

                if (btn_3.Text == "O" && btn_7.Text == "O")
                {
                    btn_3.ForeColor = Color.Red;
                    btn_5.ForeColor = Color.Red;
                    btn_7.ForeColor = Color.Red;
                }

                if (btn_2.Text == "O" && btn_8.Text == "O")
                {
                    btn_2.ForeColor = Color.Red;
                    btn_5.ForeColor = Color.Red;
                    btn_8.ForeColor = Color.Red;
                }

                if (btn_4.Text == "O" && btn_6.Text == "O")
                {
                    btn_4.ForeColor = Color.Red;
                    btn_5.ForeColor = Color.Red;
                    btn_6.ForeColor = Color.Red;
                }
            }

            if (btn_2.ForeColor == Color.Red || btn_4.ForeColor == Color.Red || btn_5.ForeColor == Color.Red || btn_6.ForeColor == Color.Red || btn_8.ForeColor == Color.Red)
            {
                EndGame();
            }

        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (btn_6.Text == "")
            {
                int buttonsWithTextCount = 0;
                foreach (Control control in this.Controls)
                {
                    if (control is Button button)
                    {
                        if (!string.IsNullOrWhiteSpace(button.Text))
                        {
                            buttonsWithTextCount++;
                        }
                    }
                }

                DoTurn(buttonsWithTextCount);

                switch (buttonsWithTextCount)
                {
                    case 0:
                        btn_6.Text = "X";
                        break;
                    case 1:
                        btn_6.Text = "O";
                        break;
                    case 2:
                        btn_6.Text = "X"; ;
                        break;
                    case 3:
                        btn_6.Text = "O";
                        break;
                    case 4:
                        btn_6.Text = "X";
                        break;
                    case 5:
                        btn_6.Text = "O";
                        break;
                    case 6:
                        btn_6.Text = "X";
                        break;
                    case 7:
                        btn_6.Text = "O";
                        break;
                    case 8:
                        btn_6.Text = "X";
                        break;

                }
            }

            if (btn_6.Text == "X")
            {
                if (btn_4.Text == "X" && btn_5.Text == "X")
                {
                    btn_4.ForeColor = Color.Red;
                    btn_5.ForeColor = Color.Red;
                    btn_6.ForeColor = Color.Red;
                }

                if (btn_3.Text == "X" && btn_9.Text == "X")
                {
                    btn_3.ForeColor = Color.Red;
                    btn_6.ForeColor = Color.Red;
                    btn_9.ForeColor = Color.Red;
                }
            }

            if (btn_6.Text == "O")
            {
                if (btn_4.Text == "O" && btn_5.Text == "O")
                {
                    btn_4.ForeColor = Color.Red;
                    btn_5.ForeColor = Color.Red;
                    btn_6.ForeColor = Color.Red;
                }

                if (btn_3.Text == "O" && btn_9.Text == "O")
                {
                    btn_3.ForeColor = Color.Red;
                    btn_6.ForeColor = Color.Red;
                    btn_9.ForeColor = Color.Red;
                }
            }

            if (btn_2.ForeColor == Color.Red || btn_4.ForeColor == Color.Red || btn_5.ForeColor == Color.Red || btn_6.ForeColor == Color.Red || btn_8.ForeColor == Color.Red)
            {
                EndGame();
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (btn_7.Text == "")
            {
                int buttonsWithTextCount = 0;
                foreach (Control control in this.Controls)
                {
                    if (control is Button button)
                    {
                        if (!string.IsNullOrWhiteSpace(button.Text))
                        {
                            buttonsWithTextCount++;
                        }
                    }
                }

                DoTurn(buttonsWithTextCount);

                switch (buttonsWithTextCount)
                {
                    case 0:
                        btn_7.Text = "X";
                        break;
                    case 1:
                        btn_7.Text = "O";
                        break;
                    case 2:
                        btn_7.Text = "X"; ;
                        break;
                    case 3:
                        btn_7.Text = "O";
                        break;
                    case 4:
                        btn_7.Text = "X";
                        break;
                    case 5:
                        btn_7.Text = "O";
                        break;
                    case 6:
                        btn_7.Text = "X";
                        break;
                    case 7:
                        btn_7.Text = "O";
                        break;
                    case 8:
                        btn_7.Text = "X";
                        break;

                }
            }

            if (btn_7.Text == "X")
            {
                if (btn_1.Text == "X" && btn_4.Text == "X")
                {
                    btn_1.ForeColor = Color.Red;
                    btn_4.ForeColor = Color.Red;
                    btn_7.ForeColor = Color.Red;
                }

                if (btn_5.Text == "X" && btn_3.Text == "X")
                {
                    btn_3.ForeColor = Color.Red;
                    btn_5.ForeColor = Color.Red;
                    btn_7.ForeColor = Color.Red;
                }

                if (btn_8.Text == "X" && btn_9.Text == "X")
                {
                    btn_7.ForeColor = Color.Red;
                    btn_8.ForeColor = Color.Red;
                    btn_9.ForeColor = Color.Red;
                }
            }

            if (btn_7.Text == "O")
            {
                if (btn_1.Text == "O" && btn_4.Text == "O")
                {
                    btn_1.ForeColor = Color.Red;
                    btn_4.ForeColor = Color.Red;
                    btn_7.ForeColor = Color.Red;
                }

                if (btn_5.Text == "O" && btn_3.Text == "O")
                {
                    btn_3.ForeColor = Color.Red;
                    btn_5.ForeColor = Color.Red;
                    btn_7.ForeColor = Color.Red;
                }

                if (btn_8.Text == "O" && btn_9.Text == "O")
                {
                    btn_7.ForeColor = Color.Red;
                    btn_8.ForeColor = Color.Red;
                    btn_9.ForeColor = Color.Red;
                }
            }

            if (btn_2.ForeColor == Color.Red || btn_4.ForeColor == Color.Red || btn_5.ForeColor == Color.Red || btn_6.ForeColor == Color.Red || btn_8.ForeColor == Color.Red)
            {
                EndGame();
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (btn_8.Text == "")
            {
                int buttonsWithTextCount = 0;
                foreach (Control control in this.Controls)
                {
                    if (control is Button button)
                    {
                        if (!string.IsNullOrWhiteSpace(button.Text))
                        {
                            buttonsWithTextCount++;
                        }
                    }
                }

                DoTurn(buttonsWithTextCount);

                switch (buttonsWithTextCount)
                {
                    case 0:
                        btn_8.Text = "X";
                        break;
                    case 1:
                        btn_8.Text = "O";
                        break;
                    case 2:
                        btn_8.Text = "X"; ;
                        break;
                    case 3:
                        btn_8.Text = "O";
                        break;
                    case 4:
                        btn_8.Text = "X";
                        break;
                    case 5:
                        btn_8.Text = "O";
                        break;
                    case 6:
                        btn_8.Text = "X";
                        break;
                    case 7:
                        btn_8.Text = "O";
                        break;
                    case 8:
                        btn_8.Text = "X";
                        break;

                }
            }

            if (btn_8.Text == "X")
            {
                if (btn_7.Text == "X" && btn_9.Text == "X")
                {
                    btn_7.ForeColor = Color.Red;
                    btn_8.ForeColor = Color.Red;
                    btn_9.ForeColor = Color.Red;
                }

                if (btn_2.Text == "X" && btn_5.Text == "X")
                {
                    btn_2.ForeColor = Color.Red;
                    btn_5.ForeColor = Color.Red;
                    btn_8.ForeColor = Color.Red;
                }
            }

            if (btn_8.Text == "O")
            {
                if (btn_7.Text == "O" && btn_9.Text == "O")
                {
                    btn_7.ForeColor = Color.Red;
                    btn_8.ForeColor = Color.Red;
                    btn_9.ForeColor = Color.Red;
                }

                if (btn_2.Text == "O" && btn_5.Text == "O")
                {
                    btn_2.ForeColor = Color.Red;
                    btn_5.ForeColor = Color.Red;
                    btn_8.ForeColor = Color.Red;
                }
            }

            if (btn_2.ForeColor == Color.Red || btn_4.ForeColor == Color.Red || btn_5.ForeColor == Color.Red || btn_6.ForeColor == Color.Red || btn_8.ForeColor == Color.Red)
            {
                EndGame();
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (btn_9.Text == "")
            {
                int buttonsWithTextCount = 0;
                foreach (Control control in this.Controls)
                {
                    if (control is Button button)
                    {
                        if (!string.IsNullOrWhiteSpace(button.Text))
                        {
                            buttonsWithTextCount++;
                        }
                    }
                }

                DoTurn(buttonsWithTextCount);

                switch (buttonsWithTextCount)
                {
                    case 0:
                        btn_9.Text = "X";
                        break;
                    case 1:
                        btn_9.Text = "O";
                        break;
                    case 2:
                        btn_9.Text = "X"; ;
                        break;
                    case 3:
                        btn_9.Text = "O";
                        break;
                    case 4:
                        btn_9.Text = "X";
                        break;
                    case 5:
                        btn_9.Text = "O";
                        break;
                    case 6:
                        btn_9.Text = "X";
                        break;
                    case 7:
                        btn_9.Text = "O";
                        break;
                    case 8:
                        btn_9.Text = "X";
                        break;

                }

            }



            if (btn_9.Text == "X")
            {
                if (btn_1.Text == "X" && btn_5.Text == "X")
                {
                    btn_1.ForeColor = Color.Red;
                    btn_5.ForeColor = Color.Red;
                    btn_9.ForeColor = Color.Red;
                }

                if (btn_3.Text == "X" && btn_6.Text == "X")
                {
                    btn_3.ForeColor = Color.Red;
                    btn_6.ForeColor = Color.Red;
                    btn_9.ForeColor = Color.Red;
                }

                if (btn_7.Text == "X" && btn_8.Text == "X")
                {
                    btn_7.ForeColor = Color.Red;
                    btn_8.ForeColor = Color.Red;
                    btn_9.ForeColor = Color.Red;
                }
            }

            if (btn_9.Text == "O")
            {
                if (btn_1.Text == "O" && btn_5.Text == "O")
                {
                    btn_1.ForeColor = Color.Red;
                    btn_5.ForeColor = Color.Red;
                    btn_9.ForeColor = Color.Red;
                }

                if (btn_3.Text == "O" && btn_6.Text == "O")
                {
                    btn_3.ForeColor = Color.Red;
                    btn_6.ForeColor = Color.Red;
                    btn_9.ForeColor = Color.Red;
                }

                if (btn_7.Text == "O" && btn_8.Text == "O")
                {
                    btn_7.ForeColor = Color.Red;
                    btn_8.ForeColor = Color.Red;
                    btn_9.ForeColor = Color.Red;
                }
            }

            if (btn_2.ForeColor == Color.Red || btn_4.ForeColor == Color.Red || btn_5.ForeColor == Color.Red || btn_6.ForeColor == Color.Red || btn_8.ForeColor == Color.Red)
            {
                EndGame();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_player1.Text = profile.player1;
            lbl_player2.Text = profile.player2;




            lbl_turnName.Text = profile.player1 + "'s Turn";



        }



        public void DoTurn(int i)
        {
            switch (i + 1)
            {
                case 1:
                    lbl_turnName.Text = profile.player2 + "'s Turn";
                    break;
                case 2:
                    lbl_turnName.Text = profile.player1 + "'s Turn";
                    break;
                case 3:
                    lbl_turnName.Text = profile.player2 + "'s Turn";
                    break;
                case 4:
                    lbl_turnName.Text = profile.player1 + "'s Turn";
                    break;
                case 5:
                    lbl_turnName.Text = profile.player2 + "'s Turn";
                    break;
                case 6:
                    lbl_turnName.Text = profile.player1 + "'s Turn";
                    break;
                case 7:
                    lbl_turnName.Text = profile.player2 + "'s Turn";
                    break;
                case 8:
                    lbl_turnName.Text = profile.player1 + "'s Turn";
                    break;
                case 9:
                    lbl_turnName.Visible = false;
                    break;

            }

        }

        public void buttonClick()
        {

        }


        public void EndGame()
        {
            lbl_turnName.Visible = false;

            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    if (string.IsNullOrWhiteSpace(button.Text))
                    {
                        button.Enabled = false;
                    }
                }
            }

            MessageBox.Show("Game End !");

            this.Close();

            new Form1().Show();
        }
    }
}
