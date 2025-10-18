using ConsoleApp18;

public class BankAccount
{
    public int AccountId { get; init; }
    private BankCard _firstCard = null!;
    public int CardId { get { return _firstCard.CardId; }}
    public BankAccount(int accountId)
    {
        AccountId = accountId;
        _firstCard = new BankCard(1);
    }
    private class BankCard
    {

        public int CardId { get; set; }
        public BankCard(int cardId)
        {
            CardId = cardId;
        }
    }
}
class Program
{
    static void Main()
    {
        var romanBankAccount = new BankAccount(1);
        Console.WriteLine(romanBankAccount.CardId);
        Console.WriteLine(romanBankAccount.AccountId);
        using (var dbContext = new AppDbContext())
        {
            // Создание категорий
            var foodCategory = new Category("Еда", "Продукты питания", null!);
            var toolsCategory = new Category("Инструменты", "Рабочие инструменты", null!);
            var clothingCategory = new Category("Одежда", "Модная одежда", null!);
            var electronicsCategory = new Category("Электроника", "Бытовая электроника", null!);


            // Создание продуктов
            var food = new List<Product>
                {
                    new Product("Хлеб", "Пшеничный хлеб", 2.5m, foodCategory),
                    new Product("Молоко", "Свежее молоко", 1.5m, foodCategory)
                };
            var tools = new List<Product>
                {
                    new Product("Молоток", "Строительный молоток", 10.0m, toolsCategory),
                    new Product("Отвертка", "Крестовая отвертка", 5.0m, toolsCategory),
                    new Product("Гвозди", "Строительные гвозди", 1.0m, toolsCategory)
                };
            var clothing = new List<Product>
                {
                    new Product("Футболка", "Хлопковая футболка", 15.0m, clothingCategory),
                    new Product("Джинсы", "Джинсы унисекс", 30.0m, clothingCategory)
                };
            var electronics = new List<Product>
                {
                    new Product("Смартфон", "Современный смартфон", 500.0m, electronicsCategory),
                    new Product("Наушники", "Беспроводные наушники", 100.0m, electronicsCategory),
                    new Product("Планшет", "Планшет с высоким разрешением", 300.0m, electronicsCategory)
                };

            foodCategory.Products = food;
            toolsCategory.Products = tools;
            clothingCategory.Products = clothing;
            electronicsCategory.Products = electronics;

            // Создание пользователей
            List<User> users = new List<User>()
                {
                    new User("Валерий", "valery@example.com", "000000", null!),
                    new User("Дмитрий", "Dmitry.com", "111111", null!),
                    new User("Анна", "anna@example.com", "222222", null!),
                    new User("Иван", "ivan@example.com", "333333", null!),
                    new User("Мария", "maria@example.com", "444444", null!),
                    new User("Сергей", "sergey@example.com", "555555", null!)
                };

            // Создание заказов
            List<Order> orders = new List<Order>()
                {
                    new Order(DateTime.Now, "В обработке", users[0], food),
                    new Order(DateTime.Now, "Отправлен", users[1], tools),
                    new Order(DateTime.Now, "В обработке", users[2], clothing),
                    new Order(DateTime.Now, "Отправлен", users[3], electronics),
                    new Order(DateTime.Now, "В обработке", users[0], electronics),
                    new Order(DateTime.Now, "Отправлен", users[1], clothing)
                };

            users[0].Orders = new List<Order>() { orders[0] };
            users[1].Orders = new List<Order>() { orders[1] };
            users[2].Orders = new List<Order>() { orders[0] };
            users[3].Orders = new List<Order>() { orders[1] };
            users[4].Orders = new List<Order>() { orders[2] };
            users[5].Orders = new List<Order>() { orders[3] };

            // Добавление заказов в списки заказов пользователей

            dbContext.Users.AddRange(users);
            dbContext.SaveChanges();

            string productName = "Смартфон";
            var ordersWithSmartphone = dbContext.Orders
            .Where(o => o.Products.
            Any(p=>p.Name == productName))
            ;
            var usersNameOrderSmartPhones = ordersWithSmartphone
            .Join(dbContext.Users,
            o => o.User.UserId,
            u => u.UserId,
            (o, u) =>
            new
            {
                u.UserId,
                u.UserName,
                o.OrderId,
                o.OrderDate
            });

            foreach (var user in usersNameOrderSmartPhones)
            {
                Console.WriteLine($"id пользователя{user.UserId}");
            }
         
        }
    }
}
// db context
// bankcARD
//BANKaMOUNT