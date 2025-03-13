using ScreenSound_04.Desafios;

class Program
{
    static async Task Main()
    {

        //using (HttpClient cliente = new HttpClient()) // Cria uma instância do HttpClient para fazer a requisição HTTP.
        //{
        //    try // Início do bloco try para capturar possíveis erros durante a requisição.
        //    {
        //        string resposta = await cliente.GetStringAsync("https://raw.githubusercontent.com/guilhermeonrails/api-csharp-songs/main/songs.json");
        //        // Faz uma requisição GET para obter o conteúdo do arquivo JSON disponível no GitHub.

        //        Console.WriteLine($"Resposta do servidor é: {resposta} \n\n");
        //    }
        //    catch (Exception e) // Captura qualquer exceção que ocorra dentro do bloco try.
        //    {
        //        Console.WriteLine("Erro: " + e.Message);
        //    }
        //}

        //Desafio 1
        //await Desafio_01_01_BuscarPromo.BuscarPromocoes();

        //Desafio 2
        //Console.WriteLine("Digite o valor de A: ");
        //int valorA = Desafio_01_02.LerNumero();

        //Console.WriteLine("Digite o valor de B: ");
        //int valorB = Desafio_01_02.LerNumero();

        //double resultado = Desafio_01_02.Dividir(valorA, valorB);
        //Console.WriteLine($"O resultado da divisão de {valorA} por {valorB} é: {resultado}");

        //Desafio 3
        //Desafio_01_03 TesteDesafio_1_3 = new Desafio_01_03();
        //Console.Write("Para buscar o valor de um indice na lista, digite um número inteiro maior que 0: ");
        //int valorDesafio3 = Desafio_01_03.LerIndice();
        //TesteDesafio_1_3.AcessarIndice(valorDesafio3);

        //Desafio 4
        try
        {
            // Criando um objeto nulo
            Desafio_01_04 objetoNulo = null;

            // Tentando chamar um método em um objeto nulo
            objetoNulo.Metodo();
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine($"Exceção capturada: {ex.Message}");
        }


    }
}