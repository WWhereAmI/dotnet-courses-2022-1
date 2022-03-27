namespace Task2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Office office = new Office();

            Person person = new Person("Alexander");
            Person person2 = new Person("Misha");
            Person person3 = new Person("Danila");
            Person person4 = new Person("Artem");

            

            office.Come(person);
            office.Come(person2);
            office.Leave(person2);
            office.Come(person4);
            office.Come(person3);
            office.Leave(person);

        }
    }
}
