using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia n = new Nokia("12399", "Nokia", "nokia", 123);
n.Ligar();
n.ReceberLigacao();
n.InstalarAplicativo("whatsApp");

Iphone i = new Iphone("1244399", "Iphone", "iphone", 456);
i.Ligar();
i.ReceberLigacao();
i.InstalarAplicativo("MemoryCard");