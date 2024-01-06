using Microsoft.Win32.SafeHandles;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        string divisor = "___________________________\n";

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }



        //ADICIONAR VEÍCULO
        public void AdicionarVeiculo()
        {
            Console.WriteLine(divisor);
            Console.WriteLine("Digite a placa do veículo para estacionar:");

            string placa = Console.ReadLine();
            veiculos.Add(placa.ToUpper());

            Console.WriteLine("Placa registrada com sucesso!");

            if(placa == "")
            {
                Console.WriteLine("Placa não reconhecida. Digite novamente a opção para Cadastrar.");
            }

            Console.WriteLine(divisor);
        }




        //REMOVER VEÍCULO
        public void RemoverVeiculo()
        {
            Console.WriteLine(divisor);
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            try
            {
            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                
                int horas = 0;
                decimal valorTotal = 0; 


                horas = Convert.ToInt32(Console.ReadLine());
                valorTotal = precoInicial + precoPorHora * horas;


                veiculos.Remove(placa.ToUpper());
                Console.WriteLine($"O veículo {placa.ToUpper()} foi removido com sucesso e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
            }
            }
            //Se o valor da variável 'horas' for vazio, então executa o CATCH
            catch
            {
                Console.WriteLine("Algo deu errado. Placa ou Quantidade de Horas não foram digitadas corretamente.\nTente novamente.");
            }

            Console.WriteLine(divisor);
        }





        //LISTAR VEÍCULO
        public void ListarVeiculos()
        {
            Console.WriteLine(divisor);

            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                for(int contador = 0; contador < veiculos.Count; contador++)
                {
                    Console.WriteLine($"{veiculos[contador]}");
                }
                
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }

            Console.WriteLine(divisor);
        }
    }
}
