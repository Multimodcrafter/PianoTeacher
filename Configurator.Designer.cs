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
            this.VariantsList = new System.Windows.Forms.ListBox();
            this.ChordInversionCheckbox = new System.Windows.Forms.CheckBox();
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
            this.ChordVariantGroup.Controls.Add(this.VariantsList);
            this.ChordVariantGroup.Controls.Add(this.ChordInversionCheckbox);
            this.ChordVariantGroup.Location = new System.Drawing.Point(6, 89);
            this.ChordVariantGroup.Name = "ChordVariantGroup";
            this.ChordVariantGroup.Size = new System.Drawing.Size(307, 273);
            this.ChordVariantGroup.TabIndex = 1;
            this.ChordVariantGroup.TabStop = false;
            this.ChordVariantGroup.Text = "Chord variants";
            // 
            // VariantsList
            // 
            this.VariantsList.FormattingEnabled = true;
            this.VariantsList.ItemHeight = 20;
            this.VariantsList.Location = new System.Drawing.Point(10, 28);
            this.VariantsList.Name = "VariantsList";
            this.VariantsList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.VariantsList.Size = new System.Drawing.Size(286, 184);
            this.VariantsList.TabIndex = 8;
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

        private System.Windows.Forms.ListBox VariantsList;

        private System.Windows.Forms.GroupBox ChordGroupBox;
        private System.Windows.Forms.CheckBox ChordInversionCheckbox;

        private System.Windows.Forms.ComboBox ChordNumberSelectBox;

        private System.Windows.Forms.Label ChordNumberLabel;

        private System.Windows.Forms.Button ConfirmButton;

        private System.Windows.Forms.GroupBox ChordVariantGroup;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.ComboBox KeySelectBox;

        #endregion
    }
}