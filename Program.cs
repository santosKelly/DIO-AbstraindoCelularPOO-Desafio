using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia: ");
Nokia nokia = new Nokia(numero: "(87) 91325-2741", modelo: "Modelo 1", imei: "985785948982629", memoria:64) ;
nokia.Ligar();
nokia.InstalarAplicativo("Moovit");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Iphone iphone= new Iphone(numero: "(61) 91947-2230", modelo: "Modelo 2", imei: "984933144855691", memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Duolingo");

