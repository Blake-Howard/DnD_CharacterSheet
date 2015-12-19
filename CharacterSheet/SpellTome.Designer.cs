namespace CharacterSheet
{
    partial class SpellTome
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
            this.cmbTomeSelect = new System.Windows.Forms.ComboBox();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.txtSpellDescription = new System.Windows.Forms.TextBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblSchool = new System.Windows.Forms.Label();
            this.lblVComp = new System.Windows.Forms.Label();
            this.lblCastingTime = new System.Windows.Forms.Label();
            this.lblRitual = new System.Windows.Forms.Label();
            this.lblSComp = new System.Windows.Forms.Label();
            this.lblMComp = new System.Windows.Forms.Label();
            this.lblConcentration = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbTomeSelect
            // 
            this.cmbTomeSelect.FormattingEnabled = true;
            this.cmbTomeSelect.Location = new System.Drawing.Point(12, 12);
            this.cmbTomeSelect.Name = "cmbTomeSelect";
            this.cmbTomeSelect.Size = new System.Drawing.Size(250, 21);
            this.cmbTomeSelect.TabIndex = 0;
            this.cmbTomeSelect.Text = "Choose a Spell";
            this.cmbTomeSelect.SelectedIndexChanged += new System.EventHandler(this.cmbTomeSelect_SelectedIndexChanged);
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.Location = new System.Drawing.Point(320, 38);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(32, 13);
            this.lblPageNumber.TabIndex = 2;
            this.lblPageNumber.Text = "Page";
            // 
            // txtSpellDescription
            // 
            this.txtSpellDescription.Location = new System.Drawing.Point(12, 39);
            this.txtSpellDescription.Multiline = true;
            this.txtSpellDescription.Name = "txtSpellDescription";
            this.txtSpellDescription.ReadOnly = true;
            this.txtSpellDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSpellDescription.Size = new System.Drawing.Size(302, 351);
            this.txtSpellDescription.TabIndex = 3;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(320, 58);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(33, 13);
            this.lblLevel.TabIndex = 4;
            this.lblLevel.Text = "Level";
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Location = new System.Drawing.Point(320, 78);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(40, 13);
            this.lblSchool.TabIndex = 5;
            this.lblSchool.Text = "School";
            // 
            // lblVComp
            // 
            this.lblVComp.AutoSize = true;
            this.lblVComp.Location = new System.Drawing.Point(320, 138);
            this.lblVComp.Name = "lblVComp";
            this.lblVComp.Size = new System.Drawing.Size(14, 13);
            this.lblVComp.TabIndex = 6;
            this.lblVComp.Text = "V";
            // 
            // lblCastingTime
            // 
            this.lblCastingTime.AutoSize = true;
            this.lblCastingTime.Location = new System.Drawing.Point(320, 98);
            this.lblCastingTime.Name = "lblCastingTime";
            this.lblCastingTime.Size = new System.Drawing.Size(68, 13);
            this.lblCastingTime.TabIndex = 7;
            this.lblCastingTime.Text = "Casting Time";
            // 
            // lblRitual
            // 
            this.lblRitual.AutoSize = true;
            this.lblRitual.Location = new System.Drawing.Point(320, 118);
            this.lblRitual.Name = "lblRitual";
            this.lblRitual.Size = new System.Drawing.Size(34, 13);
            this.lblRitual.TabIndex = 8;
            this.lblRitual.Text = "Ritual";
            // 
            // lblSComp
            // 
            this.lblSComp.AutoSize = true;
            this.lblSComp.Location = new System.Drawing.Point(320, 158);
            this.lblSComp.Name = "lblSComp";
            this.lblSComp.Size = new System.Drawing.Size(14, 13);
            this.lblSComp.TabIndex = 9;
            this.lblSComp.Text = "S";
            // 
            // lblMComp
            // 
            this.lblMComp.AutoSize = true;
            this.lblMComp.Location = new System.Drawing.Point(320, 178);
            this.lblMComp.Name = "lblMComp";
            this.lblMComp.Size = new System.Drawing.Size(16, 13);
            this.lblMComp.TabIndex = 10;
            this.lblMComp.Text = "M";
            // 
            // lblConcentration
            // 
            this.lblConcentration.AutoSize = true;
            this.lblConcentration.Location = new System.Drawing.Point(320, 198);
            this.lblConcentration.Name = "lblConcentration";
            this.lblConcentration.Size = new System.Drawing.Size(73, 13);
            this.lblConcentration.TabIndex = 11;
            this.lblConcentration.Text = "Concentration";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(323, 358);
            this.btnClose.MaximumSize = new System.Drawing.Size(98, 32);
            this.btnClose.MinimumSize = new System.Drawing.Size(98, 32);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 32);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close Tome";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SpellTome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 402);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblConcentration);
            this.Controls.Add(this.lblMComp);
            this.Controls.Add(this.lblSComp);
            this.Controls.Add(this.lblRitual);
            this.Controls.Add(this.lblCastingTime);
            this.Controls.Add(this.lblVComp);
            this.Controls.Add(this.lblSchool);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.txtSpellDescription);
            this.Controls.Add(this.lblPageNumber);
            this.Controls.Add(this.cmbTomeSelect);
            this.MaximumSize = new System.Drawing.Size(480, 441);
            this.MinimumSize = new System.Drawing.Size(480, 441);
            this.Name = "SpellTome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SpellTome";
            this.Load += new System.EventHandler(this.SpellTome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTomeSelect;
        private System.Windows.Forms.Label lblPageNumber;
        private System.Windows.Forms.TextBox txtSpellDescription;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.Label lblVComp;
        private System.Windows.Forms.Label lblCastingTime;
        private System.Windows.Forms.Label lblRitual;
        private System.Windows.Forms.Label lblSComp;
        private System.Windows.Forms.Label lblMComp;
        private System.Windows.Forms.Label lblConcentration;
        private System.Windows.Forms.Button btnClose;
    }
}