using DesafioPOO.models;

Smartphone nokia = new Nokia("11987654321", "G60", "490154203237518", 128);
Smartphone iphone = new Iphone("11912345678", "15_PRO", "356938035643707", 256);

Console.WriteLine("\n--\t--\t--\tNokia\t--\t--\t--\n");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Replit");

Console.WriteLine("\n\n--\t--\t--\tIphone\t--\t--\t--\n");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Github");