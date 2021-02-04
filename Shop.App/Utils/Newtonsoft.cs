using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Shop.App.Utils
{
    public class Newtonsoft
    {
        public static IEnumerable<TResult> ReadJson<TResult>(string data)
        {
            var stream = GenerateStreamFromString(data);

            var serializer = new JsonSerializer();

            using (var reader = new StreamReader(stream))
            using (var jsonReader = new JsonTextReader(reader))
            {
                jsonReader.SupportMultipleContent = true;

                while (jsonReader.Read())
                {
                    yield return serializer.Deserialize<TResult>(jsonReader);
                }
            }
        }
        private static Stream GenerateStreamFromString(string s)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        public static IEnumerable<TResult> LoadJson2<TResult>(string path)
        {
            List<TResult> items;
            using (StreamReader r = new StreamReader(@"c:/arquivos/estudo/projetos/Shop/dataset/amazon.books.json"))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<TResult>>(json);
            }
            return items;
        }

        public static IEnumerable<TResult> LoadJson<TResult>()
        {
           var data = JsonConvert.DeserializeObject<TResult>(File.ReadAllText(@"c:/arquivos/estudo/projetos/Shop/dataset/amazon.books.json"));
            return null;
        }

    }
}