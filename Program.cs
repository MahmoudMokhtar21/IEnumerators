using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;






Employee e1 = new Employee { id = 100,name="mahmoud",deparment="web development"};
Employee e2 = new Employee { id = 100, name = "mahmoud", deparment = "web development" };
Console.WriteLine(e1==e2); // when i comment ==operator it gives false due to refrences equalism not content
Console.WriteLine(e1.Equals(e2));



//===============================================================

var nums = new FiveIntegers(1, 2, 3, 4, 5);
foreach(var i in nums)
{
    Console.WriteLine(i);
}


Random rnd = new Random();

var temps = new List<Tempereture>();

for(int i = 0;i <= 100;i++)
{
    temps.Add(new Tempereture(rnd.Next(-30, 50)));
}
temps.Sort();

foreach(var temp in temps)
{
    Console.WriteLine(temp._values);
}