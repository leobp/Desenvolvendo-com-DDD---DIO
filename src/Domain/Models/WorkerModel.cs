using System;

namespace Domain.Models
{
    public class WorkerModel
    {
        public WorkerModel(int id, string name, DateTime birthDate, string cpf, string salary)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
            Nin = cpf;
            Salary = salary;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public string Nin { get; set; }

        public string Salary { get; set;}
    }
}
