namespace PianoTeacher
{
    partial class MainForm
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChordLabel = new System.Windows.Forms.Label();
            this.ConfigureButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.IndeviceLabel = new System.Windows.Forms.Label();
            this.InputDeviceComboBox = new System.Windows.Forms.ComboBox();
            this.OutputDeviceComboBox = new System.Windows.Forms.ComboBox();
            this.OutdeviceLabel = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChordLabel
            // 
            this.ChordLabel.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.ChordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ChordLabel.Location = new System.Drawing.Point(12, 53);
            this.ChordLabel.Name = "ChordLabel";
            this.ChordLabel.Size = new System.Drawing.Size(754, 296);
            this.ChordLabel.TabIndex = 0;
            this.ChordLabel.Text = ":)";
            this.ChordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfigureButton
            // 
            this.ConfigureButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ConfigureButton.Location = new System.Drawing.Point(195, 382);
            this.ConfigureButton.Name = "ConfigureButton";
            this.ConfigureButton.Size = new System.Drawing.Size(200, 50);
            this.ConfigureButton.TabIndex = 1;
            this.ConfigureButton.Text = "Configure exercise";
            this.ConfigureButton.UseVisualStyleBackColor = true;
            this.ConfigureButton.Click += new System.EventHandler(this.ConfigureButtonClick);
            // 
            // StartButton
            // 
            this.StartButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.StartButton.Location = new System.Drawing.Point(405, 382);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(200, 50);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start exercise";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButtonClick);
            // 
            // IndeviceLabel
            // 
            this.IndeviceLabel.AutoSize = true;
            this.IndeviceLabel.Location = new System.Drawing.Point(12, 9);
            this.IndeviceLabel.Name = "IndeviceLabel";
            this.IndeviceLabel.Size = new System.Drawing.Size(95, 20);
            this.IndeviceLabel.TabIndex = 3;
            this.IndeviceLabel.Text = "Input device";
            // 
            // InputDeviceComboBox
            // 
            this.InputDeviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputDeviceComboBox.FormattingEnabled = true;
            this.InputDeviceComboBox.Location = new System.Drawing.Point(113, 6);
            this.InputDeviceComboBox.Name = "InputDeviceComboBox";
            this.InputDeviceComboBox.Size = new System.Drawing.Size(169, 28);
            this.InputDeviceComboBox.TabIndex = 4;
            // 
            // OutputDeviceComboBox
            // 
            this.OutputDeviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OutputDeviceComboBox.FormattingEnabled = true;
            this.OutputDeviceComboBox.Location = new System.Drawing.Point(401, 6);
            this.OutputDeviceComboBox.Name = "OutputDeviceComboBox";
            this.OutputDeviceComboBox.Size = new System.Drawing.Size(169, 28);
            this.OutputDeviceComboBox.TabIndex = 6;
            // 
            // OutdeviceLabel
            // 
            this.OutdeviceLabel.AutoSize = true;
            this.OutdeviceLabel.Location = new System.Drawing.Point(288, 9);
            this.OutdeviceLabel.Name = "OutdeviceLabel";
            this.OutdeviceLabel.Size = new System.Drawing.Size(107, 20);
            this.OutdeviceLabel.TabIndex = 5;
            this.OutdeviceLabel.Text = "Output device";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(576, 6);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(84, 28);
            this.ConnectButton.TabIndex = 7;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButtonClick);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(666, 6);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(83, 28);
            this.RefreshButton.TabIndex = 8;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 444);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.OutputDeviceComboBox);
            this.Controls.Add(this.OutdeviceLabel);
            this.Controls.Add(this.InputDeviceComboBox);
            this.Controls.Add(this.IndeviceLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ConfigureButton);
            this.Controls.Add(this.ChordLabel);
            this.Name = "MainForm";
            this.Text = "PianoTeacher";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox InputDeviceComboBox;
        private System.Windows.Forms.ComboBox OutputDeviceComboBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label IndeviceLabel;
        private System.Windows.Forms.Label OutdeviceLabel;
        private System.Windows.Forms.Button RefreshButton;

        private System.Windows.Forms.Button ConfigureButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label ChordLabel;

        #endregion
    }
}