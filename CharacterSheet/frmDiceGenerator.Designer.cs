namespace CharacterSheet
{
    partial class frmDiceGenerator
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
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblD4 = new System.Windows.Forms.Label();
            this.txtd4 = new System.Windows.Forms.TextBox();
            this.txtd6 = new System.Windows.Forms.TextBox();
            this.txtd8 = new System.Windows.Forms.TextBox();
            this.txtd12 = new System.Windows.Forms.TextBox();
            this.txtd20 = new System.Windows.Forms.TextBox();
            this.txtd100 = new System.Windows.Forms.TextBox();
            this.txtd10 = new System.Windows.Forms.TextBox();
            this.lblD6 = new System.Windows.Forms.Label();
            this.lblD10 = new System.Windows.Forms.Label();
            this.lblD8 = new System.Windows.Forms.Label();
            this.lblD12 = new System.Windows.Forms.Label();
            this.lblD100 = new System.Windows.Forms.Label();
            this.lblD20 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(85, 12);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(83, 22);
            this.btnRoll.TabIndex = 0;
            this.btnRoll.Text = "Roll!";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblD4
            // 
            this.lblD4.AutoSize = true;
            this.lblD4.Location = new System.Drawing.Point(45, 15);
            this.lblD4.Name = "lblD4";
            this.lblD4.Size = new System.Drawing.Size(22, 13);
            this.lblD4.TabIndex = 1;
            this.lblD4.Text = "d 4";
            // 
            // txtd4
            // 
            this.txtd4.Location = new System.Drawing.Point(12, 12);
            this.txtd4.Name = "txtd4";
            this.txtd4.Size = new System.Drawing.Size(27, 20);
            this.txtd4.TabIndex = 2;
            // 
            // txtd6
            // 
            this.txtd6.Location = new System.Drawing.Point(12, 38);
            this.txtd6.Name = "txtd6";
            this.txtd6.Size = new System.Drawing.Size(27, 20);
            this.txtd6.TabIndex = 3;
            // 
            // txtd8
            // 
            this.txtd8.Location = new System.Drawing.Point(12, 64);
            this.txtd8.Name = "txtd8";
            this.txtd8.Size = new System.Drawing.Size(27, 20);
            this.txtd8.TabIndex = 4;
            // 
            // txtd12
            // 
            this.txtd12.Location = new System.Drawing.Point(12, 116);
            this.txtd12.Name = "txtd12";
            this.txtd12.Size = new System.Drawing.Size(27, 20);
            this.txtd12.TabIndex = 5;
            // 
            // txtd20
            // 
            this.txtd20.Location = new System.Drawing.Point(12, 142);
            this.txtd20.Name = "txtd20";
            this.txtd20.Size = new System.Drawing.Size(27, 20);
            this.txtd20.TabIndex = 6;
            // 
            // txtd100
            // 
            this.txtd100.Location = new System.Drawing.Point(12, 168);
            this.txtd100.Name = "txtd100";
            this.txtd100.Size = new System.Drawing.Size(27, 20);
            this.txtd100.TabIndex = 7;
            // 
            // txtd10
            // 
            this.txtd10.Location = new System.Drawing.Point(12, 90);
            this.txtd10.Name = "txtd10";
            this.txtd10.Size = new System.Drawing.Size(27, 20);
            this.txtd10.TabIndex = 8;
            // 
            // lblD6
            // 
            this.lblD6.AutoSize = true;
            this.lblD6.Location = new System.Drawing.Point(45, 41);
            this.lblD6.Name = "lblD6";
            this.lblD6.Size = new System.Drawing.Size(22, 13);
            this.lblD6.TabIndex = 9;
            this.lblD6.Text = "d 6";
            // 
            // lblD10
            // 
            this.lblD10.AutoSize = true;
            this.lblD10.Location = new System.Drawing.Point(45, 93);
            this.lblD10.Name = "lblD10";
            this.lblD10.Size = new System.Drawing.Size(28, 13);
            this.lblD10.TabIndex = 10;
            this.lblD10.Text = "d 10";
            // 
            // lblD8
            // 
            this.lblD8.AutoSize = true;
            this.lblD8.Location = new System.Drawing.Point(45, 67);
            this.lblD8.Name = "lblD8";
            this.lblD8.Size = new System.Drawing.Size(22, 13);
            this.lblD8.TabIndex = 11;
            this.lblD8.Text = "d 8";
            // 
            // lblD12
            // 
            this.lblD12.AutoSize = true;
            this.lblD12.Location = new System.Drawing.Point(45, 119);
            this.lblD12.Name = "lblD12";
            this.lblD12.Size = new System.Drawing.Size(28, 13);
            this.lblD12.TabIndex = 12;
            this.lblD12.Text = "d 12";
            // 
            // lblD100
            // 
            this.lblD100.AutoSize = true;
            this.lblD100.Location = new System.Drawing.Point(45, 171);
            this.lblD100.Name = "lblD100";
            this.lblD100.Size = new System.Drawing.Size(34, 13);
            this.lblD100.TabIndex = 13;
            this.lblD100.Text = "d 100";
            // 
            // lblD20
            // 
            this.lblD20.AutoSize = true;
            this.lblD20.Location = new System.Drawing.Point(45, 145);
            this.lblD20.Name = "lblD20";
            this.lblD20.Size = new System.Drawing.Size(28, 13);
            this.lblD20.TabIndex = 14;
            this.lblD20.Text = "d 20";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(82, 71);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 13);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total :";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(85, 41);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 22);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmDiceGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 199);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblD20);
            this.Controls.Add(this.lblD100);
            this.Controls.Add(this.lblD12);
            this.Controls.Add(this.lblD8);
            this.Controls.Add(this.lblD10);
            this.Controls.Add(this.lblD6);
            this.Controls.Add(this.txtd10);
            this.Controls.Add(this.txtd100);
            this.Controls.Add(this.txtd20);
            this.Controls.Add(this.txtd12);
            this.Controls.Add(this.txtd8);
            this.Controls.Add(this.txtd6);
            this.Controls.Add(this.txtd4);
            this.Controls.Add(this.lblD4);
            this.Controls.Add(this.btnRoll);
            this.MaximumSize = new System.Drawing.Size(189, 238);
            this.MinimumSize = new System.Drawing.Size(189, 238);
            this.Name = "frmDiceGenerator";
            this.Text = "Dice Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label lblD4;
        private System.Windows.Forms.TextBox txtd4;
        private System.Windows.Forms.TextBox txtd6;
        private System.Windows.Forms.TextBox txtd8;
        private System.Windows.Forms.TextBox txtd12;
        private System.Windows.Forms.TextBox txtd20;
        private System.Windows.Forms.TextBox txtd100;
        private System.Windows.Forms.TextBox txtd10;
        private System.Windows.Forms.Label lblD6;
        private System.Windows.Forms.Label lblD10;
        private System.Windows.Forms.Label lblD8;
        private System.Windows.Forms.Label lblD12;
        private System.Windows.Forms.Label lblD100;
        private System.Windows.Forms.Label lblD20;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnClose;
    }
}