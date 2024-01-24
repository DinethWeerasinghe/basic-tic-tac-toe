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
    public partial class profile : Form
    {
        public static string player1 = "";
        public static string player2 = "";

        public profile()
        {
            InitializeComponent();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            player1 = txt_player1.Text;
            player2 = txt_player2.Text;

            Form1 form1 = new Form1();
            
            if (txt_player1.Text != "" && txt_player2.Text != "" && cob_laps.Text != "") 
            {                
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Plese fill form","Error");
            }
            
        }

        private void profile_Load(object sender, EventArgs e)
        {
            cob_laps.Text = "1";
        }

        private void txt_player1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                txt_player2.Focus();
            }

            if (e.KeyCode == Keys.Up)
            {
                cob_laps.Focus();
            }

            if (e.KeyCode == Keys.Enter)
            {
                btn_play.PerformClick();
            }

        }

        private void txt_player2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                cob_laps.Focus();
            }

            if (e.KeyCode == Keys.Up)
            {
                txt_player1.Focus();
            }

            if (e.KeyCode == Keys.Enter)
            {
                btn_play.PerformClick();
            }

        }

        private void cob_laps_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_play.PerformClick();
            }
        }
    }
}
