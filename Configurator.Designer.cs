using System.ComponentModel;

namespace PianoTeacher
{
    partial class Configurator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.KeySelectBox = new System.Windows.Forms.ComboBox();
            this.ChordVariantGroup = new System.Windows.Forms.GroupBox();
            this.ChordInversionCheckbox = new System.Windows.Forms.CheckBox();
            this.ChordSixCheckbox = new System.Windows.Forms.CheckBox();
            this.ChordDimCheckbox = new System.Windows.Forms.CheckBox();
            this.ChordFlatCheckbox = new System.Windows.Forms.CheckBox();
            this.ChordSevenCheckbox = new System.Windows.Forms.CheckBox();
            this.ChordTwoCheckbox = new System.Windows.Forms.CheckBox();
            this.ChordSusCheckbox = new System.Windows.Forms.CheckBox();
            this.ChordRegularCheckbox = new System.Windows.Forms.CheckBox();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.ChordNumberLabel = new System.Windows.Forms.Label();
            this.ChordNumberSelectBox = new System.Windows.Forms.ComboBox();
            this.ChordGroupBox = new System.Windows.Forms.GroupBox();
            this.ChordVariantGroup.SuspendLayout();
            this.ChordGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // KeySelectBox
            // 
            this.KeySelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KeySelectBox.FormattingEnabled = true;
            this.KeySelectBox.Location = new System.Drawing.Point(131, 19);
            this.KeySelectBox.Name = "KeySelectBox";
            this.KeySelectBox.Size = new System.Drawing.Size(182, 28);
            this.KeySelectBox.TabIndex = 0;
            // 
            // ChordVariantGroup
            // 
            this.ChordVariantGroup.Controls.Add(this.ChordInversionCheckbox);
            this.ChordVariantGroup.Controls.Add(this.ChordSixCheckbox);
            this.ChordVariantGroup.Controls.Add(this.ChordDimCheckbox);
            this.ChordVariantGroup.Controls.Add(this.ChordFlatCheckbox);
            this.ChordVariantGroup.Controls.Add(this.ChordSevenCheckbox);
            this.ChordVariantGroup.Controls.Add(this.ChordTwoCheckbox);
            this.ChordVariantGroup.Controls.Add(this.ChordSusCheckbox);
            this.ChordVariantGroup.Controls.Add(this.ChordRegularCheckbox);
            this.ChordVariantGroup.Location = new System.Drawing.Point(6, 89);
            this.ChordVariantGroup.Name = "ChordVariantGroup";
            this.ChordVariantGroup.Size = new System.Drawing.Size(307, 273);
            this.ChordVariantGroup.TabIndex = 1;
            this.ChordVariantGroup.TabStop = false;
            this.ChordVariantGroup.Text = "Chord variants";
            // 
            // ChordInversionCheckbox
            // 
            this.ChordInversionCheckbox.AutoSize = true;
            this.ChordInversionCheckbox.Location = new System.Drawing.Point(6, 235);
            this.ChordInversionCheckbox.Name = "ChordInversionCheckbox";
            this.ChordInversionCheckbox.Size = new System.Drawing.Size(107, 24);
            this.ChordInversionCheckbox.TabIndex = 7;
            this.ChordInversionCheckbox.Text = "Inversions";
            this.ChordInversionCheckbox.UseVisualStyleBackColor = true;
            // 
            // ChordSixCheckbox
            // 
            this.ChordSixCheckbox.AutoSize = true;
            this.ChordSixCheckbox.Location = new System.Drawing.Point(6, 205);
            this.ChordSixCheckbox.Name = "ChordSixCheckbox";
            this.ChordSixCheckbox.Size = new System.Drawing.Size(92, 24);
            this.ChordSixCheckbox.TabIndex = 6;
            this.ChordSixCheckbox.Text = "6 / add6";
            this.ChordSixCheckbox.UseVisualStyleBackColor = true;
            // 
            // ChordDimCheckbox
            // 
            this.ChordDimCheckbox.AutoSize = true;
            this.ChordDimCheckbox.Location = new System.Drawing.Point(6, 175);
            this.ChordDimCheckbox.Name = "ChordDimCheckbox";
            this.ChordDimCheckbox.Size = new System.Drawing.Size(99, 24);
            this.ChordDimCheckbox.TabIndex = 5;
            this.ChordDimCheckbox.Text = "dim / aug";
            this.ChordDimCheckbox.UseVisualStyleBackColor = true;
            // 
            // ChordFlatCheckbox
            // 
            this.ChordFlatCheckbox.AutoSize = true;
            this.ChordFlatCheckbox.Location = new System.Drawing.Point(6, 145);
            this.ChordFlatCheckbox.Name = "ChordFlatCheckbox";
            this.ChordFlatCheckbox.Size = new System.Drawing.Size(83, 24);
            this.ChordFlatCheckbox.TabIndex = 4;
            this.ChordFlatCheckbox.Text = "b6 / b7";
            this.ChordFlatCheckbox.UseVisualStyleBackColor = true;
            // 
            // ChordSevenCheckbox
            // 
            this.ChordSevenCheckbox.AutoSize = true;
            this.ChordSevenCheckbox.Location = new System.Drawing.Point(6, 115);
            this.ChordSevenCheckbox.Name = "ChordSevenCheckbox";
            this.ChordSevenCheckbox.Size = new System.Drawing.Size(58, 24);
            this.ChordSevenCheckbox.TabIndex = 3;
            this.ChordSevenCheckbox.Text = "7th";
            this.ChordSevenCheckbox.UseVisualStyleBackColor = true;
            // 
            // ChordTwoCheckbox
            // 
            this.ChordTwoCheckbox.AutoSize = true;
            this.ChordTwoCheckbox.Location = new System.Drawing.Point(6, 85);
            this.ChordTwoCheckbox.Name = "ChordTwoCheckbox";
            this.ChordTwoCheckbox.Size = new System.Drawing.Size(92, 24);
            this.ChordTwoCheckbox.TabIndex = 2;
            this.ChordTwoCheckbox.Text = "2 / add2";
            this.ChordTwoCheckbox.UseVisualStyleBackColor = true;
            // 
            // ChordSusCheckbox
            // 
            this.ChordSusCheckbox.AutoSize = true;
            this.ChordSusCheckbox.Location = new System.Drawing.Point(6, 55);
            this.ChordSusCheckbox.Name = "ChordSusCheckbox";
            this.ChordSusCheckbox.Size = new System.Drawing.Size(108, 24);
            this.ChordSusCheckbox.TabIndex = 1;
            this.ChordSusCheckbox.Text = "sus / add4";
            this.ChordSusCheckbox.UseVisualStyleBackColor = true;
            // 
            // ChordRegularCheckbox
            // 
            this.ChordRegularCheckbox.AutoSize = true;
            this.ChordRegularCheckbox.Location = new System.Drawing.Point(6, 25);
            this.ChordRegularCheckbox.Name = "ChordRegularCheckbox";
            this.ChordRegularCheckbox.Size = new System.Drawing.Size(91, 24);
            this.ChordRegularCheckbox.TabIndex = 0;
            this.ChordRegularCheckbox.Text = "Regular";
            this.ChordRegularCheckbox.UseVisualStyleBackColor = true;
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(6, 22);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(35, 20);
            this.KeyLabel.TabIndex = 2;
            this.KeyLabel.Text = "Key";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ConfirmButton.Location = new System.Drawing.Point(12, 396);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(807, 49);
            this.ConfirmButton.TabIndex = 3;
            this.ConfirmButton.Text = "Apply";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButtonClick);
            // 
            // ChordNumberLabel
            // 
            this.ChordNumberLabel.AutoSize = true;
            this.ChordNumberLabel.Location = new System.Drawing.Point(6, 58);
            this.ChordNumberLabel.Name = "ChordNumberLabel";
            this.ChordNumberLabel.Size = new System.Drawing.Size(119, 20);
            this.ChordNumberLabel.TabIndex = 4;
            this.ChordNumberLabel.Text = "Representation";
            // 
            // ChordNumberSelectBox
            // 
            this.ChordNumberSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChordNumberSelectBox.FormattingEnabled = true;
            this.ChordNumberSelectBox.Items.AddRange(new object[] {"Absolute", "Relative"});
            this.ChordNumberSelectBox.Location = new System.Drawing.Point(131, 55);
            this.ChordNumberSelectBox.Name = "ChordNumberSelectBox";
            this.ChordNumberSelectBox.Size = new System.Drawing.Size(182, 28);
            this.ChordNumberSelectBox.TabIndex = 5;
            // 
            // ChordGroupBox
            // 
            this.ChordGroupBox.Controls.Add(this.KeyLabel);
            this.ChordGroupBox.Controls.Add(this.ChordNumberSelectBox);
            this.ChordGroupBox.Controls.Add(this.ChordVariantGroup);
            this.ChordGroupBox.Controls.Add(this.KeySelectBox);
            this.ChordGroupBox.Controls.Add(this.ChordNumberLabel);
            this.ChordGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ChordGroupBox.Name = "ChordGroupBox";
            this.ChordGroupBox.Size = new System.Drawing.Size(319, 368);
            this.ChordGroupBox.TabIndex = 6;
            this.ChordGroupBox.TabStop = false;
            this.ChordGroupBox.Text = "Chord exercise";
            // 
            // Configurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 457);
            this.Controls.Add(this.ChordGroupBox);
            this.Controls.Add(this.ConfirmButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Configurator";
            this.Text = "Configurator";
            this.ChordVariantGroup.ResumeLayout(false);
            this.ChordVariantGroup.PerformLayout();
            this.ChordGroupBox.ResumeLayout(false);
            this.ChordGroupBox.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox ChordGroupBox;
        private System.Windows.Forms.CheckBox ChordInversionCheckbox;

        private System.Windows.Forms.ComboBox ChordNumberSelectBox;

        private System.Windows.Forms.Label ChordNumberLabel;
        private System.Windows.Forms.CheckBox ChordSixCheckbox;

        private System.Windows.Forms.CheckBox ChordDimCheckbox;

        private System.Windows.Forms.CheckBox ChordFlatCheckbox;

        private System.Windows.Forms.CheckBox ChordSevenCheckbox;

        private System.Windows.Forms.CheckBox ChordTwoCheckbox;
        private System.Windows.Forms.CheckBox ChordSusCheckbox;
        private System.Windows.Forms.Button ConfirmButton;

        private System.Windows.Forms.CheckBox ChordRegularCheckbox;
        private System.Windows.Forms.GroupBox ChordVariantGroup;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.ComboBox KeySelectBox;

        #endregion
    }
}