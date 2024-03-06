using System;
using MedicalCards;
using System.Windows.Forms;

namespace Serialization
{
    public partial class PatientInformation : Form
    {
        #region Конструкторы
        /// <summary>
        /// Конструктор, создающий экземпляр класса PatientInformation.
        /// </summary>
        /// <param name="medicalCard"> Медицинская карта пациента. </param>
        public PatientInformation(MedicalCard medicalCard)
        {
            InitializeComponent();

            dataOfPatientFullNameLabel.Text = $"{medicalCard.fullName.surname} {medicalCard.fullName.name} {medicalCard.fullName.patronymic}";
            dataOfPatientPlaceOfResidenceLabel.Text = $"{medicalCard.placeOfResidence.countryOfResidence}, г. {medicalCard.placeOfResidence.cityOfResidence}, " +
                                                      $"ул. {medicalCard.placeOfResidence.streetOfResidence}, д. {medicalCard.placeOfResidence.houseOfResidence}";
            dataOfPatientBirthDateLabel.Text = new DateTime(medicalCard.birthDate.birthYear, medicalCard.birthDate.birthMonth, medicalCard.birthDate.birthDay).GetDateTimeFormats()[3];

            if (medicalCard is ChildMedicalCard)
            {
                ChildMedicalCard childMedicalCard = (ChildMedicalCard)medicalCard;
                employmentInformationLabel.Text = "Название школы, Класс обучения";
                dataOfEmploymentLabel.Text = $"{childMedicalCard.schoolName}, {childMedicalCard.classAtSchool}";
            }
            else if (medicalCard is AdultMedicalCard)
            {
                AdultMedicalCard adultMedicalCard = (AdultMedicalCard)medicalCard;
                employmentInformationLabel.Text = "Место работы";
                dataOfEmploymentLabel.Text = $"{adultMedicalCard.workplace}";
            }
            else
            {
                PensionerMedicalCard pensionerMedicalCard = (PensionerMedicalCard)medicalCard;
                employmentInformationLabel.Text = "Бывшее место работы";
                dataOfEmploymentLabel.Text = $"{pensionerMedicalCard.formerWorkplace}";
            }
        }
        #endregion
    }
}