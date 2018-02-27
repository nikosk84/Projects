namespace HospitalLibrary.Models
{
    public class PatientModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomeAddress { get; set; }
        public string Gender { get; set; }
        public string ConsultingDoctor { get; set; }
        public string Ward { get; set; }
        public string RoomNumber { get; set; }
        public string BedNumber { get; set; }
        public string HasHealthCard { get; set; }

        /// <summary>
        /// Output string layout
        /// </summary>
        public string FullPatientInfo
        {
            get
            {
                return $"(ID: {Id}) {FirstName} {LastName},  {Gender}, {HomeAddress}, (Doctor: {ConsultingDoctor}), (Ward: {Ward}), (Bed No: {BedNumber}), (Room No: {RoomNumber}) Health Card: {HasHealthCard}";
            }
        }

    } 
}
