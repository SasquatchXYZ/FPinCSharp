using static System.Console;
using LaYumba.Functional;
using Name = System.String;
using Greeting = System.String;
using PersonalizedGreeting = System.String;

var greet = (Greeting gr, Name name) => $"{gr}, {name}";

Name[] names = { "Tristan", "Ivan" };

names.Map(n => greet("Hello", n)).ForEach(WriteLine);
