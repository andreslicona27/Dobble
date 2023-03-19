namespace SheldonsGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.pbAtom = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.lblRival = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.pbRival = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbSpock = new System.Windows.Forms.PictureBox();
            this.pbLizard = new System.Windows.Forms.PictureBox();
            this.pbScissors = new System.Windows.Forms.PictureBox();
            this.pbPaper = new System.Windows.Forms.PictureBox();
            this.pbRock = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAtom)).BeginInit();
            this.GamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRival)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLizard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sheldon´s Game";
            // 
            // pbAtom
            // 
            this.pbAtom.Image = ((System.Drawing.Image)(resources.GetObject("pbAtom.Image")));
            this.pbAtom.Location = new System.Drawing.Point(88, 189);
            this.pbAtom.Name = "pbAtom";
            this.pbAtom.Size = new System.Drawing.Size(200, 200);
            this.pbAtom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAtom.TabIndex = 1;
            this.pbAtom.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(363, 220);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(100, 51);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(363, 294);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 51);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // GamePanel
            // 
            this.GamePanel.Controls.Add(this.btnResult);
            this.GamePanel.Controls.Add(this.lblRival);
            this.GamePanel.Controls.Add(this.lblPlayer);
            this.GamePanel.Controls.Add(this.pbRival);
            this.GamePanel.Controls.Add(this.pbPlayer);
            this.GamePanel.Controls.Add(this.pbSpock);
            this.GamePanel.Controls.Add(this.pbLizard);
            this.GamePanel.Controls.Add(this.pbScissors);
            this.GamePanel.Controls.Add(this.pbPaper);
            this.GamePanel.Controls.Add(this.pbRock);
            this.GamePanel.Controls.Add(this.btnBack);
            this.GamePanel.Location = new System.Drawing.Point(12, 12);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(576, 476);
            this.GamePanel.TabIndex = 4;
            // 
            // lblRival
            // 
            this.lblRival.AutoSize = true;
            this.lblRival.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRival.Location = new System.Drawing.Point(398, 102);
            this.lblRival.Name = "lblRival";
            this.lblRival.Size = new System.Drawing.Size(42, 23);
            this.lblRival.TabIndex = 14;
            this.lblRival.Text = "Rival";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(49, 102);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(53, 23);
            this.lblPlayer.TabIndex = 13;
            this.lblPlayer.Text = "Player";
            // 
            // pbRival
            // 
            this.pbRival.Location = new System.Drawing.Point(398, 156);
            this.pbRival.Name = "pbRival";
            this.pbRival.Size = new System.Drawing.Size(120, 120);
            this.pbRival.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRival.TabIndex = 11;
            this.pbRival.TabStop = false;
            // 
            // pbPlayer
            // 
            this.pbPlayer.Location = new System.Drawing.Point(53, 156);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(120, 120);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer.TabIndex = 10;
            this.pbPlayer.TabStop = false;
            // 
            // pbSpock
            // 
            this.pbSpock.Image = global::SheldonsGame.Properties.Resources.spock;
            this.pbSpock.Location = new System.Drawing.Point(384, 408);
            this.pbSpock.Name = "pbSpock";
            this.pbSpock.Size = new System.Drawing.Size(50, 50);
            this.pbSpock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSpock.TabIndex = 9;
            this.pbSpock.TabStop = false;
            this.pbSpock.Tag = "spock";
            this.pbSpock.Click += new System.EventHandler(this.StartMatch);
            // 
            // pbLizard
            // 
            this.pbLizard.Image = global::SheldonsGame.Properties.Resources.lizard;
            this.pbLizard.Location = new System.Drawing.Point(319, 408);
            this.pbLizard.Name = "pbLizard";
            this.pbLizard.Size = new System.Drawing.Size(50, 50);
            this.pbLizard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLizard.TabIndex = 8;
            this.pbLizard.TabStop = false;
            this.pbLizard.Tag = "lizard";
            this.pbLizard.Click += new System.EventHandler(this.StartMatch);
            // 
            // pbScissors
            // 
            this.pbScissors.Image = global::SheldonsGame.Properties.Resources.scissors;
            this.pbScissors.Location = new System.Drawing.Point(254, 408);
            this.pbScissors.Name = "pbScissors";
            this.pbScissors.Size = new System.Drawing.Size(50, 50);
            this.pbScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbScissors.TabIndex = 7;
            this.pbScissors.TabStop = false;
            this.pbScissors.Tag = "scissors";
            this.pbScissors.Click += new System.EventHandler(this.StartMatch);
            // 
            // pbPaper
            // 
            this.pbPaper.Image = global::SheldonsGame.Properties.Resources.paper;
            this.pbPaper.Location = new System.Drawing.Point(188, 408);
            this.pbPaper.Name = "pbPaper";
            this.pbPaper.Size = new System.Drawing.Size(50, 50);
            this.pbPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPaper.TabIndex = 6;
            this.pbPaper.TabStop = false;
            this.pbPaper.Tag = "paper";
            this.pbPaper.Click += new System.EventHandler(this.StartMatch);
            // 
            // pbRock
            // 
            this.pbRock.Image = global::SheldonsGame.Properties.Resources.rock;
            this.pbRock.Location = new System.Drawing.Point(123, 408);
            this.pbRock.Name = "pbRock";
            this.pbRock.Size = new System.Drawing.Size(50, 50);
            this.pbRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRock.TabIndex = 5;
            this.pbRock.TabStop = false;
            this.pbRock.Tag = "rock";
            this.pbRock.Click += new System.EventHandler(this.StartMatch);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(70, 30);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.Transparent;
            this.btnResult.Enabled = false;
            this.btnResult.FlatAppearance.BorderSize = 0;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.Location = new System.Drawing.Point(224, 157);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(121, 119);
            this.btnResult.TabIndex = 15;
            this.btnResult.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pbAtom);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbAtom)).EndInit();
            this.GamePanel.ResumeLayout(false);
            this.GamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRival)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLizard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbAtom;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pbSpock;
        private System.Windows.Forms.PictureBox pbLizard;
        private System.Windows.Forms.PictureBox pbScissors;
        private System.Windows.Forms.PictureBox pbPaper;
        private System.Windows.Forms.PictureBox pbRock;
        private System.Windows.Forms.PictureBox pbRival;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Label lblRival;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Button btnResult;
    }
}

