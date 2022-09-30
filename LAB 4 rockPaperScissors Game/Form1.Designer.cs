namespace LAB_4_rockPaperScissors_Game
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.scissors_user = new System.Windows.Forms.PictureBox();
            this.paper_user = new System.Windows.Forms.PictureBox();
            this.rock_user = new System.Windows.Forms.PictureBox();
            this.scissors = new System.Windows.Forms.PictureBox();
            this.paper = new System.Windows.Forms.PictureBox();
            this.rock = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rock_button = new System.Windows.Forms.Button();
            this.paper_button = new System.Windows.Forms.Button();
            this.scissors_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scissors_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PC Points";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.button1.Location = new System.Drawing.Point(361, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 288);
            this.button1.TabIndex = 7;
            this.button1.Text = "PLAY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // scissors_user
            // 
            this.scissors_user.BackgroundImage = global::LAB_4_rockPaperScissors_Game.Properties.Resources.scissors;
            this.scissors_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scissors_user.Location = new System.Drawing.Point(740, 485);
            this.scissors_user.Name = "scissors_user";
            this.scissors_user.Size = new System.Drawing.Size(254, 221);
            this.scissors_user.TabIndex = 6;
            this.scissors_user.TabStop = false;
            // 
            // paper_user
            // 
            this.paper_user.BackgroundImage = global::LAB_4_rockPaperScissors_Game.Properties.Resources.paperr;
            this.paper_user.Location = new System.Drawing.Point(740, 247);
            this.paper_user.Name = "paper_user";
            this.paper_user.Size = new System.Drawing.Size(254, 232);
            this.paper_user.TabIndex = 5;
            this.paper_user.TabStop = false;
            // 
            // rock_user
            // 
            this.rock_user.BackgroundImage = global::LAB_4_rockPaperScissors_Game.Properties.Resources.rock;
            this.rock_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rock_user.Location = new System.Drawing.Point(740, 49);
            this.rock_user.Name = "rock_user";
            this.rock_user.Size = new System.Drawing.Size(254, 192);
            this.rock_user.TabIndex = 4;
            this.rock_user.TabStop = false;
            // 
            // scissors
            // 
            this.scissors.BackgroundImage = global::LAB_4_rockPaperScissors_Game.Properties.Resources.scissors;
            this.scissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scissors.Location = new System.Drawing.Point(46, 485);
            this.scissors.Name = "scissors";
            this.scissors.Size = new System.Drawing.Size(235, 221);
            this.scissors.TabIndex = 3;
            this.scissors.TabStop = false;
            // 
            // paper
            // 
            this.paper.BackgroundImage = global::LAB_4_rockPaperScissors_Game.Properties.Resources.paperr;
            this.paper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.paper.Location = new System.Drawing.Point(46, 247);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(230, 215);
            this.paper.TabIndex = 2;
            this.paper.TabStop = false;
            // 
            // rock
            // 
            this.rock.BackgroundImage = global::LAB_4_rockPaperScissors_Game.Properties.Resources.rock;
            this.rock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rock.Location = new System.Drawing.Point(46, 49);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(230, 192);
            this.rock.TabIndex = 1;
            this.rock.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(686, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "SELECT ONE CHOICE HERE:";
            // 
            // rock_button
            // 
            this.rock_button.Location = new System.Drawing.Point(629, 114);
            this.rock_button.Name = "rock_button";
            this.rock_button.Size = new System.Drawing.Size(93, 48);
            this.rock_button.TabIndex = 9;
            this.rock_button.Text = "ROCK";
            this.rock_button.UseVisualStyleBackColor = true;
            this.rock_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // paper_button
            // 
            this.paper_button.Location = new System.Drawing.Point(629, 350);
            this.paper_button.Name = "paper_button";
            this.paper_button.Size = new System.Drawing.Size(93, 48);
            this.paper_button.TabIndex = 10;
            this.paper_button.Text = "PAPER";
            this.paper_button.UseVisualStyleBackColor = true;
            this.paper_button.Click += new System.EventHandler(this.paper_button_Click);
            // 
            // scissors_button
            // 
            this.scissors_button.Location = new System.Drawing.Point(629, 577);
            this.scissors_button.Name = "scissors_button";
            this.scissors_button.Size = new System.Drawing.Size(93, 48);
            this.scissors_button.TabIndex = 11;
            this.scissors_button.Text = "SCISSORS";
            this.scissors_button.UseVisualStyleBackColor = true;
            this.scissors_button.Click += new System.EventHandler(this.scissors_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(439, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "My Points";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 764);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.scissors_button);
            this.Controls.Add(this.paper_button);
            this.Controls.Add(this.rock_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.scissors_user);
            this.Controls.Add(this.paper_user);
            this.Controls.Add(this.rock_user);
            this.Controls.Add(this.scissors);
            this.Controls.Add(this.paper);
            this.Controls.Add(this.rock);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.scissors_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox rock;
        private System.Windows.Forms.PictureBox paper;
        private System.Windows.Forms.PictureBox scissors;
        private System.Windows.Forms.PictureBox rock_user;
        private System.Windows.Forms.PictureBox paper_user;
        private System.Windows.Forms.PictureBox scissors_user;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button rock_button;
        private System.Windows.Forms.Button paper_button;
        private System.Windows.Forms.Button scissors_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

