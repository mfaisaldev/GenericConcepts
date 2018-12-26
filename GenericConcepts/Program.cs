using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericConcept
{
	class Program
	{
		static void Main(string[] args)
		{
			NumberGame<int> numberGame = new NumberGame<int>();
			numberGame.Add(123);
			numberGame.Add(1);
			numberGame.Add(13);
			numberGame.Add(12);
			numberGame.Add(23);
			numberGame.Add(3);
			numberGame.Add(231);
			numberGame.Add(111);
			int pos = 0;
			while (true)
			{
				if (numberGame.Get(pos) != 0)
				{
					Console.WriteLine(numberGame.Get(pos).ToString());
					pos++;
				}
				else
				{
					break;
				}
			}
			NumberGame<string> genericString = new NumberGame<string>();
			genericString.Add("ABC1");
			genericString.Add("ABC123");
			genericString.Add("ABC1111");
			genericString.Add("ABC1222");
			genericString.Add("ABC1333");
			genericString.Add("ABC1SSS");
			genericString.Add("ABC1FFFF");
			genericString.Add("ABC1KKKL");

			pos = 0;
			while (true)
			{
				if (!string.IsNullOrEmpty(genericString.Get(pos)))
				{
					Console.WriteLine(genericString.Get(pos));
					pos++;
				}
				else
				{
					break;
				}
			}
			Console.ReadKey();


		}
	}

	public class NumberGame<T>
	{
		private T[] _myArray;
		private int _pos = 0;

		public NumberGame()
		{
			_myArray = new T[1000];
		}

		public void Add(T val)
		{
			_myArray[_pos] = val;
			_pos++;
		}
		public T Get(int position)
		{
			T item = _myArray[position];
			return item;
		}
	}
}
