
using MongoDB.Bson;
using MongoDB.Driver;

namespace InnoClinic.Presentation.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddSingleton(new MongoClient("mongodb://localhost:27017").GetDatabase("test")); 
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.MapGet("/", async (IMongoDatabase db) =>
            {
                var collection = db.GetCollection<BsonDocument>("users");

                if (await collection.CountDocumentsAsync("{}") == 0)
                {
                    await collection.InsertManyAsync(new List<BsonDocument>
                    {
                        new BsonDocument { { "Name", "Tom" } }
                    
                    });
                }
                var users = await collection.Find("{}").ToListAsync();
                return users.ToJson();
            });

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
