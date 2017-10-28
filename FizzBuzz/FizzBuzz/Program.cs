using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz {
	class Program {
		static void FizzBuzzThese(int FizzNumber, int BuzzBunber, int RunToNumber) {
			for (int i=1; i<=RunToNumber; i++) {
				string result = "";
				if (i % FizzNumber == 0) {
					result += "Fizz";
				}
				if (i % BuzzBunber == 0) {
					result += "Buzz";
				}
				if (String.IsNullOrEmpty(result)) {
					result = i.ToString();
				}

				Console.WriteLine(result);
			}
		}

		static void Main(string[] args) {
			FizzBuzzThese(2, 3, 7);
			FizzBuzzThese(2, 4, 7);
			FizzBuzzThese(3, 5, 7);
			Console.ReadLine();
		}
	}
}
