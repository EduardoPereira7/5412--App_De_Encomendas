using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliciasCaseiras
{
    public class Prato : Pedido
    {
        public string nome { set; get; }
        public string descricao {set; get; }
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
        public static List<Prato> pratos_List = new List<Prato>()
        {
            new Prato { nome = "Arroz de pato", descricao = "Porção individual", preco = 12.00 },
            new Prato { nome = "Strogonoff de frango", descricao = "Porção individual", preco = 15.00 },
            new Prato { nome = "Lasanha à bolonhesa", descricao = "Porção individual", preco = 9.00 }
        };
        public Prato()
        {
            this.nome = "";
            this.descricao = "";
            this.preco = 0;
        }
        public Prato(string nome)
        {
            this.nome = nome;
        }
        public Prato(string nomePrato, string descricaoPrato, double precoPrato)
        {
            this.nome = nomePrato;
            this.descricao = descricaoPrato;
            this.preco = precoPrato;
        }
        public override string ToString()
        {
            return nome + " / " + descricao + " / " + preco.ToString("C2");
        }
        public static void AdicionarPrato(Prato prato)
        {
            pratos_List.Add(prato);
        }
        public static void RemoverPrato(Prato prato)
        {
            pratos_List.Remove(prato);
        }
        public static List<Prato> GetPratosList()
        {
            return pratos_List;
        }
        public string DisplayMember
        {
            get { return nome + " / " + preco.ToString("C2"); }
        }
    }
}
