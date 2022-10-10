namespace Unit12;

class Program
{
    class User
    {
        public User(string login, string name, bool isPremium)
        {
            Login = login;
            Name = name;
            IsPremium = isPremium;
        }

        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }
    }
    static void ShowAds()
    {
        //Создание объекта для генерации чисел
        Random rnd = new Random();
        //Получить случайное число (в диапазоне от 0 до 2)
        int value = rnd.Next(0, 2);
        switch (value)
        {
            case 0:
                Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
                // Остановка на 1 с
                Thread.Sleep(2000);
                break;
            case 1:
                Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
                // Остановка на 2 с
                Thread.Sleep(2000);
                break;
            case 2:
                Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
                // Остановка на 3 с
                Thread.Sleep(2000);
                break;
        }
    }
    static void Main(string[] args)
    {
        //Создадми пользователей
        User[] users = new[]
        {
            new User("login1", "User1", false),
            new User("login2", "User2", true),
            new User("login3", "User3", false),
            new User("login4", "User4", false),
            new User("login5", "User5", true),
            new User("login6", "User6", false),
            new User("login7", "User7", true)
        };
        //показать приветсвие
        foreach (User u in users)
        {
            //Приветсвие
            Console.WriteLine("Приветсвую: {0}", u.Name);
            //проверка на премиум
            if (u.IsPremium != true)
            {
                //покажем реклмау
                ShowAds();
            }
            Console.WriteLine("-------------------");
        }
        Console.ReadKey();
    }
}