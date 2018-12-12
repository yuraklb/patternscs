using System;

//Назначение: 
//	динамически добавляет объекту новые обязанности. 
//	Является гибкой альтернативой порождению подклассов с целью расширения функциональности.

namespace Decorator {

	class Program {
		
		static void Main(string[] args) {
			IWindow window = new HorizontalScrollbarWindow(new VerticalScrollbarWindow(new SimpleWindow()));
			Console.WriteLine(window.GetDescription());

			Console.ReadKey();
		}
	}
}
