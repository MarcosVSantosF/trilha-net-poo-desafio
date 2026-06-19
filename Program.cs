using DesafioPOO.Models;

Console.WriteLine("Smartphone: Nokia");
Smartphone nokia = new Nokia("123456789", modelo: "Nokia 3310", imei: "123456789012345", memoria: 16);
nokia.Ligar();
nokia.InstalarAplicativo("WhattsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone: Iphone");
Smartphone iphone = new Iphone("987654321", modelo: "Iphone 13", imei: "543210987654321", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");