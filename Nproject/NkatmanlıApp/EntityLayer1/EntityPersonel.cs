using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
  public class EntityPersonel
    {
        private int id; 
        private string name;
        private string surname;
        private string city;
        private string gorev;
        private short maas;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }    
        public string Surname { get => surname; set => surname = value; }   
        public string City { get => city; set => city = value; }
        public string Gorev { get => gorev; set => gorev = value; } 
        public short Maas { get => maas; set => maas = value; }  
    }
}
