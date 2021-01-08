using System;
using System.Linq;
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
            VariantsList.Items.AddRange(ChordVariant.Variants.Cast<object>().ToArray());
        }

        public Configurator(ChordExerciseConfiguration currentConfiguration) : this()
        {
            KeySelectBox.SelectedItem = currentConfiguration.Key;
            ChordNumberSelectBox.SelectedIndex = currentConfiguration.NumericChords ? 1 : 0;
            ChordInversionCheckbox.Checked = currentConfiguration.Inversions;
            if (currentConfiguration.Variants == null) return;
            foreach (var variant in currentConfiguration.Variants)
            {
                var index = VariantsList.Items.IndexOf(variant);
                VariantsList.SetSelected(index, true);
            }
        }

        private void ConfirmButtonClick(object sender, EventArgs e)
        {
            var selectedKey = (MusicKey)_keySource.Current;
            var numeric = ChordNumberSelectBox.SelectedIndex == 1;
            var selectedVariants = VariantsList.SelectedItems.Cast<ChordVariant>().ToArray();
            ConfigurationResult = new ChordExerciseConfiguration(
                selectedKey,
                numeric,
                selectedVariants,
                ChordInversionCheckbox.Checked
                );
        }
    }
}