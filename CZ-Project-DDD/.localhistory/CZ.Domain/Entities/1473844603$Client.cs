using System;


namespace CZ.Domain.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set;}
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public bool IsActive { get; set; }

        public bool SpecialClient(Client clientobj)
        {
            return IsActive && DateTime.Now.Year - clientobj.DOB.Year > 50;
        }
    }
}
