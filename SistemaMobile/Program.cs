using SistemaMobile.Models;

Smartphone iphone = new Iphone("00 00000-0000", "Iphone 13", "123456789", 120);
Console.WriteLine("***Iphone***");
iphone.ExibirDados();
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine();

Smartphone samsung = new Samsung("00 00000-0000", "Samsung Galaxy 13", "123456789", 256);
Console.WriteLine("***Samsung***");
samsung.ExibirDados();
samsung.Ligar();
samsung.ReceberLigacao();
samsung.InstalarAplicativo("Whatsapp");
