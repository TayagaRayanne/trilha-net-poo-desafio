using DesafioPOO.Models;

//Realizar os testes com as classes Nokia e Iphone

Smartphone Nokia = new Nokia("82545636","Nokia 330", "012345678", 16);

Smartphone Iphone = new Iphone("94356781","Iphone 14", "012345678", 256);

Nokia.Reiniciar();
Nokia.InstalarAplicativo("Whatsapp");
Nokia.ReceberLigacao();
Nokia.Ligar();

Console.WriteLine();

Iphone.Reiniciar();
Iphone.InstalarAplicativo("Telegram");
Iphone.ReceberLigacao();
Iphone.Ligar();