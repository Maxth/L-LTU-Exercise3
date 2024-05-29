// See https://aka.ms/new-console-template for more information


//3.1
var personHandler = new PersonHandler();
Person person1;
Person person2;
Person person3;
try
{
    person1 = personHandler.CreatePerson(64, "Lasse", "Stefanz", 1.61, 100);
    person2 = personHandler.CreatePerson(10, "Nisse", "Larsson", 1.10, 40);
    person3 = personHandler.CreatePerson(40, "Stina", "Svensson", 1.59, 55);
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}

//3.2
var userErrorList = new List<UserError>();
userErrorList.AddRange([new NumericInputError(), new TextInputError()]);
userErrorList.AddRange([new IntegerInputError(), new NegativeIntError(), new NullInputError()]);
userErrorList.ForEach(e => Console.WriteLine(e.UEMessage()));

/*
3.3

13. F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt
attribut, i vilken klass bör vi lägga det?

Svar: Vi lägger till det i klassen Bird, som alla fåglarna ärver från.


14. F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?

Svar: Vi lägger till det i klassen Animal, som alla djur ärver ifrån.
*/

//3.4
var animals = new List<Animal>();
animals.AddRange(
    [
        new Pelican("Pelle", 2, 1.5, 1.6, 0.3),
        new Wolf("Vargas", 6, 30, 14),
        new Worm("Masken", 1, 0.2, 0.12),
        new Wolfman("Valle", 43, 72, 27),
        new Dog("Fido", 6, 19.4, 50),
    ]
);

animals.ForEach(a =>
{
    Console.WriteLine(a.GetType().Name);
    a.DoSound();
    if (a is IPerson)
    {
        (a as IPerson).Talk();
    }
});

var dogs = new List<Dog>();

/*
9. F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
dogs.Add(new Horse("Hasse", 7, 150, 40))

Svar: Det fungerar inte eftersom vi har bestämt att listan endast ska innehålla objekt som implementerar Dog-klassen,
      vilket objekt av typen Horse inte gör.


10. F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?

Svar: För att alla djur (och wolfman) ska vara i samma lista måste listan vara av typen Animal.
      För att alla skapade klasser - Person och alla Animal-klasserna - ska kunna vara i samma lista behöver
      listan vara av typen Object.
*/

animals.ForEach(a => System.Console.WriteLine(a.Stats()));

/*
13. F: Förklara vad det är som händer.

Svar: Vi anropar metoden Stats på varje Animal-objekt. Den mest specifika versionen av Stats anropas då,
      alltså den version som den lägsta klassen i hierarkin implementerar.
*/

animals.ForEach(a =>
{
    if (a is Dog)
    {
        System.Console.WriteLine(a.Stats());
    }
});

/*
17. F: Varför inte?

Svar: Vi kommer inte åt den för Dog unika metoden Pee() eftersom vi har att göra med Animal-referenser,
      som ej implementerar den metoden. Det vi kan göra för att komma åt den unika metoden är att se om om ett
      Animal i listan är av typen Dog, och isf type-casta den till Dog, enligt nedan.
*/

animals.ForEach(a =>
{
    if (a is Dog)
    {
        System.Console.WriteLine((a as Dog).Pee());
    }
});
