using System.Text.Json.Serialization;

namespace ApiCrud.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CategoryEnum
    {
        Eletrônicos,
        Roupas,
        Alimentos,
        Livros,
        Brinquedos,
        Outros
    }
}