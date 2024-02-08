using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliciasCaseiras
{
    public class Bebida : Pedido
    {
        public string nome { get; set; }
        public string descricao { get; set; }
        private double _preco;
        public double preco
        {
            get { return _preco; }
            set
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(value.ToString(), @"\d+(\,\d{1,2})?"))
                {
                    throw new ArgumentException("O campo preço deve conter apenas números e no máximo duas casas decimais separadas por vírgula.");
                }
                _preco = value;
            }
        }
        public static List<Bebida> bebidas_List = new List<Bebida>() {
        new Bebida { nome = "IcedTea", descricao = "Lata 350ml", preco = 1.20},
        new Bebida { nome = "Sumol", descricao = "Lata 300ml", preco = 1.50 },
        new Bebida { nome = "Cerveja", descricao = "355ml", preco = 3.00 }
        };
        public Bebida()
        {
            nome = "";
            descricao = "";
            preco = 0;
        }
        public Bebida(string nome)
        {
            this.nome = nome;
        }
        public Bebida(string nome, string descricao, double preco)
        {
            this.nome = nome;
            this.descricao = descricao;
            this.preco = preco;
        }
        public override string ToString()
        {
            return nome + " / " + descricao + " / " + preco.ToString("C2");
        }
        // Métodos para adicionar e remover bebidas da lista
        public static void AdicionarBebida(Bebida bebida)
        {
            bebidas_List.Add(bebida);
        }
        public static void RemoverBebida(Bebida bebida)
        {
            bebidas_List.Remove(bebida);
        }
        // Método para retornar a lista de bebidas
        public static List<Bebida> GetBebidasList()
        {
            return bebidas_List;
        }
        public string DisplayMember
        {
            get { return nome + " / " + preco.ToString("C2"); }
        }
    }
}
