namespace January24
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                // создаем два объекта User
                People tom = new People { Name = "Tom", Age = 33 };
                People alice = new People { Name = "Alice", Age = 26 };

                // добавляем их в бд
                db.Peoples.Add(tom);
                db.Peoples.Add(alice);
                db.SaveChanges();  //только после этого данные обновятся в бд
                Console.WriteLine("Объекты успешно сохранены");

                foreach (var people in db.Peoples) //апдейт 
                {
                    people.Name += 1;
                }
                db.SaveChanges();

                //получаем объекты из бд и выводим на консоль

                var users = db.Peoples.ToList();
                Console.WriteLine("Список объектов:");
                foreach (People u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }


            }

        }

    }
}