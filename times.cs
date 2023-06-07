namespace desafiocsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string time1 = "Santos";
            string time2 = "Flamengo";
            string time3 = "Corinthians";
            string time4 = "São Paulo";

            int pontos1 = 0;
            int pontos2 = 0;
            int pontos3 = 0;
            int pontos4 = 0;

            string status = "";

            //TIME + G-ganhoou, E-empatou ou P-perdeu
            //ganhou = 3 pontos
            //empatou = 1 ponto
            //perdeu = 0 pontos

            for (int x=1; x<=3; x++)
            {
                Console.WriteLine("Rodada " + x);
                Console.WriteLine(time1 + "G-ganhoou, E-empatou ou P-perdeu: ");
                status = Console.ReadLine().ToUpper();
                if (status == "G")
                {
                    pontos1 += x;
                    pontos1 = pontos1+ 3;
                }
                else if (status == "E")
                {
                    pontos1 += 1;
                }
                else if (status == "P")
                {
                    pontos1 += 0;
                }
                else
                {
                    Console.WriteLine("Opção inválida...");
                }
            }



        }
    }
}
