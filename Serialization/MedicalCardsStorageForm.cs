using System;
using System.IO;
using MedicalCards;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;

namespace Serialization
{
    public partial class MedicalCardsStorageForm : Form
    {
        #region Поля
        private MedicalCard[] allMedicalCards;
        private string dataFilePath;
        #endregion

        #region События
        /// <summary>
        /// Метод, который обрабатывает нажатие на кнопку "Загрузить данные".
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void DownloadButtonClick(object sender, EventArgs e)
        {
            if (dataFilesOpenDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            allMedicalCards = null;
            dataFilePath = dataFilesOpenDialog.FileName;
            FileStream dataFile = new FileStream(dataFilePath, FileMode.Open);

            try
            {
                if (Path.GetExtension(dataFilePath) == ".xml")
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(MedicalCard[]), new[] {typeof(ChildMedicalCard), typeof(AdultMedicalCard), typeof(PensionerMedicalCard)});
                    allMedicalCards = xmlSerializer.Deserialize(dataFile) as MedicalCard[];
                }
                else
                {
                    DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(MedicalCard[]), new[] {typeof(ChildMedicalCard), typeof(AdultMedicalCard), typeof(PensionerMedicalCard)});
                    allMedicalCards = jsonSerializer.ReadObject(dataFile) as MedicalCard[];
                }

                dataFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить файл. Повторите попытку!", "Загрузка файла с данными");
                return;
            }

