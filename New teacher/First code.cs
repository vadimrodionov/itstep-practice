using System;
using System.Collections.Generic;
using system.linq;
using system.text
using System.Threading.Tasks;

public class Class1
{
	class Program
	{
		class Person
		{
			public Person(string name)
			{
				Name = name;
			}
			public string Name { get; set; }
			public string Test(string str)
			{
				WriteLine("Test\n");
				return "Test";
			}
		}
		public delegate string GetResult(string arg1);



		static void Main(string[] args)
		{
			Person person;
			GetResult functions;



			person = new Person("Alex");



			functions = (string a) =>
			{
				WriteLine("Лямбда\n");
				return "Лямбда";
			};
			functions = person.Test;
		}



	}
}
