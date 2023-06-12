namespace PhonebookApp.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Contact()
        {
            Name = string.Empty;
            PhoneNumber = string.Empty;
        }
    }

}
