using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bergs.ProvacSharp
{
    public class Conta
    {

        private decimal saldo;
        public string caminhoDB;
        

        public Conta(string localDB)
        {
            caminhoDB = localDB;
        }

        public Retorno CreditarConta(string strValor) //strValor precisa ser String?
        {
            try
            {
                //decimal valor = Convert.ToDecimal(strValor);
                Console.Write("Insira um valor a ser creditado:");
                decimal valor = Convert.ToDecimal(Console.ReadLine());
                ValidarValor(valor);
                saldo += Convert.ToDecimal(strValor);

                
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Erro: 20 {ex.Message}");//precisa retornar o objeto

            }

            return null; //Falta arrumar retorno como objeto...
            //return Retorno;
        }

        public Retorno AdicionarChaveFavorita(string strNome, string strTipo, string strChave)
        {
            try
            {
                Console.Write("Insira um nome:");
                string nome = Console.ReadLine();

                Console.Write("Insira um tipo de chave: 1-Telefone ou 2-CPF");
                TiposChave tipo = default(TiposChave);

                Console.Write("Insira uma chave: ");
                string chave = Console.ReadLine();

                ValidarChaves(nome, tipo, chave);

            }
            catch(Exception ex)
            {
                Console.WriteLine($"Erro: 30 {ex.Message}");//precisa retornar o objeto
            }

            return null;
        }

        public RetornoListaChave ListarChavesFavoritas()
        {


            return null;
        }

        public Retorno EnviarPix(string strChave, string strValor)
        {
            return null;
        }

        public Retorno Persistir()
        {
            return null;
        }

        public void ValidarValor(decimal valor)
        {
            if (valor <= 0)
            {
                throw new Exception("Erro: 20. Valor menor ou igual a zero");
            }
        }

        public void ValidarChaves(string nome, TiposChave tipo, string chave)
        {
            string regexCpf = "^\\d{11}$";
            string regexTelefone = "^\\+[1-9][0-9]\\d{11}$";

            if (tipo != TiposChave.telefone || tipo != TiposChave.cpf)
            {
                throw new Exception($"Erro 30: ");
            }
            //else if(chave == ChaveFavorita.chave)
            //{
            //throw new Exception($"Erro 65: ");
            //}
            else if (System.Text.RegularExpressions.Regex.IsMatch(chave, regexCpf))
            {
                throw new Exception($"Erro 40: ");
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(chave, regexTelefone))
            {
                throw new Exception($"Erro 50: ");
            }
        }
    }
}
