using System;
using System.Windows.Forms;

namespace TrackBarLab
{
    public partial class FormMain : Form
    {
        private FormConfig config;

        public FormMain()
        {
            InitializeComponent();

            config = new FormConfig();

            // Начальные настройки
            tbMainTrackBar.Minimum = 0;
            tbMainTrackBar.Maximum = 100;
            tbMainTrackBar.Value = 50;
            tbMainTrackBar.TickFrequency = 10;
            tbMainTrackBar.Orientation = Orientation.Horizontal;

            this.MaximizeBox = false;
            AdjustFormSize(); // сразу при запуске
        }

        private void btnOpenConfig_Click(object sender, EventArgs e)
        {
            // Передаём текущие значения
            config.TrackMinimum = tbMainTrackBar.Minimum;
            config.TrackMaximum = tbMainTrackBar.Maximum;
            config.TrackValue = tbMainTrackBar.Value;
            config.TrackOrientation = tbMainTrackBar.Orientation;
            config.TrackTickFrequency = tbMainTrackBar.TickFrequency;

            if (config.ShowDialog(this) == DialogResult.OK)
            {
                tbMainTrackBar.Minimum = config.TrackMinimum;
                tbMainTrackBar.Maximum = config.TrackMaximum;
                tbMainTrackBar.Value = config.TrackValue;
                tbMainTrackBar.Orientation = config.TrackOrientation;
                tbMainTrackBar.TickFrequency = config.TrackTickFrequency;

                AdjustFormSize(); // пересчитываем размеры и позиции
            }
        }

        private void AdjustFormSize()
        {
            // Сначала снимаем ограничения
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.MaximumSize = new System.Drawing.Size(0, 0);

            const int margin = 30;
            const int buttonHeight = 56;

            if (tbMainTrackBar.Orientation == Orientation.Horizontal)
            {
                this.ClientSize = new System.Drawing.Size(620, 240);

                tbMainTrackBar.Location = new System.Drawing.Point(margin, 60);
                tbMainTrackBar.Size = new System.Drawing.Size(620 - 2 * margin, 50);

                btnOpenConfig.Location = new System.Drawing.Point(margin, 140);
                btnOpenConfig.Size = new System.Drawing.Size(620 - 2 * margin, 46);
            }
            else // вертикальная
            {
                this.ClientSize = new System.Drawing.Size(180, 520);

                tbMainTrackBar.Location = new System.Drawing.Point((180 - 45) / 2, 40);
                tbMainTrackBar.Size = new System.Drawing.Size(45, 520 - buttonHeight - 100);

                btnOpenConfig.Location = new System.Drawing.Point(margin, 520 - buttonHeight - 20);
                btnOpenConfig.Size = new System.Drawing.Size(180 - 2 * margin, 46);
            }

            // Фиксируем размер
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;

            // ВОТ ЭТА СТРОЧКА — ВСЕГДА ПО ЦЕНТРУ ЭКРАНА
            this.CenterToScreen();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            AdjustFormSize(); // на всякий случай ещё раз
        }
    }
}