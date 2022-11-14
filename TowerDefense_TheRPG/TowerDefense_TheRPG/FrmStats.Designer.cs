﻿namespace TowerDefense_TheRPG
{
    partial class FrmStats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStats));
            this.lblKills = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLevelStat = new System.Windows.Forms.Label();
            this.lblLevelStatValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKills
            // 
            this.lblKills.AutoSize = true;
            this.lblKills.BackColor = System.Drawing.Color.Transparent;
            this.lblKills.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKills.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblKills.Location = new System.Drawing.Point(221, 155);
            this.lblKills.Name = "lblKills";
            this.lblKills.Size = new System.Drawing.Size(76, 32);
            this.lblKills.TabIndex = 0;
            this.lblKills.Text = "Kills: ";
            this.lblKills.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(337, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "GAME OVER";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(130, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time Played: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(130, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kills: ";
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblCounter.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCounter.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblCounter.Location = new System.Drawing.Point(324, 99);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(76, 32);
            this.lblCounter.TabIndex = 4;
            this.lblCounter.Text = "Kills: ";
            this.lblCounter.Click += new System.EventHandler(this.lblCounter_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(130, 296);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(259, 85);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play again";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(520, 296);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(259, 85);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblLevelStat
            // 
            this.lblLevelStat.AutoSize = true;
            this.lblLevelStat.BackColor = System.Drawing.Color.Transparent;
            this.lblLevelStat.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLevelStat.ForeColor = System.Drawing.Color.White;
            this.lblLevelStat.Location = new System.Drawing.Point(130, 204);
            this.lblLevelStat.Name = "lblLevelStat";
            this.lblLevelStat.Size = new System.Drawing.Size(91, 37);
            this.lblLevelStat.TabIndex = 7;
            this.lblLevelStat.Text = "Level:";
            // 
            // lblLevelStatValue
            // 
            this.lblLevelStatValue.AutoSize = true;
            this.lblLevelStatValue.BackColor = System.Drawing.Color.Transparent;
            this.lblLevelStatValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLevelStatValue.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblLevelStatValue.Location = new System.Drawing.Point(227, 209);
            this.lblLevelStatValue.Name = "lblLevelStatValue";
            this.lblLevelStatValue.Size = new System.Drawing.Size(72, 32);
            this.lblLevelStatValue.TabIndex = 8;
            this.lblLevelStatValue.Text = "Level";
            this.lblLevelStatValue.Click += new System.EventHandler(this.lblLevelStatValue_Click);
            // 
            // FrmStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(914, 436);
            this.Controls.Add(this.lblLevelStatValue);
            this.Controls.Add(this.lblLevelStat);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKills);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmStats";
            this.Text = "FrmStats";
            this.Load += new System.EventHandler(this.FrmStats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblKills;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblCounter;
        private Button btnPlay;
        private Button btnExit;
        private Label lblLevelStat;
        private Label lblLevelStatValue;
    }
}