using System;
using System.IO;
using System.Linq;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Combine("disposable_task_file_2.txt");

            ProcessFile(path);

        }

        static void ProcessFile(string path)
        {
            //if (File.Exists(path))
            //{
            //    var content = File.ReadAllLines(path);
            //    File.WriteAllLines($"{path}", content.Select(int.Parse).Select(x=> Math.Pow(x,2)).Select(x => x.ToString()));
            //}

            if (File.Exists(path))
            {
                string[] content;

                using (FileStream filestream = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(filestream))
                    {
                        content = sr.ReadToEnd().Split("\r\n");
                    }
                }

                using (FileStream filestream = new FileStream(path, FileMode.Open, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(filestream))
                    {
                        foreach (var item in content)
                        {
                            if (int.TryParse(item, out int temp))
                            {
                                sw.WriteLine(Math.Pow(temp, 2).ToString());
                            }
                        }

                    }
                }
            }
        }
    }
}
