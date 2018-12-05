using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("12 месяцев года: ");
			string[] mes = new string[12] { "Декабрь", "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Окятбрь", "Ноябрь" };
			foreach (string x in mes)
				Console.WriteLine(x);

			Console.Write("Запрос вывода месяцев по длине строки. Введите длину строки месяца для вывода на консоль: ");
			int a = Convert.ToInt32(Console.ReadLine());
			var selectedTeams = mes.Where(x => x.Length == a);
			foreach (string s in selectedTeams)
				Console.WriteLine(s);

			Console.WriteLine("Запрос вывода зимних и летних месяцев: ");
			string[] mes1 = new string[] { "Декабрь", "Январь", "Февраль", "Июнь", "Июль", "Август" };
			var mesL = from x in mes from y in mes1 where x == y select x;
			foreach (var x in mesL)
				Console.WriteLine(x);

			Console.WriteLine("Запрос вывода месяцев в алфавитном порядке: ");
			var selectedSort = from x in mes orderby x select x;
			foreach (string x in selectedSort)
				Console.WriteLine(x);

			Console.Write("Запрос подсчитывающий месяцы содержащий в имени букву 'и' и длинной имени не менее 4-х: ");
			var selectI = from x in mes from x1 in x where x.Length >= 4 where x1 == 'и' select x;
			Console.WriteLine(selectI.Count());

			Class1 class1 = new Class1(23) { first = "Tom", last = "Tompson" };
			Class1 class2 = new Class1(30) { first = "Bob", last = "Bompson" };
			List<Class1> class1s = new List<Class1> { class1, class2 };
			string s1 = "";
			foreach (Class1 s in class1s)
			{
				s1 += s.age + " " + s.first + " " + s.last + "; ";
			}
			Console.WriteLine(s1);

			
			Console.Write("Введите количество строк: ");
			int countRows = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите слово: ");
			string slovo = Console.ReadLine();
			string slovo1 = ".";
			string slovo2 = "?";
			List<int> list = new List<int>();
			Console.WriteLine("Введите строки заданным количеством раз:  ");
			for(int i = 1; i <= countRows; i++)
			{
				int minInd = 0;
				Console.Write(i + ".  ");
				string kontrolStrok = Console.ReadLine();
				string[] dd = kontrolStrok.Split(' ');
				int min = dd[0].Length;

				for (int i2 = 0; i2 < dd.Length; i2++)
					if (min > dd[i2].Length)
					{
						min = dd[i2].Length;
						minInd = i2;
						if (dd[i2] == slovo)
							list.Add(i);
					}
					else if (dd[i2] == slovo)
						list.Add(i);
				for (int i2 = 0; i2 < dd.Length; i2++)
					if (dd[i2] == slovo1 || dd[i2] == slovo2)
					{
						Console.WriteLine($"Первая строка содержащая . или ? имеет индекс: {i}");
					}

				if (kontrolStrok.Trim() == "" || kontrolStrok == null)
				{
					Console.WriteLine("Неправильные введенные данные!!!");
					break;
				}
				else if (i != countRows)
				{
					continue;
				}
					Console.Write("Строки содержащее заданное слово: ");
					foreach (int i4 in list)
					{
						if (i4 != 0)
							Console.Write(i4 + "; ");
						else
							Console.WriteLine("!нет!");
					}
				Console.WriteLine();
					Console.WriteLine("самое кроткое слово в последней строке: " + dd[minInd]);
					Console.WriteLine("индекс самого кроткого слова в последней строке: " +  minInd);
					Console.WriteLine(s1);
			}
			
			




			Console.ReadKey();
		}
	}
	public class Class1
	{
		public string last { get; set; }
		public string first { get; set; }
		public int age { get; set; }
		public static int minimumAge;
		public const int C = 10;
		public Class1(string lastName, string firstName)
		{
			last = lastName;
			first = firstName;
		}
		public Class1(string c)
		{
			c = " номер 1 ";
			last = "Это строка" + c;
		}
		public Class1(int age1)
		{
			age = age1 - 2;
		}
		static Class1()
		{
			minimumAge = 18;
			Console.WriteLine(minimumAge + " вызван статический конструктор");
		}
	}
}
