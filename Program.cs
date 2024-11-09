using System.Text;
using Sisk.Core.Http;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        using var app = HttpServer.CreateBuilder(port: 5555)
            .UseRouter(r =>
            {
                r.MapGet("/goods", (HttpRequest request) =>
                {
                    var context = new FirebirdContext();
                    var json = JsonSerializer.Serialize(context.Goods.ToArray(),
                        new JsonSerializerOptions() { WriteIndented = true });
                    return new HttpResponse()
                    {
                        Status = 200,
                        Content = new StringContent(json, Encoding.UTF8, "application/json")
                    };
                });
            })
            .Build();

        app.Start();
    }
}