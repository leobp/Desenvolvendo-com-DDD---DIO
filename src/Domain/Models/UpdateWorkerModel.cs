using System;

namespace Domain.Models
{
    public class UpdateWorkerModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public string Nin { get; set; }

        public int Salary {get; set;}
    }
}
