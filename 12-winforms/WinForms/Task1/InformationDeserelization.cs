using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System.Linq;
using System.ComponentModel;

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
