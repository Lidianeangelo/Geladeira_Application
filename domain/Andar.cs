namespace Domain
{
    public class Andar
    {
        public int numero;
        public string setor;

        public int Numero { get; set; } = 0;
        public string Setor { get; set; } = "Nome do Setor";
        public Andar(int numero, string setor) {
            this.numero = numero;
            this.setor = setor;
        }
        /*List<Floor> list =new();
        list.Add(andar1); 3x

        ou if list.Count == 3 { faz a logica}
        
         if list.count != 3 {throw Exception("Quantidades de andares invalida")}
        ou

        if list.count != 3 {throw Exception("Quantidades de andares invalida")}
        List<container>

        if lstContainer.count != 2 {throw new Exception(...)}

        
         */

    }
}
