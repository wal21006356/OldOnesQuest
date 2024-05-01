namespace OldOne_sQuest
{
    partial class BattleScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleScreen));
            this.imgEWizard = new System.Windows.Forms.PictureBox();
            this.imgPWizard = new System.Windows.Forms.PictureBox();
            this.lblPName = new System.Windows.Forms.Label();
            this.lblEName = new System.Windows.Forms.Label();
            this.prbrPHealth = new System.Windows.Forms.ProgressBar();
            this.btnBattle = new System.Windows.Forms.Button();
            this.prbrEHealth = new System.Windows.Forms.ProgressBar();
            this.lblPHealth = new System.Windows.Forms.Label();
            this.lblPWisdom = new System.Windows.Forms.Label();
            this.prbrPWisdom = new System.Windows.Forms.ProgressBar();
            this.lblPDexterity = new System.Windows.Forms.Label();
            this.prbrPDexterity = new System.Windows.Forms.ProgressBar();
            this.prbrEWisdom = new System.Windows.Forms.ProgressBar();
            this.prbrEDexterity = new System.Windows.Forms.ProgressBar();
            this.lblEHealth = new System.Windows.Forms.Label();
            this.lblEWisdom = new System.Windows.Forms.Label();
            this.lblEDexterity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgEWizard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPWizard)).BeginInit();
            this.SuspendLayout();
            // 
            // imgEWizard
            // 
            this.imgEWizard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgEWizard.Location = new System.Drawing.Point(474, 75);
            this.imgEWizard.Name = "imgEWizard";
            this.imgEWizard.Size = new System.Drawing.Size(200, 200);
            this.imgEWizard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgEWizard.TabIndex = 1;
            this.imgEWizard.TabStop = false;
            // 
            // imgPWizard
            // 
            this.imgPWizard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPWizard.Location = new System.Drawing.Point(125, 75);
            this.imgPWizard.Name = "imgPWizard";
            this.imgPWizard.Size = new System.Drawing.Size(200, 200);
            this.imgPWizard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPWizard.TabIndex = 2;
            this.imgPWizard.TabStop = false;
            // 
            // lblPName
            // 
            this.lblPName.AutoSize = true;
            this.lblPName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPName.Location = new System.Drawing.Point(128, 278);
            this.lblPName.Name = "lblPName";
            this.lblPName.Size = new System.Drawing.Size(84, 17);
            this.lblPName.TabIndex = 3;
            this.lblPName.Text = "Player Name: ";
            // 
            // lblEName
            // 
            this.lblEName.AutoSize = true;
            this.lblEName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEName.Location = new System.Drawing.Point(477, 278);
            this.lblEName.Name = "lblEName";
            this.lblEName.Size = new System.Drawing.Size(84, 17);
            this.lblEName.TabIndex = 4;
            this.lblEName.Text = "Enemy Name: ";
            // 
            // prbrPHealth
            // 
            this.prbrPHealth.BackColor = System.Drawing.SystemColors.Control;
            this.prbrPHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.prbrPHealth.Location = new System.Drawing.Point(125, 298);
            this.prbrPHealth.MarqueeAnimationSpeed = 0;
            this.prbrPHealth.Name = "prbrPHealth";
            this.prbrPHealth.Size = new System.Drawing.Size(200, 20);
            this.prbrPHealth.Step = 50;
            this.prbrPHealth.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbrPHealth.TabIndex = 5;
            this.prbrPHealth.Value = 50;
            // 
            // btnBattle
            // 
            this.btnBattle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBattle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBattle.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBattle.Location = new System.Drawing.Point(351, 347);
            this.btnBattle.Name = "btnBattle";
            this.btnBattle.Size = new System.Drawing.Size(93, 34);
            this.btnBattle.TabIndex = 6;
            this.btnBattle.Text = "button1";
            this.btnBattle.UseVisualStyleBackColor = false;
            this.btnBattle.Click += new System.EventHandler(this.btnBattle_Click);
            // 
            // prbrEHealth
            // 
            this.prbrEHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.prbrEHealth.Location = new System.Drawing.Point(474, 298);
            this.prbrEHealth.Name = "prbrEHealth";
            this.prbrEHealth.Size = new System.Drawing.Size(200, 20);
            this.prbrEHealth.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbrEHealth.TabIndex = 7;
            this.prbrEHealth.Value = 50;
            // 
            // lblPHealth
            // 
            this.lblPHealth.AutoSize = true;
            this.lblPHealth.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPHealth.Location = new System.Drawing.Point(128, 321);
            this.lblPHealth.Name = "lblPHealth";
            this.lblPHealth.Size = new System.Drawing.Size(53, 17);
            this.lblPHealth.TabIndex = 8;
            this.lblPHealth.Text = "Health: ";
            // 
            // lblPWisdom
            // 
            this.lblPWisdom.AutoSize = true;
            this.lblPWisdom.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPWisdom.Location = new System.Drawing.Point(128, 364);
            this.lblPWisdom.Name = "lblPWisdom";
            this.lblPWisdom.Size = new System.Drawing.Size(58, 17);
            this.lblPWisdom.TabIndex = 10;
            this.lblPWisdom.Text = "Wisdom: ";
            // 
            // prbrPWisdom
            // 
            this.prbrPWisdom.BackColor = System.Drawing.SystemColors.Control;
            this.prbrPWisdom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.prbrPWisdom.Location = new System.Drawing.Point(125, 341);
            this.prbrPWisdom.Maximum = 50;
            this.prbrPWisdom.Name = "prbrPWisdom";
            this.prbrPWisdom.Size = new System.Drawing.Size(200, 20);
            this.prbrPWisdom.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbrPWisdom.TabIndex = 9;
            this.prbrPWisdom.Value = 15;
            // 
            // lblPDexterity
            // 
            this.lblPDexterity.AutoSize = true;
            this.lblPDexterity.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPDexterity.Location = new System.Drawing.Point(128, 407);
            this.lblPDexterity.Name = "lblPDexterity";
            this.lblPDexterity.Size = new System.Drawing.Size(72, 17);
            this.lblPDexterity.TabIndex = 12;
            this.lblPDexterity.Text = "Dexterity: ";
            // 
            // prbrPDexterity
            // 
            this.prbrPDexterity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.prbrPDexterity.Location = new System.Drawing.Point(125, 384);
            this.prbrPDexterity.Maximum = 50;
            this.prbrPDexterity.Name = "prbrPDexterity";
            this.prbrPDexterity.Size = new System.Drawing.Size(200, 20);
            this.prbrPDexterity.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbrPDexterity.TabIndex = 11;
            this.prbrPDexterity.Value = 15;
            // 
            // prbrEWisdom
            // 
            this.prbrEWisdom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.prbrEWisdom.Location = new System.Drawing.Point(474, 341);
            this.prbrEWisdom.Maximum = 50;
            this.prbrEWisdom.Name = "prbrEWisdom";
            this.prbrEWisdom.Size = new System.Drawing.Size(200, 20);
            this.prbrEWisdom.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbrEWisdom.TabIndex = 13;
            this.prbrEWisdom.Value = 50;
            // 
            // prbrEDexterity
            // 
            this.prbrEDexterity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.prbrEDexterity.Location = new System.Drawing.Point(474, 384);
            this.prbrEDexterity.Maximum = 50;
            this.prbrEDexterity.Name = "prbrEDexterity";
            this.prbrEDexterity.Size = new System.Drawing.Size(200, 20);
            this.prbrEDexterity.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbrEDexterity.TabIndex = 15;
            this.prbrEDexterity.Value = 50;
            // 
            // lblEHealth
            // 
            this.lblEHealth.AutoSize = true;
            this.lblEHealth.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEHealth.Location = new System.Drawing.Point(477, 321);
            this.lblEHealth.Name = "lblEHealth";
            this.lblEHealth.Size = new System.Drawing.Size(53, 17);
            this.lblEHealth.TabIndex = 17;
            this.lblEHealth.Text = "Health: ";
            // 
            // lblEWisdom
            // 
            this.lblEWisdom.AutoSize = true;
            this.lblEWisdom.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEWisdom.Location = new System.Drawing.Point(477, 364);
            this.lblEWisdom.Name = "lblEWisdom";
            this.lblEWisdom.Size = new System.Drawing.Size(58, 17);
            this.lblEWisdom.TabIndex = 18;
            this.lblEWisdom.Text = "Wisdom: ";
            // 
            // lblEDexterity
            // 
            this.lblEDexterity.AutoSize = true;
            this.lblEDexterity.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEDexterity.Location = new System.Drawing.Point(477, 407);
            this.lblEDexterity.Name = "lblEDexterity";
            this.lblEDexterity.Size = new System.Drawing.Size(72, 17);
            this.lblEDexterity.TabIndex = 19;
            this.lblEDexterity.Text = "Dexterity: ";
            // 
            // BattleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEDexterity);
            this.Controls.Add(this.lblEWisdom);
            this.Controls.Add(this.lblEHealth);
            this.Controls.Add(this.prbrEDexterity);
            this.Controls.Add(this.prbrEWisdom);
            this.Controls.Add(this.lblPDexterity);
            this.Controls.Add(this.prbrPDexterity);
            this.Controls.Add(this.lblPWisdom);
            this.Controls.Add(this.prbrPWisdom);
            this.Controls.Add(this.lblPHealth);
            this.Controls.Add(this.prbrEHealth);
            this.Controls.Add(this.btnBattle);
            this.Controls.Add(this.prbrPHealth);
            this.Controls.Add(this.lblEName);
            this.Controls.Add(this.lblPName);
            this.Controls.Add(this.imgPWizard);
            this.Controls.Add(this.imgEWizard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BattleScreen";
            this.Text = "BattleScreen";
            ((System.ComponentModel.ISupportInitialize)(this.imgEWizard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPWizard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgEWizard;
        private System.Windows.Forms.PictureBox imgPWizard;
        private System.Windows.Forms.Label lblPName;
        private System.Windows.Forms.Label lblEName;
        private System.Windows.Forms.ProgressBar prbrPHealth;
        private System.Windows.Forms.Button btnBattle;
        private System.Windows.Forms.ProgressBar prbrEHealth;
        private System.Windows.Forms.Label lblPHealth;
        private System.Windows.Forms.Label lblPWisdom;
        private System.Windows.Forms.ProgressBar prbrPWisdom;
        private System.Windows.Forms.Label lblPDexterity;
        private System.Windows.Forms.ProgressBar prbrPDexterity;
        private System.Windows.Forms.ProgressBar prbrEWisdom;
        private System.Windows.Forms.ProgressBar prbrEDexterity;
        private System.Windows.Forms.Label lblEHealth;
        private System.Windows.Forms.Label lblEWisdom;
        private System.Windows.Forms.Label lblEDexterity;
    }
}