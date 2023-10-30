BMW bmw = new BMW();

Console.WriteLine("Add Model");
bmw.Model = Console.ReadLine();
Console.WriteLine("Add Topspeed");
bmw.Topspeed = int.Parse(Console.ReadLine());
Console.WriteLine("Add Engine");
bmw.Engine= double.Parse(Console.ReadLine());
Console.WriteLine("Add Km");
bmw.Km= double.Parse(Console.ReadLine());
Console.WriteLine("Add Hp");
bmw.Hp= int.Parse(Console.ReadLine());

Console.WriteLine("Add paket");
bmw.İsMpower = bool.Parse(Console.ReadLine());
bmw.GetFullInfo();

Mercedes mercedes = new Mercedes();

Console.WriteLine("Add Model");
mercedes.Model = Console.ReadLine();
Console.WriteLine("Add Topspeed");
mercedes.Topspeed = int.Parse(Console.ReadLine());
Console.WriteLine("Add Engine");
mercedes.Engine = double.Parse(Console.ReadLine());
Console.WriteLine("Add Km");
mercedes.Km = double.Parse(Console.ReadLine());
Console.WriteLine("Add Hp");
mercedes.Hp = int.Parse(Console.ReadLine());

Console.WriteLine("Add paket");
mercedes.IsAmg = bool.Parse(Console.ReadLine());
mercedes.GetFullInfo();

