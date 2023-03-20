namespace JogoDaAdivinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String strDificuldade;
            int dificuldade = 0;
            bool status;
            int tentativa;
            bool verificaNumero;
            Double pontuacao = 1000;
            Random random = new Random();
            int numeroRnd = random.Next(1, 20);
            do
            {
                status = false;
                Console.WriteLine("1 - Facil (15 tentativas)");
                Console.WriteLine("2 - Mediano (10 tentativas)");
                Console.WriteLine("3 - Dificil (5 tentativas)");
                Console.WriteLine("Informe a dificuldade desejada:");
                strDificuldade = Console.ReadLine();
                switch (strDificuldade)
                {
                    case "1": dificuldade = 5; break;
                    case "2": dificuldade = 10; break;
                    case "3": dificuldade = 15; break;
                    default:
                        status = true;
                        break;
                }
                if (status)
                {
                    Console.Clear();
                    Console.WriteLine("Informe uma opcao valida!");
                }
            } while (status);
            Console.WriteLine("O numero secreto esta entre 1 e 20.");
            for (int i = 0; i < dificuldade; i++)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Tentativa: " + (i + 1));
                Console.WriteLine($"Qual o numero da sua {i+1}o tentiva?");
                Console.Write("Numero: ");
                String strTentativa = Console.ReadLine();
                verificaNumero = int.TryParse(strTentativa, out tentativa);
                if (verificaNumero && tentativa < 21 && tentativa > 0)
                {
                    pontuacao -= Math.Abs((tentativa - numeroRnd) / 2);
                    Console.WriteLine("Sua pontuacao: " + pontuacao);
                    if (tentativa == numeroRnd)
                    {
                        Console.WriteLine("Parabens! Voce acertou!");
                        status = true;
                        break;
                    }
                    else if (tentativa > numeroRnd)
                    {
                        Console.WriteLine("Numero informado e maior que o numero secreto.");
                    }else if (tentativa < numeroRnd)
                    {
                        Console.WriteLine("Numero informado e menor que o numero secreto.");
                    }
                }
                else
                {
                    Console.WriteLine("Informe um numero valido entre 1 e 20!");
                }
            }
            if (!status)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Suas chances acabaram... Voce perdeu o jogo!");
            }


            Console.WriteLine();
        }
    }
}