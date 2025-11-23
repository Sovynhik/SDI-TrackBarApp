// FormConfig.Designer.cs
namespace TrackBarLab
{
    partial class FormConfig
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.nudMinimum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudMaximum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudTickFrequency = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.gbOrientation = new System.Windows.Forms.GroupBox();
            this.rbVertical = new System.Windows.Forms.RadioButton();
            this.rbHorizontal = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTickFrequency)).BeginInit();
            this.gbOrientation.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudMinimum / label1 / etc. — оставляем как было, только подправим размеры формы
            // 
            this.nudMinimum.Location = new System.Drawing.Point(104, 12);
            this.nudMinimum.Maximum = 1000;
            this.nudMinimum.Name = "nudMinimum";
            this.nudMinimum.Size = new System.Drawing.Size(120, 20);
            this.nudMinimum.TabIndex = 0;

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Minimum:";

            this.nudMaximum.Location = new System.Drawing.Point(104, 38);
            this.nudMaximum.Maximum = 1000;
            this.nudMaximum.Name = "nudMaximum";
            this.nudMaximum.Size = new System.Drawing.Size(120, 20);
            this.nudMaximum.TabIndex = 2;

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Maximum:";

            this.nudValue.Location = new System.Drawing.Point(104, 64);
            this.nudValue.Maximum = 1000;
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(120, 20);
            this.nudValue.TabIndex = 4;

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Value:";

            this.nudTickFrequency.Location = new System.Drawing.Point(104, 90);
            this.nudTickFrequency.Minimum = 1;
            this.nudTickFrequency.Value = 1;
            this.nudTickFrequency.Name = "nudTickFrequency";
            this.nudTickFrequency.Size = new System.Drawing.Size(120, 20);
            this.nudTickFrequency.TabIndex = 6;

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "TickFrequency:";

            this.gbOrientation.Controls.Add(this.rbVertical);
            this.gbOrientation.Controls.Add(this.rbHorizontal);
            this.gbOrientation.Location = new System.Drawing.Point(12, 116);
            this.gbOrientation.Name = "gbOrientation";
            this.gbOrientation.Size = new System.Drawing.Size(212, 64);
            this.gbOrientation.TabIndex = 8;
            this.gbOrientation.TabStop = false;
            this.gbOrientation.Text = "Ориентация";

            this.rbVertical.AutoSize = true;
            this.rbVertical.Location = new System.Drawing.Point(6, 42);
            this.rbVertical.Name = "rbVertical";
            this.rbVertical.Size = new System.Drawing.Size(200, 17);
            this.rbVertical.TabIndex = 1;
            this.rbVertical.Text = "Вертикальная";
            this.rbVertical.UseVisualStyleBackColor = true;

            this.rbHorizontal.AutoSize = true;
            this.rbHorizontal.Checked = true;
            this.rbHorizontal.Location = new System.Drawing.Point(6, 19);
            this.rbHorizontal.Name = "rbHorizontal";
            this.rbHorizontal.Size = new System.Drawing.Size(200, 17);
            this.rbHorizontal.TabIndex = 0;
            this.rbHorizontal.TabStop = true;
            this.rbHorizontal.Text = "Горизонтальная";
            this.rbHorizontal.UseVisualStyleBackColor = true;

            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(68, 186);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 30);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;

            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(149, 186);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormConfig
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(236, 221);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbOrientation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudTickFrequency);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudMaximum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudMinimum);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;                // НЕТ кнопки Развернуть
            this.MinimizeBox = false;                // НЕТ кнопки Свернуть
            this.MinimumSize = this.Size;            // ФИКСИРОВАННЫЙ размер
            this.MaximumSize = this.Size;            // Полностью запрещаем ресайз
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name = "FormConfig";
            this.Text = "Настройки TrackBar";
            this.Load += new System.EventHandler(this.FormConfig_Load);

            ((System.ComponentModel.ISupportInitialize)(this.nudMinimum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTickFrequency)).EndInit();
            this.gbOrientation.ResumeLayout(false);
            this.gbOrientation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudMinimum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudMaximum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudTickFrequency;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbOrientation;
        private System.Windows.Forms.RadioButton rbVertical;
        private System.Windows.Forms.RadioButton rbHorizontal;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}