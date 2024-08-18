using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Item
    {
        public int Id { get; set; }= 0;
        public string Name { get; set; } = "Nome";
        public string Description { get; set; } = "Descrição";
        
        public double Price { get; set; } = 0;


        public string InserirItem(int id, string name, string description, double price) {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Price = price;

            return $"Item inserido: Id={Id}, Name={Name}, Description={Description}, Price={Price}";

        }

    }
}
