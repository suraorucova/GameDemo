using GameDemo.Abstract;
using System;

namespace GameDemo.Entities
{
    class Customer:IEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Possword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirgth { get; set; }
        public int NationalityId { get; set; }
    }
}
