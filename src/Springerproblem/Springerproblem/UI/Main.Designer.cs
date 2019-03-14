namespace Springerproblem
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numericUpDownN = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startFeldBx = new System.Windows.Forms.TextBox();
            this.goBtn = new System.Windows.Forms.Button();
            this.brettPanel = new System.Windows.Forms.Panel();
            this.brettGrpBx = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).BeginInit();
            this.brettGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDownN
            // 
            this.numericUpDownN.Location = new System.Drawing.Point(140, 12);
            this.numericUpDownN.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownN.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownN.Name = "numericUpDownN";
            this.numericUpDownN.Size = new System.Drawing.Size(63, 24);
            this.numericUpDownN.TabIndex = 0;
            this.numericUpDownN.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownN.ValueChanged += new System.EventHandler(this.numericUpDownN_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "_________________________________________________________________________________" +
    "_______\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "n =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Startfeld:";
            // 
            // startFeldBx
            // 
            this.startFeldBx.Location = new System.Drawing.Point(285, 12);
            this.startFeldBx.MaxLength = 2;
            this.startFeldBx.Name = "startFeldBx";
            this.startFeldBx.Size = new System.Drawing.Size(52, 24);
            this.startFeldBx.TabIndex = 4;
            this.startFeldBx.Text = "a1";
            this.startFeldBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // goBtn
            // 
            this.goBtn.Location = new System.Drawing.Point(359, 12);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(198, 24);
            this.goBtn.TabIndex = 5;
            this.goBtn.Text = "Let\'s go!";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // brettPanel
            // 
            this.brettPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.brettPanel.Location = new System.Drawing.Point(11, 23);
            this.brettPanel.Name = "brettPanel";
            this.brettPanel.Size = new System.Drawing.Size(626, 526);
            this.brettPanel.TabIndex = 6;
            // 
            // brettGrpBx
            // 
            this.brettGrpBx.Controls.Add(this.brettPanel);
            this.brettGrpBx.Location = new System.Drawing.Point(12, 59);
            this.brettGrpBx.Name = "brettGrpBx";
            this.brettGrpBx.Size = new System.Drawing.Size(643, 555);
            this.brettGrpBx.TabIndex = 0;
            this.brettGrpBx.TabStop = false;
            this.brettGrpBx.Text = "Schachbrett";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 626);
            this.Controls.Add(this.brettGrpBx);
            this.Controls.Add(this.goBtn);
            this.Controls.Add(this.startFeldBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownN);
            this.Font = new System.Drawing.Font("Open Sans Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Springerproblem GUI - ethicalc0der | ";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).EndInit();
            this.brettGrpBx.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox startFeldBx;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.Panel brettPanel;
        private System.Windows.Forms.GroupBox brettGrpBx;
    }
}

