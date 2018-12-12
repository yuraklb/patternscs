using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Назначение: 
//	определяет зависимость типа «один ко многим» между объектами таким образом, 
//	что при изменении состояния одного объекта все зависящие от него оповещаются об этом и автоматически обновляются. 
//Другими словами: 
//	наблюдатель уведомляет все заинтересованные стороны о про- изошедшем событии или об изменении своего состояния.

namespace Observer {

	class Client {
		
		static void Main(string[] args) {
			var subject = new ConcreteSubject();

			subject.Attach(new ConcreteObserver(subject));
			subject.Attach(new ConcreteObserver(subject));

			subject.State = "State1";
			subject.Notify();

			subject.State = "State2";
			subject.Notify();

			Console.ReadKey();
		}
	}
}
