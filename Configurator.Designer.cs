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
            this.ChordVariantGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // KeySelectBox
            // 
            this.KeySelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KeySelectBox.FormattingEnabled = true;
            this.KeySelectBox.Location = new System.Drawing.Point(179, 15);
            this.KeySelectBox.Name = "KeySelectBox";
            this.KeySelectBox.Size = new System.Drawing.Size(258, 28);
            this.KeySelectBox.TabIndex = 0;
            // 
            // ChordVariantGroup
            // 
            this.ChordVariantGroup.Controls.Add(this.ChordSixCheckbox);
            this.ChordVariantGroup.Controls.Add(this.ChordDimCheckbox);
            this.ChordVariantGroup.Controls.Add(this.ChordFlatCheckbox);
            this.ChordVariantGroup.Controls.Add(this.ChordSevenCheckbox);
            this.ChordVariantGroup.Controls.Add(this.ChordTwoCheckbox);
            this.ChordVariantGroup.Controls.Add(this.ChordSusCheckbox);
            this.ChordVariantGroup.Controls.Add(this.ChordRegularCheckbox);
            this.ChordVariantGroup.Location = new System.Drawing.Point(23, 133);
            this.ChordVariantGroup.Name = "ChordVariantGroup";
            this.ChordVariantGroup.Size = new System.Drawing.Size(291, 400);
            this.ChordVariantGroup.TabIndex = 1;
            this.ChordVariantGroup.TabStop = false;
            this.ChordVariantGroup.Text = "Chord variants";
            // 
            // ChordSixCheckbox
            // 
            this.ChordSixCheckbox.Location = new System.Drawing.Point(20, 319);
            this.ChordSixCheckbox.Name = "ChordSixCheckbox";
            this.ChordSixCheckbox.Size = new System.Drawing.Size(191, 43);
            this.ChordSixCheckbox.TabIndex = 6;
            this.ChordSixCheckbox.Text = "6 / add6";
            this.ChordSixCheckbox.UseVisualStyleBackColor = true;
            // 
            // ChordDimCheckbox
            // 
            this.ChordDimCheckbox.Location = new System.Drawing.Point(20, 270);
            this.ChordDimCheckbox.Name = "ChordDimCheckbox";
            this.ChordDimCheckbox.Size = new System.Drawing.Size(191, 43);
            this.ChordDimCheckbox.TabIndex = 5;
            this.ChordDimCheckbox.Text = "dim / aug";
            this.ChordDimCheckbox.UseVisualStyleBackColor = true;
            // 
            // ChordFlatCheckbox
            // 
            this.ChordFlatCheckbox.Location = new System.Drawing.Point(20, 221);
            this.ChordFlatCheckbox.Name = "ChordFlatCheckbox";
            this.ChordFlatCheckbox.Size = new System.Drawing.Size(191, 43);
            this.ChordFlatCheckbox.TabIndex = 4;
            this.ChordFlatCheckbox.Text = "b6 / b7";
            this.ChordFlatCheckbox.UseVisualStyleBackColor = true;
            // 
            // ChordSevenCheckbox
            // 
            this.ChordSevenCheckbox.Location = new System.Drawing.Point(20, 172);
            this.ChordSevenCheckbox.Name = "ChordSevenCheckbox";
            this.ChordSevenCheckbox.Size = new System.Drawing.Size(191, 43);
            this.ChordSevenCheckbox.TabIndex = 3;
            this.ChordSevenCheckbox.Text = "7th";
            this.ChordSevenCheckbox.UseVisualStyleBackColor = true;
            // 
            // ChordTwoCheckbox
            // 
            this.ChordTwoCheckbox.Location = new System.Drawing.Point(20, 123);
            this.ChordTwoCheckbox.Name = "ChordTwoCheckbox";
            this.ChordTwoCheckbox.Size = new System.Drawing.Size(191, 43);
            this.ChordTwoCheckbox.TabIndex = 2;
            this.ChordTwoCheckbox.Text = "2 / add2";
            this.ChordTwoCheckbox.UseVisualStyleBackColor = true;
            // 
            // ChordSusCheckbox
            // 
            this.ChordSusCheckbox.Location = new System.Drawing.Point(20, 74);
            this.ChordSusCheckbox.Name = "ChordSusCheckbox";
            this.ChordSusCheckbox.Size = new System.Drawing.Size(191, 43);
            this.ChordSusCheckbox.TabIndex = 1;
            this.ChordSusCheckbox.Text = "sus / add4";
            this.ChordSusCheckbox.UseVisualStyleBackColor = true;
            // 
            // ChordRegularCheckbox
            // 
            this.ChordRegularCheckbox.Location = new System.Drawing.Point(20, 25);
            this.ChordRegularCheckbox.Name = "ChordRegularCheckbox";
            this.ChordRegularCheckbox.Size = new System.Drawing.Size(191, 43);
            this.ChordRegularCheckbox.TabIndex = 0;
            this.ChordRegularCheckbox.Text = "Regular";
            this.ChordRegularCheckbox.UseVisualStyleBackColor = true;
            // 
            // KeyLabel
            // 
            this.KeyLabel.Location = new System.Drawing.Point(12, 9);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(135, 28);
            this.KeyLabel.TabIndex = 2;
            this.KeyLabel.Text = "Key";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(23, 555);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(359, 77);
            this.ConfirmButton.TabIndex = 3;
            this.ConfirmButton.Text = "Apply";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            // 
            // ChordNumberLabel
            // 
            this.ChordNumberLabel.Location = new System.Drawing.Point(12, 60);
            this.ChordNumberLabel.Name = "ChordNumberLabel";
            this.ChordNumberLabel.Size = new System.Drawing.Size(166, 28);
            this.ChordNumberLabel.TabIndex = 4;
            this.ChordNumberLabel.Text = "Chord representation";
            // 
            // ChordNumberSelectBox
            // 
            this.ChordNumberSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChordNumberSelectBox.FormattingEnabled = true;
            this.ChordNumberSelectBox.Location = new System.Drawing.Point(184, 60);
            this.ChordNumberSelectBox.Name = "ChordNumberSelectBox";
            this.ChordNumberSelectBox.Size = new System.Drawing.Size(258, 28);
            this.ChordNumberSelectBox.TabIndex = 5;
            // 
            // Configurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 664);
            this.Controls.Add(this.ChordNumberSelectBox);
            this.Controls.Add(this.ChordNumberLabel);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.ChordVariantGroup);
            this.Controls.Add(this.KeySelectBox);
            this.Name = "Configurator";
            this.Text = "Configurator";
            this.ChordVariantGroup.ResumeLayout(false);
            this.ResumeLayout(false);
        }

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