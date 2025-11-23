// FormConfig.cs
using System;
using System.Windows.Forms;

namespace TrackBarLab
{
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();

            // Настройки модального окна
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ShowInTaskbar = false;

            // Фиксируем размер модального окна
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        public int TrackMinimum
        {
            get => (int)nudMinimum.Value;
            set => nudMinimum.Value = Math.Max(nudMinimum.Minimum, Math.Min(nudMinimum.Maximum, value));
        }

        public int TrackMaximum
        {
            get => (int)nudMaximum.Value;
            set => nudMaximum.Value = Math.Max(nudMaximum.Minimum, Math.Min(nudMaximum.Maximum, value));
        }

        public int TrackValue
        {
            get => (int)nudValue.Value;
            set => nudValue.Value = Math.Max(nudValue.Minimum, Math.Min(nudValue.Maximum, value));
        }

        public Orientation TrackOrientation
        {
            get => rbHorizontal.Checked ? Orientation.Horizontal : Orientation.Vertical;
            set
            {
                rbHorizontal.Checked = value == Orientation.Horizontal;
                rbVertical.Checked = value == Orientation.Vertical;
            }
        }

        public int TrackTickFrequency
        {
            get => (int)nudTickFrequency.Value;
            set => nudTickFrequency.Value = value;
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
        }
    }
}