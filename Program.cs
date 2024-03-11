using DesafioPOO.Models;

System.Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("12332112", "Fone", "11111111111", 32);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

System.Console.WriteLine("iPhone");
Smartphone iphone = new Iphone("312123123", "iPhone 12", "2222222222", 64);
iphone.Ligar();
iphone.InstalarAplicativo("Wild Rift");