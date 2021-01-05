using System;
using System.Windows.Forms;

namespace PianoTeacher
{
    public partial class Form1 : Form
    {
        private readonly PianoController _piano;
        private bool _connected;
        private ChordExerciseConfiguration _chordExerciseConfiguration;
        
        public Form1()
        {
            InitializeComponent();
            _piano = new PianoController();
            _connected = false;
            EnumerateDevices();
        }
        
        private void RefreshConnectionState()
        {
            ConnectButton.Enabled = InputDeviceComboBox.SelectedIndex >= 0 && OutputDeviceComboBox.SelectedIndex >= 0;
            ConfigureButton.Enabled = _connected;
            StartButton.Enabled = _connected;
        }
        
        private void EnumerateDevices()
        {
            InputDeviceComboBox.Items.Clear();
            OutputDeviceComboBox.Items.Clear();

            using var tempLabel = new Label();
            var longestInDevice = InputDeviceComboBox.Width;
            var longestOutDevice = OutputDeviceComboBox.Width;

            foreach (var device in PianoController.GetConnectedInputDevices())
            {
                var name = $"{device.ProductName} - {device.Manufacturer}";
                InputDeviceComboBox.Items.Add(name);
                tempLabel.Text = name;
                longestInDevice = Math.Max(longestInDevice, tempLabel.PreferredWidth);
            }

            InputDeviceComboBox.DropDownWidth = longestInDevice;
            if(InputDeviceComboBox.Items.Count > 0) InputDeviceComboBox.SelectedIndex = 0;

            foreach (var device in PianoController.GetConnectedOutDevices())
            {
                var name = $"{device.ProductName} - {device.Manufacturer}";
                OutputDeviceComboBox.Items.Add(name);
                tempLabel.Text = name;
                longestOutDevice = Math.Max(longestOutDevice, tempLabel.PreferredWidth);
            }

            OutputDeviceComboBox.DropDownWidth = longestOutDevice;
            if(OutputDeviceComboBox.Items.Count > 0) OutputDeviceComboBox.SelectedIndex = 0;
            RefreshConnectionState();
        }

        private void ConnectButtonClick(object sender, EventArgs e)
        {
            _piano.Init(InputDeviceComboBox.SelectedIndex,OutputDeviceComboBox.SelectedIndex);
            _connected = true;
            RefreshConnectionState();
        }

        private void RefreshButtonClick(object sender, EventArgs e)
        {
            EnumerateDevices();
        }

        private void ConfigureButtonClick(object sender, EventArgs e)
        {
            using var dialog = new Configurator(_chordExerciseConfiguration);
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                _chordExerciseConfiguration = dialog.ConfigurationResult;
            }
        }

        private void StartButtonClick(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}