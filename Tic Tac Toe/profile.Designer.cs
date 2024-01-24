namespace Tic_Tac_Toe
{
    partial class profile
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
            this.lbl_player1 = new System.Windows.Forms.Label();
            this.lbl_player2 = new System.Windows.Forms.Label();
            this.lbl_laps = new System.Windows.Forms.Label();
            this.txt_player1 = new System.Windows.Forms.TextBox();
            this.txt_player2 = new System.Windows.Forms.TextBox();
            this.cob_laps = new System.Windows.Forms.ComboBox();
            this.btn_play = new System.Windows.Forms.Button();
            this.lbl_TicTacToe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_player1
            // 
            this.lbl_player1.AutoSize = true;
            this.lbl_player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_player1.Location = new System.Drawing.Point(57, 133);
            this.lbl_player1.Name = "lbl_player1";
            this.lbl_player1.Size = new System.Drawing.Size(73, 20);
            this.lbl_player1.TabIndex = 0;
            this.lbl_player1.Text = "Player 1";
            // 
            // lbl_player2
            // 
            this.lbl_player2.AutoSize = true;
            this.lbl_player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_player2.Location = new System.Drawing.Point(57, 180);
            this.lbl_player2.Name = "lbl_player2";
            this.lbl_player2.Size = new System.Drawing.Size(73, 20);
            this.lbl_player2.TabIndex = 0;
            this.lbl_player2.Text = "Player 2";
            // 
            // lbl_laps
            // 
            this.lbl_laps.AutoSize = true;
            this.lbl_laps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_laps.Location = new System.Drawing.Point(57, 231);
            this.lbl_laps.Name = "lbl_laps";
            this.lbl_laps.Size = new System.Drawing.Size(48, 20);
            this.lbl_laps.TabIndex = 0;
            this.lbl_laps.Text = "Laps";
            // 
            // txt_player1
            // 
            this.txt_player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_player1.Location = new System.Drawing.Point(169, 127);
            this.txt_player1.Name = "txt_player1";
            this.txt_player1.Size = new System.Drawing.Size(151, 26);
            this.txt_player1.TabIndex = 0;
            this.txt_player1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_player1_KeyDown);
            // 
            // txt_player2
            // 
            this.txt_player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_player2.Location = new System.Drawing.Point(169, 174);
            this.txt_player2.Name = "txt_player2";
            this.txt_player2.Size = new System.Drawing.Size(151, 26);
            this.txt_player2.TabIndex = 1;
            this.txt_player2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_player2_KeyDown);
            // 
            // cob_laps
            // 
            this.cob_laps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_laps.FormattingEnabled = true;
            this.cob_laps.Items.AddRange(new object[] {
            "1",
            "3",
            "5"});
            this.cob_laps.Location = new System.Drawing.Point(169, 223);
            this.cob_laps.Name = "cob_laps";
            this.cob_laps.Size = new System.Drawing.Size(121, 28);
            this.cob_laps.TabIndex = 2;
            this.cob_laps.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cob_laps_KeyDown);
            // 
            // btn_play
            // 
            this.btn_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play.Location = new System.Drawing.Point(200, 323);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(120, 45);
            this.btn_play.TabIndex = 3;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // lbl_TicTacToe
            // 
            this.lbl_TicTacToe.AutoSize = true;
            this.lbl_TicTacToe.Font = new System.Drawing.Font("MV Boli", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TicTacToe.Location = new System.Drawing.Point(141, 44);
            this.lbl_TicTacToe.Name = "lbl_TicTacToe";
            this.lbl_TicTacToe.Size = new System.Drawing.Size(223, 46);
            this.lbl_TicTacToe.TabIndex = 4;
            this.lbl_TicTacToe.Text = "Tic Tac Toe";
            // 
            // profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.lbl_TicTacToe);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.cob_laps);
            this.Controls.Add(this.txt_player2);
            this.Controls.Add(this.txt_player1);
            this.Controls.Add(this.lbl_laps);
            this.Controls.Add(this.lbl_player2);
            this.Controls.Add(this.lbl_player1);
            this.Name = "profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_player1;
        private System.Windows.Forms.Label lbl_player2;
        private System.Windows.Forms.Label lbl_laps;
        private System.Windows.Forms.TextBox txt_player1;
        private System.Windows.Forms.TextBox txt_player2;
        private System.Windows.Forms.ComboBox cob_laps;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Label lbl_TicTacToe;
    }
}