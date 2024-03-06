namespace Serialization
{
    partial class PatientInformation
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientInformation));
            this.patientInformationTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.placeOfResidenceLabel = new System.Windows.Forms.Label();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.employmentInformationLabel = new System.Windows.Forms.Label();
            this.dataOfPatientFullNameLabel = new System.Windows.Forms.Label();
            this.dataOfPatientPlaceOfResidenceLabel = new System.Windows.Forms.Label();
            this.dataOfPatientBirthDateLabel = new System.Windows.Forms.Label();
            this.dataOfEmploymentLabel = new System.Windows.Forms.Label();
            this.patientInformationTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientInformationTableLayoutPanel
            // 
            this.patientInformationTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.patientInformationTableLayoutPanel.ColumnCount = 2;
            this.patientInformationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.patientInformationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.patientInformationTableLayoutPanel.Controls.Add(this.fullNameLabel, 0, 0);
            this.patientInformationTableLayoutPanel.Controls.Add(this.placeOfResidenceLabel, 0, 1);
            this.patientInformationTableLayoutPanel.Controls.Add(this.birthDateLabel, 0, 2);
            this.patientInformationTableLayoutPanel.Controls.Add(this.employmentInformationLabel, 0, 3);
            this.patientInformationTableLayoutPanel.Controls.Add(this.dataOfPatientFullNameLabel, 1, 0);
            this.patientInformationTableLayoutPanel.Controls.Add(this.dataOfPatientPlaceOfResidenceLabel, 1, 1);
            this.patientInformationTableLayoutPanel.Controls.Add(this.dataOfPatientBirthDateLabel, 1, 2);
            this.patientInformationTableLayoutPanel.Controls.Add(this.dataOfEmploymentLabel, 1, 3);
            this.patientInformationTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientInformationTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.patientInformationTableLayoutPanel.Name = "patientInformationTableLayoutPanel";
            this.patientInformationTableLayoutPanel.RowCount = 4;
            this.patientInformationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.patientInformationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.patientInformationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.patientInformationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.patientInformationTableLayoutPanel.Size = new System.Drawing.Size(482, 353);
            this.patientInformationTableLayoutPanel.TabIndex = 0;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoEllipsis = true;
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameLabel.Location = new System.Drawing.Point(5, 2);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(184, 85);
            this.fullNameLabel.TabIndex = 0;
            this.fullNameLabel.Text = "Фамилия Имя Отчество";
            this.fullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // placeOfResidenceLabel
            // 
            this.placeOfResidenceLabel.AutoEllipsis = true;
            this.placeOfResidenceLabel.AutoSize = true;
            this.placeOfResidenceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.placeOfResidenceLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.placeOfResidenceLabel.Location = new System.Drawing.Point(5, 89);
            this.placeOfResidenceLabel.Name = "placeOfResidenceLabel";
            this.placeOfResidenceLabel.Size = new System.Drawing.Size(184, 85);
            this.placeOfResidenceLabel.TabIndex = 1;
            this.placeOfResidenceLabel.Text = "Место жительства";
            this.placeOfResidenceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoEllipsis = true;
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.birthDateLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthDateLabel.Location = new System.Drawing.Point(5, 176);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(184, 85);
            this.birthDateLabel.TabIndex = 2;
            this.birthDateLabel.Text = "Дата рождения";
            this.birthDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // employmentInformationLabel
            // 
            this.employmentInformationLabel.AutoEllipsis = true;
            this.employmentInformationLabel.AutoSize = true;
            this.employmentInformationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employmentInformationLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employmentInformationLabel.Location = new System.Drawing.Point(5, 263);
            this.employmentInformationLabel.Name = "employmentInformationLabel";
            this.employmentInformationLabel.Size = new System.Drawing.Size(184, 88);
            this.employmentInformationLabel.TabIndex = 3;
            this.employmentInformationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataOfPatientFullNameLabel
            // 
            this.dataOfPatientFullNameLabel.AutoEllipsis = true;
            this.dataOfPatientFullNameLabel.AutoSize = true;
            this.dataOfPatientFullNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataOfPatientFullNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataOfPatientFullNameLabel.Location = new System.Drawing.Point(197, 2);
            this.dataOfPatientFullNameLabel.Name = "dataOfPatientFullNameLabel";
            this.dataOfPatientFullNameLabel.Size = new System.Drawing.Size(280, 85);
            this.dataOfPatientFullNameLabel.TabIndex = 4;
            this.dataOfPatientFullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataOfPatientPlaceOfResidenceLabel
            // 
            this.dataOfPatientPlaceOfResidenceLabel.AllowDrop = true;
            this.dataOfPatientPlaceOfResidenceLabel.AutoEllipsis = true;
            this.dataOfPatientPlaceOfResidenceLabel.AutoSize = true;
            this.dataOfPatientPlaceOfResidenceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataOfPatientPlaceOfResidenceLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataOfPatientPlaceOfResidenceLabel.Location = new System.Drawing.Point(197, 89);
            this.dataOfPatientPlaceOfResidenceLabel.Name = "dataOfPatientPlaceOfResidenceLabel";
            this.dataOfPatientPlaceOfResidenceLabel.Size = new System.Drawing.Size(280, 85);
            this.dataOfPatientPlaceOfResidenceLabel.TabIndex = 5;
            this.dataOfPatientPlaceOfResidenceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataOfPatientBirthDateLabel
            // 
            this.dataOfPatientBirthDateLabel.AutoEllipsis = true;
            this.dataOfPatientBirthDateLabel.AutoSize = true;
            this.dataOfPatientBirthDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataOfPatientBirthDateLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataOfPatientBirthDateLabel.Location = new System.Drawing.Point(197, 176);
            this.dataOfPatientBirthDateLabel.Name = "dataOfPatientBirthDateLabel";
            this.dataOfPatientBirthDateLabel.Size = new System.Drawing.Size(280, 85);
            this.dataOfPatientBirthDateLabel.TabIndex = 6;
            this.dataOfPatientBirthDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataOfEmploymentLabel
            // 
            this.dataOfEmploymentLabel.AutoEllipsis = true;
            this.dataOfEmploymentLabel.AutoSize = true;
            this.dataOfEmploymentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataOfEmploymentLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataOfEmploymentLabel.Location = new System.Drawing.Point(197, 263);
            this.dataOfEmploymentLabel.Name = "dataOfEmploymentLabel";
            this.dataOfEmploymentLabel.Size = new System.Drawing.Size(280, 88);
            this.dataOfEmploymentLabel.TabIndex = 7;
            this.dataOfEmploymentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatientInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.patientInformationTableLayoutPanel);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PatientInformation";
            this.Text = "Информация о пациенте";
            this.TopMost = true;
            this.patientInformationTableLayoutPanel.ResumeLayout(false);
            this.patientInformationTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel patientInformationTableLayoutPanel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label placeOfResidenceLabel;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.Label employmentInformationLabel;
        private System.Windows.Forms.Label dataOfPatientFullNameLabel;
        private System.Windows.Forms.Label dataOfPatientPlaceOfResidenceLabel;
        private System.Windows.Forms.Label dataOfPatientBirthDateLabel;
        private System.Windows.Forms.Label dataOfEmploymentLabel;
    }
}