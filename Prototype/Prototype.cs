using System;

namespace Prototype
{
	// "Prototype" 
	public abstract class Prototype
	{
		// Constructor
		public Prototype(string id)
		{
			this.Id = id;

			Console.Write("Base constructor is called.");
		}

		// Property
		public string Id { get; private set; }

		public virtual Prototype Clone()
		{
			// Shallow copy
			return (Prototype)this.MemberwiseClone();
		}
	}
}

