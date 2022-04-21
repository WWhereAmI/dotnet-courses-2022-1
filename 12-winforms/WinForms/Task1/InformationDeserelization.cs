using System.ComponentModel;
using System.IO;
using System.Text.Json;

namespace Task1
{
    internal class InformationDeserelization<T>
    {
        public static BindingList<T> DeserilizeJson(string fileName)
        {

            string json = File.ReadAllText(fileName);

            return JsonSerializer.Deserialize<BindingList<T>>(json);

        }

    }
}
