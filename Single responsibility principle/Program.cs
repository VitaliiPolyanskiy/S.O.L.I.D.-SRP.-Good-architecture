namespace Single_responsibility_principle
{
    class Program
    {
        static void Main(string[] args)
        {
            Сontainer c = new Сontainer();
            c.Add(new Human("Larry Page", 50));
            c.Add(new Human("Satya Nadella", 56));
            c.Add(new Human("Tim Cook", 62));
            PrintManager manager = new PrintManager();
            List<Human> list = c.Get();
            manager.Print(list);
            HumanRepository repository = new HumanRepository();
            repository.SaveXmlSerializer(list);
            c.RemoveAll();
            list = c.Get();
            manager.Print(list);
            list = repository.LoadXmlSerializer();
            manager.Print(list);
        }
    }
}
