namespace Serialization
{
    partial class MedicalCardsStorageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicalCardsStorageForm));
            this.mainFormAreaSeparator = new System.Windows.Forms.SplitContainer();
            this.menuTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.childMedicalCardsTreeView = new System.Windows.Forms.TreeView();
            this.medicalCardPictureBox = new System.Windows.Forms.PictureBox();
            this.adultMedicalCardsTreeView = new System.Windows.Forms.TreeView();
            this.pensionerMedicalCardsTreeView = new System.Windows.Forms.TreeView();
            this.allMedicalCardsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mainButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.downloadButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.dataFilesOpenDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormAreaSeparator)).BeginInit();
            this.mainFormAreaSeparator.Panel1.SuspendLayout();
            this.mainFormAreaSeparator.Panel2.SuspendLayout();
            this.mainFormAreaSeparator.SuspendLayout();
            this.menuTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicalCardPictureBox)).BeginInit();
            this.mainButtonsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFormAreaSeparator
            // 
            this.mainFormAreaSeparator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainFormAreaSeparator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFormAreaSeparator.IsSplitterFixed = true;
            this.mainFormAreaSeparator.Location = new System.Drawing.Point(0, 0);
            this.mainFormAreaSeparator.Name = "mainFormAreaSeparator";
            // 
            // mainFormAreaSeparator.Panel1
            // 
            this.mainFormAreaSeparator.Panel1.Controls.Add(this.menuTableLayoutPanel);
            this.mainFormAreaSeparator.Panel1MinSize = 0;
            // 
            // mainFormAreaSeparator.Panel2
            // 
            this.mainFormAreaSeparator.Panel2.Controls.Add(this.allMedicalCardsLayoutPanel);
            this.mainFormAreaSeparator.Panel2.Controls.Add(this.mainButtonsTableLayoutPanel);
            this.mainFormAreaSeparator.Panel2MinSize = 0;
            this.mainFormAreaSeparator.Size = new System.Drawing.Size(642, 473);
            this.mainFormAreaSeparator.SplitterDistance = 240;
            this.mainFormAreaSeparator.SplitterWidth = 1;
            this.mainFormAreaSeparator.TabIndex = 0;
            // 
            // menuTableLayoutPanel
            // 
            this.menuTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.menuTableLayoutPanel.ColumnCount = 1;
            this.menuTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menuTableLayoutPanel.Controls.Add(this.childMedicalCardsTreeView, 0, 1);
            this.menuTableLayoutPanel.Controls.Add(this.medicalCardPictureBox, 0, 0);
            this.menuTableLayoutPanel.Controls.Add(this.adultMedicalCardsTreeView, 0, 2);
            this.menuTableLayoutPanel.Controls.Add(this.pensionerMedicalCardsTreeView, 0, 3);
            this.menuTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.menuTableLayoutPanel.Name = "menuTableLayoutPanel";
            this.menuTableLayoutPanel.RowCount = 4;
            this.menuTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.84211F));
            this.menuTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.menuTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.menuTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.menuTableLayoutPanel.Size = new System.Drawing.Size(238, 471);
            this.menuTableLayoutPanel.TabIndex = 0;
            // 
            // childMedicalCardsTreeView
            // 
            this.childMedicalCardsTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.childMedicalCardsTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childMedicalCardsTreeView.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.childMedicalCardsTreeView.HideSelection = false;
            this.childMedicalCardsTreeView.Location = new System.Drawing.Point(5, 176);
            this.childMedicalCardsTreeView.Name = "childMedicalCardsTreeView";
            this.childMedicalCardsTreeView.Size = new System.Drawing.Size(228, 91);
            this.childMedicalCardsTreeView.TabIndex = 0;
            this.childMedicalCardsTreeView.TabStop = false;
            this.childMedicalCardsTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ChildMedicalCardsTreeViewNodeMouseClick);
            // 
            // medicalCardPictureBox
            // 
            this.medicalCardPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.medicalCardPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("medicalCardPictureBox.Image")));
            this.medicalCardPictureBox.Location = new System.Drawing.Point(5, 5);
            this.medicalCardPictureBox.Name = "medicalCardPictureBox";
            this.medicalCardPictureBox.Size = new System.Drawing.Size(228, 163);
            this.medicalCardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.medicalCardPictureBox.TabIndex = 0;
            this.medicalCardPictureBox.TabStop = false;
            // 
            // adultMedicalCardsTreeView
            // 
            this.adultMedicalCardsTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adultMedicalCardsTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adultMedicalCardsTreeView.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adultMedicalCardsTreeView.HideSelection = false;
            this.adultMedicalCardsTreeView.Location = new System.Drawing.Point(5, 275);
            this.adultMedicalCardsTreeView.Name = "adultMedicalCardsTreeView";
            this.adultMedicalCardsTreeView.Size = new System.Drawing.Size(228, 91);
            this.adultMedicalCardsTreeView.TabIndex = 1;
            this.adultMedicalCardsTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.AdultMedicalCardsTreeViewNodeMouseClick);
            // 
            // pensionerMedicalCardsTreeView
            // 
            this.pensionerMedicalCardsTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pensionerMedicalCardsTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pensionerMedicalCardsTreeView.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pensionerMedicalCardsTreeView.HideSelection = false;
            this.pensionerMedicalCardsTreeView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pensionerMedicalCardsTreeView.Location = new System.Drawing.Point(5, 374);
            this.pensionerMedicalCardsTreeView.Name = "pensionerMedicalCardsTreeView";
            this.pensionerMedicalCardsTreeView.Size = new System.Drawing.Size(228, 92);
            this.pensionerMedicalCardsTreeView.TabIndex = 2;
            this.pensionerMedicalCardsTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.PensionerMedicalCardsTreeViewNodeMouseClick);
            // 
            // allMedicalCardsLayoutPanel
            // 
            this.allMedicalCardsLayoutPanel.AutoScroll = true;
            this.allMedicalCardsLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.allMedicalCardsLayoutPanel.ColumnCount = 1;
            this.allMedicalCardsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.allMedicalCardsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allMedicalCardsLayoutPanel.Location = new System.Drawing.Point(0, 54);
            this.allMedicalCardsLayoutPanel.Name = "allMedicalCardsLayoutPanel";
            this.allMedicalCardsLayoutPanel.RowCount = 1;
            this.allMedicalCardsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.allMedicalCardsLayoutPanel.Size = new System.Drawing.Size(399, 417);
            this.allMedicalCardsLayoutPanel.TabIndex = 1;
            // 
            // mainButtonsTableLayoutPanel
            // 
            this.mainButtonsTableLayoutPanel.ColumnCount = 3;
            this.mainButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainButtonsTableLayoutPanel.Controls.Add(this.downloadButton, 0, 0);
            this.mainButtonsTableLayoutPanel.Controls.Add(this.showButton, 1, 0);
            this.mainButtonsTableLayoutPanel.Controls.Add(this.closeButton, 2, 0);
            this.mainButtonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainButtonsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainButtonsTableLayoutPanel.Name = "mainButtonsTableLayoutPanel";
            this.mainButtonsTableLayoutPanel.RowCount = 1;
            this.mainButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainButtonsTableLayoutPanel.Size = new System.Drawing.Size(399, 54);
            this.mainButtonsTableLayoutPanel.TabIndex = 0;
            // 
            // downloadButton
            // 
            this.downloadButton.AutoEllipsis = true;
            this.downloadButton.BackColor = System.Drawing.Color.SkyBlue;
            this.downloadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downloadButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downloadButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.downloadButton.FlatAppearance.BorderSize = 0;
            this.downloadButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.downloadButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.downloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downloadButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.downloadButton.Location = new System.Drawing.Point(3, 3);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.downloadButton.Size = new System.Drawing.Size(127, 48);
            this.downloadButton.TabIndex = 0;
            this.downloadButton.Text = "Загрузить данные";
            this.downloadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.downloadButton.UseVisualStyleBackColor = false;
            this.downloadButton.Click += new System.EventHandler(this.DownloadButtonClick);
            // 
            // showButton
            // 
            this.showButton.AutoEllipsis = true;
            this.showButton.BackColor = System.Drawing.Color.SkyBlue;
            this.showButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.showButton.FlatAppearance.BorderSize = 0;
            this.showButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.showButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showButton.Location = new System.Drawing.Point(136, 3);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(127, 48);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "Показать данные";
            this.showButton.UseVisualStyleBackColor = false;
            this.showButton.Click += new System.EventHandler(this.ShowButtonClick);
            // 
            // closeButton
            // 
            this.closeButton.AutoEllipsis = true;
            this.closeButton.BackColor = System.Drawing.Color.SkyBlue;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.Location = new System.Drawing.Point(269, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(127, 48);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // dataFilesOpenDialog
            // 
            this.dataFilesOpenDialog.Filter = "Файлы с данными (*.xml)|*.xml|Файлы с данными (*.json)|*.json";
            this.dataFilesOpenDialog.Title = "Открыть файл с данными";
            // 
            // MedicalCardsStorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(642, 473);
            this.ControlBox = false;
            this.Controls.Add(this.mainFormAreaSeparator);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MedicalCardsStorageForm";
            this.Text = "Медицинские карты пациентов";
            this.mainFormAreaSeparator.Panel1.ResumeLayout(false);
            this.mainFormAreaSeparator.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainFormAreaSeparator)).EndInit();
            this.mainFormAreaSeparator.ResumeLayout(false);
            this.menuTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medicalCardPictureBox)).EndInit();
            this.mainButtonsTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainFormAreaSeparator;
        private System.Windows.Forms.TableLayoutPanel mainButtonsTableLayoutPanel;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TableLayoutPanel menuTableLayoutPanel;
        private System.Windows.Forms.PictureBox medicalCardPictureBox;
        private System.Windows.Forms.OpenFileDialog dataFilesOpenDialog;
        private System.Windows.Forms.TableLayoutPanel allMedicalCardsLayoutPanel;
        private System.Windows.Forms.TreeView childMedicalCardsTreeView;
        private System.Windows.Forms.TreeView adultMedicalCardsTreeView;
        private System.Windows.Forms.TreeView pensionerMedicalCardsTreeView;
    }
}

