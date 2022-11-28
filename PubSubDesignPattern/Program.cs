// See https://aka.ms/new-console-template for more information

using PubSubDesignPattern;

Console.WriteLine("Hello, World!");

var pubA = new Publisher { Name = "Dabas" };

var subA = new Subscriber();
var subB = new Subscriber();
var subC = new Subscriber();

subA.Subscribe(pubA);
subB.Subscribe(pubA);
subC.Subscribe(pubA);

pubA.Notify("This is First Message");

subB.UnSubscribe(pubA);

pubA.Notify("This Message will no show up for subB");