using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ScreenSound_04.Desafios;

namespace ScreenSound_04.Desafios
{
    internal class Desafio_01_01_BuscarPromo
    {
        public static async Task BuscarPromocoes()
        {
            using (HttpClient cliente = new HttpClient())
            {
                try
                {
                    // Definindo um cabeçalho opcional (às vezes necessário)
                    cliente.DefaultRequestHeaders.Add("User-Agent", "CSharpApp");

                    // Fazendo a requisição GET na API
                    HttpResponseMessage resposta = await cliente.GetAsync("https://www.cheapshark.com/api/1.0/deals");

                    // Verificando se a resposta foi bem-sucedida
                    if (resposta.IsSuccessStatusCode)
                    {
                        string conteudo = await resposta.Content.ReadAsStringAsync();

                        // Desserializando o JSON para uma lista de objetos
                        List<Desafio_01_01_Jogo> jogos = JsonSerializer.Deserialize<List<Desafio_01_01_Jogo>>(conteudo) ?? new List<Desafio_01_01_Jogo>();

                        // Exibindo os jogos em promoção
                        Console.WriteLine("\n🎮 Promoções de Jogos no CheapShark 🎮\n");
                        if (jogos.Count > 0)
                        {
                            foreach (var jogo in jogos)
                            {
                                Console.WriteLine($"🕹️ {jogo.Title}");
                                Console.WriteLine($"💰 De: ${jogo.NormalPrice} -> Por: ${jogo.SalePrice}");
                                Console.WriteLine($"🔗 Link: https://www.cheapshark.com/redirect?dealID={jogo.DealID}");
                                Console.WriteLine(new string('-', 40));
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nenhuma promoção encontrada.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Erro na requisição: {resposta.StatusCode}");
                    }
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Erro de requisição: {e.Message}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Erro inesperado: {e.Message}");
                }
            }
        }
    }
}
