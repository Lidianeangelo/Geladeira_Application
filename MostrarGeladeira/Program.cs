using Domain;

/*Item item1 = new Domain.Item();
Item item2 = new Domain.Item();

item1.Id = 0001;
item1.Name = "Banana";
item1.Description = "Nanica";
item1.Price = 4.00;*/

class Program
{
    static void Main(string[] args)
    {
        Item item1 = new Item();
        string cadastro = item1.InserirItem(0001, "Banana", "Nanica", 3.50);

        Item item2 = new Item();
        string cadastro2 = item2.InserirItem(0002, "Laranja", "Lima", 2.50);

        //Console.WriteLine(cadastro);

        List<Item> itensIniciais = new List<Item>();
        Gaveta gaveta = new Gaveta(itensIniciais);

        gaveta.AdicionarItem(item1);
        gaveta.AdicionarItem(item2);
        gaveta.ListarItens();

        // Localizar a posição dos itens na gaveta
        int posicao1 = gaveta.LocalizarItemPorId(1);
        if (posicao1 != -1)
        {
            Console.WriteLine($"Item com Id=1 localizado na posição {posicao1} da gaveta.");
        }
        else
        {
            Console.WriteLine("Item com Id=1 não encontrado na gaveta.");
        }

        int posicao2 = gaveta.LocalizarItemPorId(2);
        if (posicao2 != -1)
        {
            Console.WriteLine($"Item com Id=2 localizado na posição {posicao2} da gaveta.");
        }
        else
        {
            Console.WriteLine("Item com Id=2 não encontrado na gaveta.");
        }

        // Localizar item por posição
        Item itemNaPosicao = gaveta.LocalizarItemPorPosicao(1);
        if (itemNaPosicao != null)
        {
            Console.WriteLine($"Item localizado na posição 1: Id={itemNaPosicao.Id}, Name={itemNaPosicao.Name}, Description={itemNaPosicao.Description}, Price={itemNaPosicao.Price}");
        }
        else
        {
            Console.WriteLine("Nenhum item encontrado na posição 1.");
        }

    }
}

