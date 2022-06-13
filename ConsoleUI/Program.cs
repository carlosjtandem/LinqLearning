using LinqLibary;

List<Person> People = ListManager.loadSampleData();

//People = People.OrderBy(x => x.LastaName).ToList();

People = People.Where(x => x.YearsOfExpericience >5).ToList();


//People = People.OrderByDescending(x => x.LastaName).ThenBy(x => x.YearsOfExpericience).ToList();
foreach (var Person in People)
{
    Console.WriteLine(String.Format("Nombre:{0},  Apellido:{1},  Fecha nacimiento:{2},  Experiencia:{3}", Person.FirstName, Person.LastaName, Person.Birthday, Person.YearsOfExpericience));
}


// SUM
//int yearsTotal = People.Sum(x => x.YearsOfExpericience);

//Get the people with born in march and get the years of experience
//int yearsTotal = People.Where(x => x.Birthday.Month==3).Sum(x => x.YearsOfExpericience);