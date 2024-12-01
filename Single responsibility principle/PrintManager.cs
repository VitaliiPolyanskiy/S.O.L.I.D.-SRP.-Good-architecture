namespace Single_responsibility_principle
{
    class PrintManager
    {
        #region Печать данных - единственная ответственность       
        public void Print(List<Human> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Список пуст!");
                return;
            }
            foreach (Human j in list)
            {
                Console.WriteLine(j.Name + "\t" + j.Age);
            }
        }
        #endregion
    }
}
