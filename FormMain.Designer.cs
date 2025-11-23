// FormMain.Designer.cs
namespace TrackBarLab
{
    partial class FormMain
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
            this.tbMainTrackBar = new System.Windows.Forms.TrackBar();
            this.btnOpenConfig = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbMainTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMainTrackBar
            // 
            this.tbMainTrackBar.LargeChange = 10;
            this.tbMainTrackBar.Location = new System.Drawing.Point(18, 18);
            this.tbMainTrackBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMainTrackBar.Maximum = 100;
            this.tbMainTrackBar.Name = "tbMainTrackBar";
            this.tbMainTrackBar.Size = new System.Drawing.Size(564, 69);
            this.tbMainTrackBar.TabIndex = 0;
            this.tbMainTrackBar.TickFrequency = 10;
            this.tbMainTrackBar.Value = 50;
            // 
            // btnOpenConfig
            // 
            this.btnOpenConfig.Location = new System.Drawing.Point(18, 106);
            this.btnOpenConfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenConfig.Name = "btnOpenConfig";
            this.btnOpenConfig.Size = new System.Drawing.Size(564, 62);
            this.btnOpenConfig.TabIndex = 1;
            this.btnOpenConfig.Text = "Настройки";
            this.btnOpenConfig.UseVisualStyleBackColor = true;
            this.btnOpenConfig.Click += new System.EventHandler(this.btnOpenConfig_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 145);
            this.Controls.Add(this.btnOpenConfig);
            this.Controls.Add(this.tbMainTrackBar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма с TrackBar";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbMainTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbMainTrackBar;
        private System.Windows.Forms.Button btnOpenConfig;
    }
}