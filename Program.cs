using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetodosArray.Modelos;
using MetodosArray.Modelos.Funcionarios;

namespace MetodosArray.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(2323,22323);

            Cliente client1 = new Cliente();
            client1.Nome = "Luccas";
            client1.Profissao = "Programador";


            Cliente client2 = new Cliente();
            client2.Nome = "Luccas";
            client2.Profissao = "Programador";

            if (client1.Equals(client2))
            {
                Console.WriteLine("São iguais");
            }


            Console.WriteLine(conta.ToString());

            int[] idades = new int[5];

            idades[0] = 2;
            idades[1] = 3;
            idades[2] = 4;
            idades[3] = 5;
            idades[4] = 6;

            int totalMedia = 0;

            foreach(int idade in idades)
            {
               
                totalMedia += idade;
            }
            Console.WriteLine(totalMedia / idades.Length);

            totalMedia = 0;
            for (int i = 0; i < idades.Length; i++)
            {
                totalMedia += idades[i];
                Console.WriteLine($"Acessando o indice {i}");
            }
            Console.WriteLine(totalMedia / idades.Length);


            bool[] items = new bool[5];

            Console.WriteLine(items[0]);
            

            ArrayLike arr = new ArrayLike(4);

            arr.addItemList(2);
            arr.addItemList(3);
            arr.addItemList(4);
            arr.addItemList(5);

            arr.removeItem();
            foreach (int item in arr.retorneItem())
            {
                Console.WriteLine(item);
            }


            ContaCorrente[] contas = new ContaCorrente[] 
            {

             new ContaCorrente(212324, 5657),
            new ContaCorrente(34343, 6798),
            new ContaCorrente(45476, 78790),
            new ContaCorrente(45476, 78790),

        };

         

            for (int countLOOP = 0; countLOOP < contas.Length; countLOOP++)
            {
                ContaCorrente contaAtual = contas[countLOOP];

                Console.WriteLine($"O número da conta {contaAtual.NumeroConta} no indice {countLOOP}");
            }
            Console.ReadLine();

        }
    }
}
