namespace VoiceAssistant
{
    partial class OptionsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsPage));
            this.HomeBtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.label1 = new System.Windows.Forms.Label();
            this.CommandTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SaveCommandBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DefaultCommDGV = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AddCommDGV = new System.Windows.Forms.DataGridView();
            this.DeleteCommandBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultCommDGV)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddCommDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.Transparent;
            this.HomeBtn.BackgroundImage = global::VoiceAssistant.Properties.Resources.home;
            this.HomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomeBtn.color = System.Drawing.Color.Transparent;
            this.HomeBtn.colorActive = System.Drawing.Color.Transparent;
            this.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.Image = global::VoiceAssistant.Properties.Resources.menu;
            this.HomeBtn.ImagePosition = 20;
            this.HomeBtn.ImageZoom = 10;
            this.HomeBtn.LabelPosition = 41;
            this.HomeBtn.LabelText = "";
            this.HomeBtn.Location = new System.Drawing.Point(330, 9);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(6);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(30, 30);
            this.HomeBtn.TabIndex = 6;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Voice Assistant - Add Command";
            // 
            // CommandTB
            // 
            this.CommandTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CommandTB.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CommandTB.ForeColor = System.Drawing.Color.White;
            this.CommandTB.HintForeColor = System.Drawing.Color.Empty;
            this.CommandTB.HintText = "";
            this.CommandTB.isPassword = false;
            this.CommandTB.LineFocusedColor = System.Drawing.Color.White;
            this.CommandTB.LineIdleColor = System.Drawing.Color.DarkGray;
            this.CommandTB.LineMouseHoverColor = System.Drawing.Color.White;
            this.CommandTB.LineThickness = 3;
            this.CommandTB.Location = new System.Drawing.Point(48, 74);
            this.CommandTB.Margin = new System.Windows.Forms.Padding(4);
            this.CommandTB.Name = "CommandTB";
            this.CommandTB.Size = new System.Drawing.Size(279, 44);
            this.CommandTB.TabIndex = 7;
            this.CommandTB.Text = "Command";
            this.CommandTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // SaveCommandBtn
            // 
            this.SaveCommandBtn.ActiveBorderThickness = 1;
            this.SaveCommandBtn.ActiveCornerRadius = 20;
            this.SaveCommandBtn.ActiveFillColor = System.Drawing.Color.DarkTurquoise;
            this.SaveCommandBtn.ActiveForecolor = System.Drawing.Color.White;
            this.SaveCommandBtn.ActiveLineColor = System.Drawing.Color.DarkTurquoise;
            this.SaveCommandBtn.BackColor = System.Drawing.Color.SlateGray;
            this.SaveCommandBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveCommandBtn.BackgroundImage")));
            this.SaveCommandBtn.ButtonText = "Select Folder";
            this.SaveCommandBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveCommandBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveCommandBtn.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.SaveCommandBtn.IdleBorderThickness = 1;
            this.SaveCommandBtn.IdleCornerRadius = 35;
            this.SaveCommandBtn.IdleFillColor = System.Drawing.Color.White;
            this.SaveCommandBtn.IdleForecolor = System.Drawing.Color.DarkTurquoise;
            this.SaveCommandBtn.IdleLineColor = System.Drawing.Color.DarkTurquoise;
            this.SaveCommandBtn.Location = new System.Drawing.Point(48, 138);
            this.SaveCommandBtn.Margin = new System.Windows.Forms.Padding(5);
            this.SaveCommandBtn.Name = "SaveCommandBtn";
            this.SaveCommandBtn.Size = new System.Drawing.Size(279, 48);
            this.SaveCommandBtn.TabIndex = 8;
            this.SaveCommandBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveCommandBtn.Click += new System.EventHandler(this.SaveCommandBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 271);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(375, 229);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DefaultCommDGV);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(367, 203);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Default Commands";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DefaultCommDGV
            // 
            this.DefaultCommDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DefaultCommDGV.BackgroundColor = System.Drawing.Color.White;
            this.DefaultCommDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DefaultCommDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DefaultCommDGV.Location = new System.Drawing.Point(3, 3);
            this.DefaultCommDGV.Name = "DefaultCommDGV";
            this.DefaultCommDGV.RowHeadersVisible = false;
            this.DefaultCommDGV.Size = new System.Drawing.Size(361, 197);
            this.DefaultCommDGV.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.AddCommDGV);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(367, 203);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Added Commands";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // AddCommDGV
            // 
            this.AddCommDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AddCommDGV.BackgroundColor = System.Drawing.Color.White;
            this.AddCommDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddCommDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddCommDGV.Location = new System.Drawing.Point(3, 3);
            this.AddCommDGV.Name = "AddCommDGV";
            this.AddCommDGV.RowHeadersVisible = false;
            this.AddCommDGV.Size = new System.Drawing.Size(361, 197);
            this.AddCommDGV.TabIndex = 1;
            this.AddCommDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddCommDGV_CellClick);
            // 
            // DeleteCommandBtn
            // 
            this.DeleteCommandBtn.ActiveBorderThickness = 1;
            this.DeleteCommandBtn.ActiveCornerRadius = 20;
            this.DeleteCommandBtn.ActiveFillColor = System.Drawing.Color.Crimson;
            this.DeleteCommandBtn.ActiveForecolor = System.Drawing.Color.White;
            this.DeleteCommandBtn.ActiveLineColor = System.Drawing.Color.Crimson;
            this.DeleteCommandBtn.BackColor = System.Drawing.Color.SlateGray;
            this.DeleteCommandBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteCommandBtn.BackgroundImage")));
            this.DeleteCommandBtn.ButtonText = "Delete Command";
            this.DeleteCommandBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteCommandBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCommandBtn.ForeColor = System.Drawing.Color.Crimson;
            this.DeleteCommandBtn.IdleBorderThickness = 1;
            this.DeleteCommandBtn.IdleCornerRadius = 35;
            this.DeleteCommandBtn.IdleFillColor = System.Drawing.Color.White;
            this.DeleteCommandBtn.IdleForecolor = System.Drawing.Color.Crimson;
            this.DeleteCommandBtn.IdleLineColor = System.Drawing.Color.Crimson;
            this.DeleteCommandBtn.Location = new System.Drawing.Point(48, 196);
            this.DeleteCommandBtn.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteCommandBtn.Name = "DeleteCommandBtn";
            this.DeleteCommandBtn.Size = new System.Drawing.Size(279, 48);
            this.DeleteCommandBtn.TabIndex = 8;
            this.DeleteCommandBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteCommandBtn.Click += new System.EventHandler(this.DeleteCommandBtn_Click);
            // 
            // OptionsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(375, 500);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.DeleteCommandBtn);
            this.Controls.Add(this.SaveCommandBtn);
            this.Controls.Add(this.CommandTB);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OptionsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OptionsPage";
            this.Load += new System.EventHandler(this.OptionsPage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DefaultCommDGV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddCommDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton HomeBtn;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CommandTB;
        private Bunifu.Framework.UI.BunifuThinButton2 SaveCommandBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView AddCommDGV;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteCommandBtn;
        private System.Windows.Forms.DataGridView DefaultCommDGV;
    }
}