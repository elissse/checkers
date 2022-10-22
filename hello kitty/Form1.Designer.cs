namespace hello_kitty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startPlaying = new System.Windows.Forms.Panel();
            this.endOfTheGame = new System.Windows.Forms.FlowLayoutPanel();
            this.winnerDeclaration = new System.Windows.Forms.TextBox();
            this.statingOver = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.TextBox();
            this.player1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.score2 = new System.Windows.Forms.TextBox();
            this.name2 = new System.Windows.Forms.TextBox();
            this.player2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.score1 = new System.Windows.Forms.TextBox();
            this.name1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.startPlaying.SuspendLayout();
            this.endOfTheGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // startPlaying
            // 
            this.startPlaying.AllowDrop = true;
            this.startPlaying.BackColor = System.Drawing.Color.HotPink;
            this.startPlaying.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.startPlaying.Controls.Add(this.endOfTheGame);
            this.startPlaying.Controls.Add(this.start);
            this.startPlaying.ForeColor = System.Drawing.Color.MintCream;
            this.startPlaying.ImeMode = System.Windows.Forms.ImeMode.On;
            this.startPlaying.Location = new System.Drawing.Point(-7, 1);
            this.startPlaying.Name = "startPlaying";
            this.startPlaying.Size = new System.Drawing.Size(1279, 808);
            this.startPlaying.TabIndex = 0;
            // 
            // endOfTheGame
            // 
            this.endOfTheGame.BackColor = System.Drawing.Color.LawnGreen;
            this.endOfTheGame.Controls.Add(this.winnerDeclaration);
            this.endOfTheGame.Controls.Add(this.statingOver);
            this.endOfTheGame.Location = new System.Drawing.Point(3, 0);
            this.endOfTheGame.Name = "endOfTheGame";
            this.endOfTheGame.Size = new System.Drawing.Size(1277, 806);
            this.endOfTheGame.TabIndex = 3;
            this.endOfTheGame.Visible = false;
            this.endOfTheGame.Paint += new System.Windows.Forms.PaintEventHandler(this.endOfTheGame_Paint);
            // 
            // winnerDeclaration
            // 
            this.winnerDeclaration.BackColor = System.Drawing.Color.LawnGreen;
            this.winnerDeclaration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.winnerDeclaration.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.winnerDeclaration.ForeColor = System.Drawing.Color.DeepPink;
            this.winnerDeclaration.Location = new System.Drawing.Point(0, 200);
            this.winnerDeclaration.Margin = new System.Windows.Forms.Padding(0, 200, 50, 50);
            this.winnerDeclaration.Name = "winnerDeclaration";
            this.winnerDeclaration.Size = new System.Drawing.Size(1112, 109);
            this.winnerDeclaration.TabIndex = 0;
            this.winnerDeclaration.Text = "YOU WIN!!!!!!!!!!!!!";
            this.winnerDeclaration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.winnerDeclaration.Visible = false;
            // 
            // statingOver
            // 
            this.statingOver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statingOver.BackColor = System.Drawing.Color.DeepPink;
            this.statingOver.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statingOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statingOver.Location = new System.Drawing.Point(3, 362);
            this.statingOver.Multiline = true;
            this.statingOver.Name = "statingOver";
            this.statingOver.Size = new System.Drawing.Size(1098, 29);
            this.statingOver.TabIndex = 1;
            this.statingOver.Text = "press to play again";
            this.statingOver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.statingOver.TextChanged += new System.EventHandler(this.statingOver_TextChanged);
            this.statingOver.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.playAgain_KeyPress);
            // 
            // start
            // 
            this.start.AcceptsTab = true;
            this.start.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.Color.HotPink;
            this.start.Location = new System.Drawing.Point(423, 287);
            this.start.Name = "start";
            this.start.ShortcutsEnabled = false;
            this.start.Size = new System.Drawing.Size(150, 38);
            this.start.TabIndex = 1;
            this.start.TabStop = false;
            this.start.Text = "press to start";
            this.start.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.Pink;
            this.player1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.player1.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.player1.Location = new System.Drawing.Point(583, 123);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(123, 31);
            this.player1.TabIndex = 0;
            this.player1.TabStop = false;
            this.player1.Text = "player one";
            this.player1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.pictureBox1.Image = global::hello_kitty.Properties.Resources.yp;
            this.pictureBox1.Location = new System.Drawing.Point(591, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // score2
            // 
            this.score2.BackColor = System.Drawing.Color.Pink;
            this.score2.Font = new System.Drawing.Font("Poor Richard", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.score2.Location = new System.Drawing.Point(663, 465);
            this.score2.Name = "score2";
            this.score2.ReadOnly = true;
            this.score2.Size = new System.Drawing.Size(43, 47);
            this.score2.TabIndex = 2;
            this.score2.TabStop = false;
            this.score2.Text = "0";
            this.score2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // name2
            // 
            this.name2.BackColor = System.Drawing.Color.Pink;
            this.name2.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name2.ForeColor = System.Drawing.Color.Violet;
            this.name2.Location = new System.Drawing.Point(737, 413);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(212, 38);
            this.name2.TabIndex = 8;
            this.name2.TabStop = false;
            this.name2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name1_KeyPress);
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.Pink;
            this.player2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.player2.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2.ForeColor = System.Drawing.Color.Violet;
            this.player2.Location = new System.Drawing.Point(591, 413);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(123, 31);
            this.player2.TabIndex = 1;
            this.player2.TabStop = false;
            this.player2.Text = "player two";
            this.player2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::hello_kitty.Properties.Resources.y;
            this.pictureBox2.Location = new System.Drawing.Point(591, 458);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // score1
            // 
            this.score1.BackColor = System.Drawing.Color.Pink;
            this.score1.Font = new System.Drawing.Font("Poor Richard", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score1.ForeColor = System.Drawing.Color.Violet;
            this.score1.Location = new System.Drawing.Point(671, 62);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(43, 47);
            this.score1.TabIndex = 3;
            this.score1.TabStop = false;
            this.score1.Text = "0";
            this.score1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // name1
            // 
            this.name1.BackColor = System.Drawing.Color.Pink;
            this.name1.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.name1.Location = new System.Drawing.Point(737, 123);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(212, 38);
            this.name1.TabIndex = 7;
            this.name1.TabStop = false;
            this.name1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name1_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Pink;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(40, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(480, 22);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "  a                 b                 c                 d                 e      " +
    "            f                  g                 h    ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Pink;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(24, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(15, 22);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "1";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Pink;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(24, 183);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(15, 22);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "3";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Pink;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(24, 123);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(15, 22);
            this.textBox4.TabIndex = 12;
            this.textBox4.Text = "2";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Pink;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(24, 243);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(15, 22);
            this.textBox5.TabIndex = 13;
            this.textBox5.Text = "4";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Pink;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(24, 303);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(15, 22);
            this.textBox6.TabIndex = 14;
            this.textBox6.Text = "5";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.Pink;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(24, 363);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(15, 22);
            this.textBox7.TabIndex = 15;
            this.textBox7.Text = "6";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.Pink;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Enabled = false;
            this.textBox8.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(24, 423);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(15, 22);
            this.textBox8.TabIndex = 16;
            this.textBox8.Text = "7";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.Pink;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Enabled = false;
            this.textBox9.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(24, 483);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(15, 22);
            this.textBox9.TabIndex = 17;
            this.textBox9.Text = "8";
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1284, 811);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.startPlaying);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.score1);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.name2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.score2);
            this.Controls.Add(this.name1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Checkers!!!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.startPlaying.ResumeLayout(false);
            this.startPlaying.PerformLayout();
            this.endOfTheGame.ResumeLayout(false);
            this.endOfTheGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox start;
        private System.Windows.Forms.Panel startPlaying;
        private System.Windows.Forms.TextBox score1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox player2;
        private System.Windows.Forms.TextBox score2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox player1;
        public System.Windows.Forms.TextBox name1;
        public System.Windows.Forms.TextBox name2;
        private System.Windows.Forms.FlowLayoutPanel endOfTheGame;
        private System.Windows.Forms.TextBox winnerDeclaration;
        public System.Windows.Forms.TextBox statingOver;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
    }
}

