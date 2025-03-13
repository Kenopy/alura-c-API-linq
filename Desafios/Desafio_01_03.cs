
namespace ScreenSound_04.Desafios
{
    internal class Desafio_01_03
    {
        //Declarar lista de inteiros
        List<int> listaInteiros = [155,243,23342,543,13,67];

        //Tentar acessar um elemento em um índice inexistente
        public static int LerIndice()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int valor) && valor > 0)
                {
                    return valor - 1; // Retorna o número válido subtraído de 1
                }
                Console.Write("\nEntrada inválida! Digite um número inteiro maior que 0: ");

            }
        }
        public void AcessarIndice(int valor)
        {
            try
            {
                Console.WriteLine($"O valor no indice {valor} é: {listaInteiros[valor]}");
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }

    }
}
