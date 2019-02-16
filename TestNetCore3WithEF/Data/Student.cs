using System;
using System.ComponentModel.DataAnnotations;

namespace TestNetCore3WithEF.Data
{

    public class Student
    {
        [Key]
        public Guid Id { get; set; }

        public Guid StudentId { get; set; }

        public string Name { get; set; }

    }
}
