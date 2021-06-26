public class Products
{
    public string Name{get; set;}
    public int ScreeSize{get; set;}
    public string Processor {get; set;}
    public string Connectivity {get; set;}
    public int OperatingSystem {get; set;}
    public int Battery {get; set;}
    public int RAM {get; set;}
    public int Storage {get; set;}
    public int Price {get; set;}

    public Products (string name, int screensize, char processor, char connectivity, string operatingsystem, int battery, int ram, int Storage)
    {
        Name = name;
        ScreeSize = screensize;
        Processor = processor;
        Connectivity = connectivity;
        OperatingSystem = operatingsystem;
        Battery = battery;
        RAM = ram;
        Storage = storage;
        Price = price;
    }
    
}
class Program
{
    static void Main()
    {
        Products laptop1 = new Products("HP Spectre", 17, i7, "5G", "Microsoft Windows", 5000, 16, 2, 30000 );
        Console.WriteLine("Laptop Name = {0} Screen Size = {1} Processor = {2} Connectivity = {3} Battery = {4} RAM = {5} Storage = {7}", laptop1.Name, laptop1.ScreeSize, laptop1.Processor, laptop1.Connectivity, laptop1.Battery, laptop1.RAM, laptop1.Storage);

        Products laptop2 = new Products("Dell XPS", 15, i7, "4G", "Microsoft Windows", 7000, 8, 1, 25000 );
        Console.WriteLine("Laptop Name = {0} Screen Size = {1} Processor = {2} Connectivity = {3} Battery = {4} RAM = {5} Storage = {7}", laptop2.Name, laptop2.ScreeSize, laptop2.Processor, laptop2.Connectivity, laptop2.Battery, laptop2.RAM, laptop2.Storage);

        Products laptop3 = new Products("Apple Macbook", 15, M1, Wifi, "MacOS", 5000, 8, 500, 35000 );
        Console.WriteLine("Laptop Name = {0} Screen Size = {1} Processor = {2} Connectivity = {3} Battery = {4} RAM = {5} Storage = {7}", laptop3.Name, laptop3.ScreeSize, laptop3.Processor, laptop3.Connectivity, laptop3.Battery, laptop3.RAM, laptop3.Storage);


        Products Tablet1 = new Products("Apple Ipad Pro", 12.9, M1, "5G", "IpadOS", 9720, 16, 2, 23000 );
        Console.WriteLine("Laptop Name = {0} Screen Size = {1} Processor = {2} Connectivity = {3} Battery = {4} RAM = {5} Storage = {7}", Tablet1.Name, Tablet1.ScreeSize, Tablet1.Processor, Tablet1.Connectivity, Tablet1.Battery, Tablet1.RAM, Tablet1.Storage);

        Products Tablet2 = new Products("Samsung Tab S7", 11.0, "Snapdragon 865", "5G", "MacOS", 8000, 8, 512, 20000 );
        Console.WriteLine("Laptop Name = {0} Screen Size = {1} Processor = {2} Connectivity = {3} Battery = {4} RAM = {5} Storage = {7}", Tablet2.Name, Tablet2.ScreeSize, Tablet2.Processor, Tablet2.Connectivity, Tablet2.Battery, Tablet2.RAM, Tablet2.Storage);

        Products Tablet3 = new Products("Huawei MatePad Pro", 12.6, "Kirrin 9000E", Wifi, "HarmonyOS", 10050, 8, 256, 15000 );
        Console.WriteLine("Laptop Name = {0} Screen Size = {1} Processor = {2} Connectivity = {3} Battery = {4} RAM = {5} Storage = {7}", Tablet3.Name, Tablet3.ScreeSize, Tablet3.Processor, Tablet3.Connectivity, Tablet3.Battery, Tablet3.RAM, Tablet3.Storage);


        Products Phone1 = new Products("Samsung S21 Ultra", 6.8, "Exynos 2100", "5G", "Android 10", 5000, 16, 256, 30000 );
        Console.WriteLine("Laptop Name = {0} Screen Size = {1} Processor = {2} Connectivity = {3} Battery = {4} RAM = {5} Storage = {7}", Phone1.Name, Phone1.ScreeSize, Phone1.Processor, Phone1.Connectivity, Phone1.Battery, Phone1.RAM, Phone1.Storage);

        Products Phone2 = new Products("Apple Iphone 13 Pro Max", 6.7, A14, "4G", "IOS 14", 3687, 6, 128, 28000 );
        Console.WriteLine("Laptop Name = {0} Screen Size = {1} Processor = {2} Connectivity = {3} Battery = {4} RAM = {5} Storage = {7}", Phone2.Name, Phone2.ScreeSize, Phone2.Processor, Phone2.Connectivity, Phone2.Battery, Phone2.RAM, Phone2.Storage);

        Products Phone3 = new Products("Google Pixel 5", 6, "Snapdragon 765G", "4G", "Android 10", 4080, 8, 128, 12000 );
        Console.WriteLine("Laptop Name = {0} Screen Size = {1} Processor = {2} Connectivity = {3} Battery = {4} RAM = {5} Storage = {7}", Phone3.Name, Phone3.ScreeSize, Phone3.Processor, Phone3.Connectivity, Phone3.Battery, Phone3.RAM, Phone3.Storage);

    }
}