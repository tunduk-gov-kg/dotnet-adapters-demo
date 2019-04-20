using System;

namespace Producer.Data
{
    public class Person
    {
        public string Pin { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public Gender Gender { get; set; }

        public byte[] Photo { get; set; }
    }
}