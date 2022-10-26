using Övning_2;
using System.Collections;
using System.Diagnostics.SymbolStore;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

public class Program
{
    public static void Main(string[] args)
    {

        // Create ArrayList
        ArrayList persons = new ArrayList();

        //method to add 3 people to the Arraylist
        addPerson(persons);

        // Print the Data in the ArrayList
        foreach (var person in persons)
        {
            Console.WriteLine(person);
        }
        Console.ReadKey();

    }
        // Take input from 3 people and save input to Varibles

        public static void addPerson(ArrayList persons)
        {
           Console.WriteLine("Skriv in namn på den första personen");
           string personName = Console.ReadLine();
           Console.WriteLine("Skriv sedan in ålder på första personen");
           string personAge = Console.ReadLine();
           persons.Add(new Person(personName, personAge));

           Console.WriteLine("Skriv in namn på den andra personen");
           string personName1 = Console.ReadLine();
           Console.WriteLine("Skriv sedan in ålder på den andra personen");
           string personAge1 = Console.ReadLine();
           persons.Add(new Person(personName1, personAge1));

           Console.WriteLine("Skriv in namn på den sista personen");
           string personName2 = Console.ReadLine();
           Console.WriteLine("Skriv sedan in ålder på den sista personen");
           string personAge2 = Console.ReadLine();
           persons.Add(new Person(personName2, personAge2));








        }














}