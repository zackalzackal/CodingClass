using System;

class Derived : Base
{
	public Derived(string Name) : base(Name) {
		Console.WriteLine($"{this.Name}.Derived()");
	}

	~Derived()
	{
		Console.WriteLine($"{this.Name}.~Derived()");
	}
	public void DerivedMethod()
	{
		Console.WriteLine($"{Name}.DerivedMethod()");
	}
}
