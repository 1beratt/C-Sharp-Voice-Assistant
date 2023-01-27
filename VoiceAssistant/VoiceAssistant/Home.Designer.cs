namespace VoiceAssistant
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.VoiceCommandBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DesignedLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BeratClkBtn = new System.Windows.Forms.Button();
            this.OptionsBtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.mic1 = new System.Windows.Forms.PictureBox();
            this.mic2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mic2)).BeginInit();
            this.SuspendLayout();
            // 
            // VoiceCommandBtn
            // 
            this.VoiceCommandBtn.FlatAppearance.BorderSize = 0;
            this.VoiceCommandBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VoiceCommandBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VoiceCommandBtn.ForeColor = System.Drawing.Color.White;
            this.VoiceCommandBtn.Location = new System.Drawing.Point(0, 394);
            this.VoiceCommandBtn.Name = "VoiceCommandBtn";
            this.VoiceCommandBtn.Size = new System.Drawing.Size(375, 60);
            this.VoiceCommandBtn.TabIndex = 2;
            this.VoiceCommandBtn.Text = "Your Command";
            this.VoiceCommandBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Voice Assistant";
            // 
            // DesignedLabel
            // 
            this.DesignedLabel.AutoSize = true;
            this.DesignedLabel.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesignedLabel.ForeColor = System.Drawing.Color.Black;
            this.DesignedLabel.Location = new System.Drawing.Point(78, 7);
            this.DesignedLabel.Name = "DesignedLabel";
            this.DesignedLabel.Size = new System.Drawing.Size(109, 26);
            this.DesignedLabel.TabIndex = 28;
            this.DesignedLabel.Text = "Designed By:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BeratClkBtn);
            this.panel1.Controls.Add(this.DesignedLabel);
            this.panel1.Location = new System.Drawing.Point(0, 460);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 42);
            this.panel1.TabIndex = 29;
            // 
            // BeratClkBtn
            // 
            this.BeratClkBtn.BackColor = System.Drawing.Color.Transparent;
            this.BeratClkBtn.BackgroundImage = global::VoiceAssistant.Properties.Resources.berat_celik_logo;
            this.BeratClkBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BeratClkBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BeratClkBtn.FlatAppearance.BorderSize = 0;
            this.BeratClkBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BeratClkBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BeratClkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BeratClkBtn.Font = new System.Drawing.Font("Poppins Medium", 11.25F);
            this.BeratClkBtn.ForeColor = System.Drawing.Color.Black;
            this.BeratClkBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BeratClkBtn.Location = new System.Drawing.Point(185, 5);
            this.BeratClkBtn.Name = "BeratClkBtn";
            this.BeratClkBtn.Size = new System.Drawing.Size(112, 30);
            this.BeratClkBtn.TabIndex = 27;
            this.BeratClkBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BeratClkBtn.UseVisualStyleBackColor = false;
            this.BeratClkBtn.Click += new System.EventHandler(this.BeratClkBtn_Click);
            // 
            // OptionsBtn
            // 
            this.OptionsBtn.BackColor = System.Drawing.Color.Transparent;
            this.OptionsBtn.BackgroundImage = global::VoiceAssistant.Properties.Resources.menu;
            this.OptionsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OptionsBtn.color = System.Drawing.Color.Transparent;
            this.OptionsBtn.colorActive = System.Drawing.Color.Transparent;
            this.OptionsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OptionsBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.OptionsBtn.ForeColor = System.Drawing.Color.White;
            this.OptionsBtn.Image = global::VoiceAssistant.Properties.Resources.menu;
            this.OptionsBtn.ImagePosition = 20;
            this.OptionsBtn.ImageZoom = 10;
            this.OptionsBtn.LabelPosition = 41;
            this.OptionsBtn.LabelText = "";
            this.OptionsBtn.Location = new System.Drawing.Point(330, 9);
            this.OptionsBtn.Margin = new System.Windows.Forms.Padding(6);
            this.OptionsBtn.Name = "OptionsBtn";
            this.OptionsBtn.Size = new System.Drawing.Size(30, 30);
            this.OptionsBtn.TabIndex = 4;
            this.OptionsBtn.Click += new System.EventHandler(this.OptionsBtn_Click);
            // 
            // mic1
            // 
            this.mic1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mic1.Image = global::VoiceAssistant.Properties.Resources.microphone;
            this.mic1.Location = new System.Drawing.Point(0, 50);
            this.mic1.Name = "mic1";
            this.mic1.Size = new System.Drawing.Size(375, 340);
            this.mic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mic1.TabIndex = 0;
            this.mic1.TabStop = false;
            this.mic1.Click += new System.EventHandler(this.mic1_Click);
            // 
            // mic2
            // 
            this.mic2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mic2.Image = global::VoiceAssistant.Properties.Resources.microphone_2;
            this.mic2.Location = new System.Drawing.Point(0, 50);
            this.mic2.Name = "mic2";
            this.mic2.Size = new System.Drawing.Size(375, 340);
            this.mic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mic2.TabIndex = 0;
            this.mic2.TabStop = false;
            this.mic2.Click += new System.EventHandler(this.mic2_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(375, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OptionsBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VoiceCommandBtn);
            this.Controls.Add(this.mic1);
            this.Controls.Add(this.mic2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voice Assistant";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mic1;
        private System.Windows.Forms.PictureBox mic2;
        private System.Windows.Forms.Button VoiceCommandBtn;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTileButton OptionsBtn;
        private System.Windows.Forms.Label DesignedLabel;
        private System.Windows.Forms.Button BeratClkBtn;
        private System.Windows.Forms.Panel panel1;
    }
}

