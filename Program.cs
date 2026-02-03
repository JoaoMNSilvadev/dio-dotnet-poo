using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone("(71) 99452-7862", "iphone 13", "IMEI1234567890", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");
Console.WriteLine();
Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("(71) 99876-5432", "Nokia G20", "IMEI0987654321", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");
