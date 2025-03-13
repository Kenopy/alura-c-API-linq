using System.Text.Json.Serialization;

public class Desafio_01_01_Jogo
{
    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("salePrice")]
    public string SalePrice { get; set; }

    [JsonPropertyName("normalPrice")]
    public string NormalPrice { get; set; }

    [JsonPropertyName("dealID")]
    public string DealID { get; set; }
}