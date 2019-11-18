using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab14
{
    public class TodoItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string FechaNaci { get; set; }
    }
}
