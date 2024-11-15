namespace CalculadoraParrtidasRankeadas
{
    public class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Digite a quantidade de vitórias: ");
                int vitorias = int.Parse(Console.ReadLine());

                Console.Write("Digite a quantidade de derrotas: ");
                int derrotas = int.Parse(Console.ReadLine());

                int saldoVitorias = CalculaSaldo(vitorias, derrotas);

                string nivel = "";
                if (saldoVitorias <= 10) nivel = "Ferro";
                else if (saldoVitorias >= 11 && saldoVitorias <= 20) nivel = "Bronze";
                else if (saldoVitorias >= 21 && saldoVitorias <= 50) nivel = "Prata";
                else if (saldoVitorias >= 51 && saldoVitorias <= 80) nivel = "Ouro";
                else if (saldoVitorias >= 81 && saldoVitorias <= 90) nivel = "Diamante";
                else if (saldoVitorias >= 91 && saldoVitorias <= 100) nivel = "Lendário";
                else if (saldoVitorias >= 101) nivel = "Imortal";
                else
                {
                    Console.WriteLine("Saldo inválido");
                    return;
                }

                Console.WriteLine($"\nO Herói tem saldo de {saldoVitorias} está no nível de {nivel}.");
                Console.WriteLine("Aperte qualquer botão para reiniciar o programa.");
                Console.ReadKey();
                Console.Clear();
            } while (true);
        }

        public static int CalculaSaldo(int vitorias, int derrotas)
        {
            return vitorias - derrotas;
        }
    }
}