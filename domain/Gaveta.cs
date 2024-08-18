using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Gaveta
    {
        public List<Item> itens;
        public int Capacidade { get; set; } = 4;
        public int Count => itens.Count;


        // Construtor
        public Gaveta(List<Item> itensIniciais)
        {
            itens = itensIniciais ?? new List<Item>();
        }

        // Método para adicionar um item ao conteiner
        public void AdicionarItem(Item item)
        {

            itens.Add(item);
            //Console.WriteLine($"Item adicionado à gaveta: Id={item.Id}, Name={item.Name}, Description={item.Description}, Price={item.Price}"); ;

        }

        public void ListarItens()
        {
            Console.WriteLine("Itens na gaveta:");
            foreach (var item in itens)
            {
                Console.WriteLine($"Id={item.Id}, Name={item.Name}, Description={item.Description}, Price={item.Price}");
            }
        }

        public int LocalizarItemPorId(int id)
        {
            for (int i = 0; i < itens.Count; i++)
            {
                if (itens[i].Id == id)
                {
                    return i;
                }
            }
            return -1; // Item não encontrado


        }

        public Item LocalizarItemPorPosicao(int posicao)
        {
            if (posicao >= 0 && posicao < itens.Count)
            {
                return itens[posicao];
            }
            else
            {
                return null; // Posição inválida
            }
        }
    }
}
