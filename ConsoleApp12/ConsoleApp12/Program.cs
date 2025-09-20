using CsvHelper.Configuration;
using System.Globalization;
using System;
using CsvHelper;
using CsvHelper.Configuration.Attributes;

internal class Program
{
    static void Main(string[] args)
    {
       
        // Создание StreamReader для чтения из файла "output.csv".
        StreamReader reader = new StreamReader("inventoryControl.csv");
        // Создание CsvReader с настройками и привязка к созданному
        //StreamReader.
        CsvReader csvRead = new CsvReader(reader, new
        CsvConfiguration(CultureInfo.InvariantCulture));
        // Чтение данных из файла "output.csv" и преобразование их в список

        List<Product> records = csvRead.GetRecords<Product>().ToList();
        // Не забываем закрыть поток файла после работы с ним
        reader.Close();
        // Отображение данных из списка на консоль.
        foreach (var product in records)
        {
            Console.WriteLine($"Имя товара: {product.Name} \n" +
                $"Количество товра: {product.Quantity}\n" +
                $"Цена товара: {product.Price}\n" +
                $"Описание товара: {product.Description}");
        }

        while (true)
        {
            Console.WriteLine("Какой столбец будем анализировать?");
            var choseText = Console.ReadLine();
            var isCortedData = false;

            switch( choseText )
            {
                case "1" or "Name":
                    Console.WriteLine("Этот столбец не поддается анализу");
                    isCortedData = false;
                    break;
                case "2" or "Quantity":
                    isCortedData = true;
                    break;
                case "3" or "Price":
                    isCortedData = true;
                    break;
                case "4" or "Description":
                   Console.WriteLine("Этот столбец не поддается анализу");
                    isCortedData = false;
                    break;
            }
            
            if (isCortedData)
            {
                while (true)
                {
                    Console.WriteLine("Выберите варианты сортировки:\n" +
                        "1.Узнать макисмальное значение.\n" +
                        "2.Узнать минимальное значение.\n" +
                        "3.Узнать среднее значение.\n");
                    choseText = Console.ReadLine();
                    switch ( choseText )
                    {
                        case "1" or "Max":
                            Console.WriteLine(records.Max(p=>p.Price));
                            break;
                        case "2" or "Min":
                            Console.WriteLine(records.Min(p=>p.Price));
                            break;
                        case "3" or "average":
                            {
                                Console.WriteLine(records.Average(p =>p.Price));
                                break;
                            }
                    }

                }
            }
        }
     
    }
}
    public class Product
    {

        [Name("Name")]
        public string Name { get; set; }
        [Name("Quantity")]
        public int Quantity { get; set; }
        [Name("Price")]
        public int Price { get; set; }
        [Name("Description")]
        public string Description { get; set; }
}
