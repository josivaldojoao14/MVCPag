using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPage.Models
{
    public static class Dados 
    {
        private static List<Cliente> ListaDeClientes = new List<Cliente>();

        public static List<Cliente> TodosClientes()
        {
            // Vai retornar todos os clientes registrados
            return ListaDeClientes;
        }

        public static void AdicionarClientes(Cliente clienteTemp)
        {
            // indicamos qual o ID do determinado cliente a ser adicionado
            int id = 0;
            if (ListaDeClientes.Count != 0)
            {
                id = ListaDeClientes.Last<Cliente>().Id + 1;
            }

            // Salvamos os dados do novo cliente
            clienteTemp.Id = id;
            ListaDeClientes.Add(clienteTemp);
        }

        public static Cliente DadosCliente(int id)
        {
            // Devolve os dados do cliente selecionado
            Cliente clienteTemp = ListaDeClientes.Where(i => i.Id == id).FirstOrDefault();
            return clienteTemp;
        }

        public static void EditarClientes(Cliente c)
        {
            // Editamos os dados do cliente selecionado
            ListaDeClientes.First<Cliente>(i => i.Id == c.Id).Nome = c.Nome;
            ListaDeClientes.First<Cliente>(i => i.Id == c.Id).SobreNome = c.SobreNome;
            ListaDeClientes.First<Cliente>(i => i.Id == c.Id).Telefone = c.Telefone;
        }

        public static void RemoverClientes(int id)
        {
            var clienteTemp = ListaDeClientes.First<Cliente>(i => i.Id == id);
            ListaDeClientes.Remove(clienteTemp);
        }
    }
}
