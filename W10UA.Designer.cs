namespace cripsy_winupd
{
    partial class W10UA
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(W10UA));
            this.iconLoading = new System.Windows.Forms.PictureBox();
            this.updatesLabel = new System.Windows.Forms.Label();
            this.complete = new System.Windows.Forms.Label();
            this.dont = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // iconLoading
            // 
            this.iconLoading.Image = ((System.Drawing.Image)(resources.GetObject("iconLoading.Image")));
            this.iconLoading.Location = new System.Drawing.Point(375, 104);
            this.iconLoading.Name = "iconLoading";
            this.iconLoading.Size = new System.Drawing.Size(64, 64);
            this.iconLoading.TabIndex = 0;
            this.iconLoading.TabStop = false;
            // 
            // updatesLabel
            // 
            this.updatesLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updatesLabel.AutoSize = true;
            this.updatesLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updatesLabel.ForeColor = System.Drawing.Color.White;
            this.updatesLabel.Location = new System.Drawing.Point(227, 253);
            this.updatesLabel.Name = "updatesLabel";
            this.updatesLabel.Size = new System.Drawing.Size(205, 30);
            this.updatesLabel.TabIndex = 1;
            this.updatesLabel.Text = "Working on updates ";
            this.updatesLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // complete
            // 
            this.complete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.complete.AutoSize = true;
            this.complete.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.complete.ForeColor = System.Drawing.Color.White;
            this.complete.Location = new System.Drawing.Point(422, 253);
            this.complete.Name = "complete";
            this.complete.Size = new System.Drawing.Size(138, 30);
            this.complete.TabIndex = 2;
            this.complete.Text = "0% complete.";
            this.complete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dont
            // 
            this.dont.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dont.AutoSize = true;
            this.dont.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dont.ForeColor = System.Drawing.Color.White;
            this.dont.Location = new System.Drawing.Point(188, 283);
            this.dont.Name = "dont";
            this.dont.Size = new System.Drawing.Size(419, 30);
            this.dont.TabIndex = 3;
            this.dont.Text = "Don\'t turn off your PC. This will take a while.";
            this.dont.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(229, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your PC will restart several times.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // W10UA
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(89)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dont);
            this.Controls.Add(this.complete);
            this.Controls.Add(this.updatesLabel);
            this.Controls.Add(this.iconLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "W10UA";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows 10 Update Assistant";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.iconLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox iconLoading;
        private Label updatesLabel;
        private Label complete;
        private Label dont;
        private Label label1;
    }
}