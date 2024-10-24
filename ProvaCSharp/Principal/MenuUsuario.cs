using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bergs.ProvacSharp
{
    public class MenuUsuario
    {

        public void Menu()
        {
            bool sistemaOn = true;

            while (sistemaOn)
            {
                Console.WriteLine("\nSaldo atual: \n");
                Console.WriteLine("Opção 1: Efetuar crédito em conta");
                Console.WriteLine("Opção 2: Adicionar chave favorita");
                Console.WriteLine("Opção 3: Listar chaves favoritas");
                Console.WriteLine("Opção 4: Enviar PIX");
                Console.WriteLine("Opção 5: Persistir chaves");
                Console.WriteLine("Opção 6: Sair do sistema.");

                Console.Write("\nInforme a opção desejada:");

                int opcao = Convert.ToInt16(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        //Conta conta = new Conta();
                        //conta.CreditarConta();
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:

                        break;

                    case 5:

                        break;

                    case 6:
                        sistemaOn = false;
                        Console.WriteLine("\nFechando Sistema...\n");
                        break;

                }


                
            }
        }
    }
}