            MessageBox.Show("Файл успешно загружен!", "Загрузка файла с данными");
        }

        /// <summary>
        /// Метод, который обрабатывает нажатие на кнопку "Показать данные".
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void ShowButtonClick(object sender, EventArgs e)
        {
            if (allMedicalCards == null)
            {
                return;
            }

            childMedicalCardsTreeView.Nodes.Clear();
            adultMedicalCardsTreeView.Nodes.Clear();
            pensionerMedicalCardsTreeView.Nodes.Clear();
            allMedicalCardsLayoutPanel.Controls.Clear();
            allMedicalCardsLayoutPanel.RowCount = 0;
            allMedicalCardsLayoutPanel.RowStyles.Clear();

            TreeNode childMedicalCardsTreeViewRoot = new TreeNode();
            childMedicalCardsTreeViewRoot.Text = "Медкарты детей";
            childMedicalCardsTreeViewRoot.Name = "childMedicalCards";
            childMedicalCardsTreeView.Nodes.Add(childMedicalCardsTreeViewRoot);

            TreeNode adultMedicalCardsTreeViewRoot = new TreeNode();
            adultMedicalCardsTreeViewRoot.Text = "Медкарты взрослых";
            adultMedicalCardsTreeViewRoot.Name = "adultMedicalCards";
            adultMedicalCardsTreeView.Nodes.Add(adultMedicalCardsTreeViewRoot);

            TreeNode pensionerMedicalCardsTreeViewRoot = new TreeNode();
            pensionerMedicalCardsTreeViewRoot.Text = "Медкарты пенсионеров";
            pensionerMedicalCardsTreeViewRoot.Name = "pensionersMedicalCards";
            pensionerMedicalCardsTreeView.Nodes.Add(pensionerMedicalCardsTreeViewRoot);

            allMedicalCardsLayoutPanel.RowCount = allMedicalCards.Length;

            for (int i = 0; i < allMedicalCards.Length; i++)
            {
                Label patientFullNameLabel = new Label();
                allMedicalCardsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, (100 / allMedicalCardsLayoutPanel.RowCount)));
                allMedicalCardsLayoutPanel.Controls.Add(patientFullNameLabel, 0, i);

                patientFullNameLabel.Dock = DockStyle.Fill;
                patientFullNameLabel.Cursor = Cursors.Hand;
                patientFullNameLabel.Name = $"patientFullNameLabel{i}";
                patientFullNameLabel.Text = $"{allMedicalCards[i].fullName.surname} {allMedicalCards[i].fullName.name} {allMedicalCards[i].fullName.patronymic}";
                patientFullNameLabel.TextAlign = ContentAlignment.MiddleCenter;
                patientFullNameLabel.Click += new EventHandler(FullNameClick);

                if (allMedicalCards[i] is ChildMedicalCard)
                {
                    TreeNode patientFullNameTreeNode = new TreeNode();
                    patientFullNameTreeNode.Name = $"patientFullNameTreeNode{i}";
                    patientFullNameTreeNode.Text = $"{allMedicalCards[i].fullName.surname} {allMedicalCards[i].fullName.name} {allMedicalCards[i].fullName.patronymic}";
                    childMedicalCardsTreeViewRoot.Nodes.Add(patientFullNameTreeNode);
                }
                else if (allMedicalCards[i] is AdultMedicalCard)
                {
                    TreeNode patientFullNameTreeNode = new TreeNode();
                    patientFullNameTreeNode.Name = $"patientFullNameTreeNode{i}";
                    patientFullNameTreeNode.Text = $"{allMedicalCards[i].fullName.surname} {allMedicalCards[i].fullName.name} {allMedicalCards[i].fullName.patronymic}";
                    adultMedicalCardsTreeViewRoot.Nodes.Add(patientFullNameTreeNode);
                }
                else
                {
                    TreeNode patientFullNameTreeNode = new TreeNode();
                    patientFullNameTreeNode.Name = $"patientFullNameTreeNode{i}";
                    patientFullNameTreeNode.Text = $"{allMedicalCards[i].fullName.surname} {allMedicalCards[i].fullName.name} {allMedicalCards[i].fullName.patronymic}";
                    pensionerMedicalCardsTreeViewRoot.Nodes.Add(patientFullNameTreeNode);
                }
            }
        }

        /// <summary>
        /// Метод, который обрабатывает нажатие на кнопку "Закрыть".
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void CloseButtonClick(object sender, EventArgs e)
        {
            if (Path.GetExtension(dataFilePath) == ".xml")
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(MedicalCard[]), new[] {typeof(ChildMedicalCard), typeof(AdultMedicalCard), typeof(PensionerMedicalCard)});
                FileStream dataFile = new FileStream("ProgramFiles/allMedicalCards.xml", FileMode.OpenOrCreate);
                xmlSerializer.Serialize(dataFile, allMedicalCards);
                dataFile.Close();
            }
            else
            {
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(MedicalCard[]), new[] {typeof(ChildMedicalCard), typeof(AdultMedicalCard), typeof(PensionerMedicalCard)});
                FileStream dataFile = new FileStream("ProgramFiles/allMedicalCards.json", FileMode.OpenOrCreate);
                jsonSerializer.WriteObject(dataFile, allMedicalCards);
                dataFile.Close();
            }

            Close();
        }

        /// <summary>
        /// Метод, который обрабатывает нажатие на ФИО пациента в childMedicalCardsTreeView.
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void ChildMedicalCardsTreeViewNodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode patientFullNameTreeNode = childMedicalCardsTreeView.GetNodeAt(childMedicalCardsTreeView.PointToClient(Cursor.Position));

            if (patientFullNameTreeNode != null)
            {
                bool parseResult = int.TryParse(patientFullNameTreeNode.Name[patientFullNameTreeNode.Name.Length - 1].ToString(), out int index);

                if (parseResult)
                {
                    PatientInformation patientInformation = new PatientInformation(allMedicalCards[index]);
                    patientInformation.Show();
                }
            }
        }

        /// <summary>
        /// Метод, который обрабатывает нажатие на ФИО пациента в adultMedicalCardsTreeView.
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void AdultMedicalCardsTreeViewNodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode patientFullNameTreeNode = adultMedicalCardsTreeView.GetNodeAt(adultMedicalCardsTreeView.PointToClient(Cursor.Position));

            if (patientFullNameTreeNode != null)
            {
                bool parseResult = int.TryParse(patientFullNameTreeNode.Name[patientFullNameTreeNode.Name.Length - 1].ToString(), out int index);

                if (parseResult)
                {
                    PatientInformation patientInformation = new PatientInformation(allMedicalCards[index]);
                    patientInformation.Show();
                }
            }
        }

        /// <summary>
        /// Метод, который обрабатывает нажатие на ФИО пациента в pensionerMedicalCardsTreeView.
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void PensionerMedicalCardsTreeViewNodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode patientFullNameTreeNode = pensionerMedicalCardsTreeView.GetNodeAt(pensionerMedicalCardsTreeView.PointToClient(Cursor.Position));

            if (patientFullNameTreeNode != null)
            {
                bool parseResult = int.TryParse(patientFullNameTreeNode.Name[patientFullNameTreeNode.Name.Length - 1].ToString(), out int index);

                if (parseResult)
                {
                    PatientInformation patientInformation = new PatientInformation(allMedicalCards[index]);
                    patientInformation.Show();
                }
            }
        }

        /// <summary>
        /// Метод, который обрабатывает нажатие на ФИО пациента в allMedicalCardsLayoutPanel.
        /// </summary>
        /// <param name="sender"> Объект-инициатор. </param>
        /// <param name="e"> Объект-событие. </param>
        private void FullNameClick(object sender, EventArgs e)
        {
            Label patientFullNamelabel = (Label)sender;
            int index = int.Parse(patientFullNamelabel.Name[patientFullNamelabel.Name.Length - 1].ToString());

            PatientInformation patientInformation = new PatientInformation(allMedicalCards[index]);
            patientInformation.Show();
        }
        #endregion

        #region Конструкторы
        public MedicalCardsStorageForm()
        {
            InitializeComponent();
        }
        #endregion
    }
}