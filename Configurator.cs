using System;
using System.Windows.Forms;

namespace PianoTeacher
{
    public partial class Configurator : Form
    {
        public ChordExerciseConfiguration ConfigurationResult { get; private set; }

        private readonly BindingSource _keySource;
        private Configurator()
        {
            InitializeComponent();
            _keySource = new BindingSource {DataSource = MusicKey.Keys};
            KeySelectBox.DataSource = _keySource;
            KeySelectBox.DisplayMember = nameof(MusicKey.DisplayName);
        }

        public Configurator(ChordExerciseConfiguration currentConfiguration) : this()
        {
            KeySelectBox.SelectedItem = currentConfiguration.Key;
            ChordNumberSelectBox.SelectedIndex = currentConfiguration.NumericChords ? 1 : 0;
            ChordDimCheckbox.Checked = currentConfiguration.ExtendedChords;
            ChordFlatCheckbox.Checked = currentConfiguration.FlatChords;
            ChordInversionCheckbox.Checked = currentConfiguration.Inversions;
            ChordRegularCheckbox.Checked = currentConfiguration.RegularChords;
            ChordSevenCheckbox.Checked = currentConfiguration.SeventhChords;
            ChordSusCheckbox.Checked = currentConfiguration.FourChords;
            ChordTwoCheckbox.Checked = currentConfiguration.TwoChords;
            ChordSixCheckbox.Checked = currentConfiguration.SixthChords;
        }

        private void ConfirmButtonClick(object sender, EventArgs e)
        {
            var selectedKey = (MusicKey)_keySource.Current;
            var numeric = ChordNumberSelectBox.SelectedIndex == 1;
            ConfigurationResult = new ChordExerciseConfiguration(
                selectedKey,
                numeric,
                ChordRegularCheckbox.Checked,
                ChordSusCheckbox.Checked,
                ChordTwoCheckbox.Checked,
                ChordSevenCheckbox.Checked,
                ChordSixCheckbox.Checked,
                ChordFlatCheckbox.Checked,
                ChordDimCheckbox.Checked,
                ChordInversionCheckbox.Checked
                );
        }
    }
}