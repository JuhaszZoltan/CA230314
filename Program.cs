using CA230314;

var people = MTest.GetTestList();

int sum = people.Sum(p => p.Hobbies.Length);
Console.WriteLine($"hobbik száma: {sum}");

double avg = people.Average(p => p.Age);
Console.WriteLine($"átlagéletkor: {avg}");

Person? minAgeP = people.MinBy(p => p.Hobbies.Length);
Console.WriteLine($"legfiatalabb neve: {minAgeP.Name}");

int maxId = people.Max(p => p.Id);
Console.WriteLine($"legnagyobb id: {maxId}");

//van maxby és min is

int noMale = people.Count(p => p.Sex == true);
Console.WriteLine($"férfiak száma: {noMale}");

bool isTattoo = people.Any(p => p.Hobbies.Contains("tattoo"));
Console.WriteLine(
    $"{(isTattoo ? "van" : "nincs")} " +
    "olyan, akinek hobbija a tetkó");


//first
// -> HA van találat
//      -> visszaadja a legkisebb indexűt PÉLDÁNYT
// -> EGYÉBKÉNT
//      -> kivételt dob

//first or default
// -> HA van találat
//      -> visszaadja a legkisebb indexűt PÉLDÁNYT
// -> EGYÉBKÉNT
//      -> HA erték típusú a keresett példány
//            -> visszaadja a típud "zezo" értékét
//      -> Ha referencia típus
//            -> visszaad "null" értéket
//      ("a lényeg, hogy nem 'tud' kivételt generálni, tehát mindenképpen lefut)


//last
//last or default
// => ugyan az mint a first, csak találat esetén a legnagyobb indexű találattal

//single
// => HA több találat van, mint egy,
// => akkor exceptiont dob
// => ha nincs találat, akkor is

//single or default
// ha több találat van, akkor exception
// ha nincs találat, akkor zero vagy null


