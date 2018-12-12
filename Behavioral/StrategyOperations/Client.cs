using System;

//Назначение: 
//	определяет семейство алгоритмов, инкапсулирует каждый из них и делает их взаимозаменяемыми.
//  Стратегия позволяет изменять алгоритмы независи- мо от клиентов, которые ими пользуются. 

//Другими словами: 
//	стратегия инкапсулирует определенное поведение с возможностью его подмены.

//Мотивация использования паттерна Стратегия:
//	выделение поведения или алгоритма с возможностью его замены во время исполнения.

//	Стратегия нужна тогда, когда не просто требуется спрятать алгоритм, а важно иметь возможность заменить его во время исполнения!

namespace Strategy {

	class Client {

		static void Main(string[] args) {

			Context context;

			// Three contexts following different strategies
			context = new Context(new AddStrategy());
			var resultA = context.ExecuteStrategy(3, 4);
			Console.WriteLine(resultA);

			context = new Context(new SubstractStrategy());
			var resultB = context.ExecuteStrategy(3, 4);
			Console.WriteLine(resultB);

			context = new Context(new MultiplyStrategy());
			var resultC = context.ExecuteStrategy(3, 4);
			Console.WriteLine(resultC);

			Console.ReadKey();
		}
	}
}
