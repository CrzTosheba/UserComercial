using System;
using System.Collections;


namespace UserComercial
{
    class Program
    {
        static void Main(string[] args)
        {

            List<User> listOfUsers = new List<User>()
            {
        new User() { Name = "Надя", Login = "Nada", IsPremium = true },
        new User() { Name = "Петя", Login = "Petruha" , IsPremium = false},
        new User() { Name = "Вова", Login = "VOlvec" , IsPremium = false},
            };
            foreach (var user1 in listOfUsers)
            {
                Console.WriteLine(user1.Login);
            }
            var login = Console.ReadLine();
            var user = listOfUsers.Where(u => u.Login == login).FirstOrDefault();




            if (user == null)
            {
                Console.WriteLine($"Пользователь {login} не найден");

            }
            else
            {
                Console.WriteLine($"Привет! {user.Name}");
                if (!user.IsPremium)

                    ShowAds();
            }
        }


        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }

        class User
        {
            public string Login { get; set; }
            public string Name { get; set; }
            public bool IsPremium { get; set; }
        }

    }
}