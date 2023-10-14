using System;
using YGYK5_5.Abstract;

namespace YGYK5_5.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}