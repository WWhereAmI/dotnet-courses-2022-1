using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Task1
{
    internal class InformationSerelization<T>
    {
        public static async void SerelizeList(IList<T> list, string fileName)
        {
            list = list ?? throw new ArgumentNullException(nameof(list));

            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                //Нормально делать return из using?
                await JsonSerializer.SerializeAsync(fs, list);
            }
          
        }

    }
}
