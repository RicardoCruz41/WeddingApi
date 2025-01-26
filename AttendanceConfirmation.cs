namespace WeddingApi
{
    public class AttendanceConfirmation
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Restrictions { get; set; }

        public bool IsAttending { get; set; }

        public string Message { get; set; }
        public string Language { get; set; }
    }
}