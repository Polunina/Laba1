
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NoteBookApp
{
    public class Note
    {
        // public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int Number { get; set; }
        public string Country { get; set; }
        public string Date { get; set; }
        public string Work { get; set; }
        public string Position { get; set; }
        public string Other { get; set; }


        public override string ToString()
        {
            return $"{Surname} {Name} {Patronymic} {Number} {Country} {Date} {Work} {Position} {Other}";
        }

    }
}