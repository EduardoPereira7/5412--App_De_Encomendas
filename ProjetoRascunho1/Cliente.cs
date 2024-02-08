using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DeliciasCaseiras
{
    public class Cliente
    {
        private static int ultimoId = 0;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public Cliente()
        {
            this.Nome = "nome";
            this.Endereco = "endereco";
            this.Telefone = "123456789";
            this.Id = ++ultimoId;
        }
        public Cliente(int id, string nomeCliente, string enderecoCliente, string telefoneCliente)
        {
            this.Nome = nomeCliente;
            this.Endereco = enderecoCliente;
            this.Telefone = telefoneCliente;
            this.Id = id;
        }
        public override string ToString()
        {
            return Id + " - " + Nome;
        }
        public static List<Cliente> CarregarClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            if (File.Exists("ClientesFile.txt"))
            {
                string[] linhas = File.ReadAllLines("ClientesFile.txt");
                foreach (string linha in linhas)
                {
                    string[] campos = linha.Split(';');
                    string nome = campos[0];
                    string endereco = campos[1];
                    string telefone = campos[2];
                    int id = int.Parse(campos[3]);
                    Cliente cliente = new Cliente(id, nome, endereco, telefone);
                    cliente.Id = id;
                    clientes.Add(cliente);
                    if (id > ultimoId)
                    {
                        ultimoId = id;
                    }
                }
            }
            return clientes;
        }
        public static void GuardarClientes(List<Cliente> clientes)
        {
            clientes = clientes.OrderBy(c => c.Id).ToList();
            using (StreamWriter writer = new StreamWriter("ClientesFile.txt"))
            {
                foreach (Cliente cliente in clientes)
                {
                    string linha = $"{cliente.Nome};{cliente.Endereco};{cliente.Telefone};{cliente.Id}";
                    writer.WriteLine(linha);
                }
            }
        }
    }
}
