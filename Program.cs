using System.Text.Json;

namespace Assignment10._1
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }
        public bool IsMale { get; set; }

    }

    class Program
    {
        static void Main()
        {
            var Roxi = new Animal
            {
                Name = "Roxi",
                Age = 9,
                Length = 32,
                Weight = 58,
                IsMale = false,


            };

            string jsonString = JsonSerializer.Serialize(Roxi);

            Console.WriteLine(jsonString);





            string JsonString = "{\"Name\":\"Roxi\",\"Age\":9,\"Length\":32,\"Weight\":58,\"IsMale\":false}";

            Animal deserializedRoxi = JsonSerializer.Deserialize<Animal>(JsonString);

            Console.WriteLine($"Deserialized Name: {deserializedRoxi.Name}");

            Console.WriteLine($"Deserialized Age: {deserializedRoxi.Age}");

            Console.WriteLine($"Deserialized Length: {deserializedRoxi.Length}");

            Console.WriteLine($"Deserialized Weight: {deserializedRoxi.Weight}");

            Console.WriteLine($"Deserialized IsMale: {deserializedRoxi.IsMale}");
        } 
    }
}

