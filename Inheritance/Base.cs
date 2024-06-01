using System;

class Base
{
	pretected string Name;
	public Base(string Name)
	{ 
		this.Name = Name;
		Console.WriteLine($"{this.Name).Base()");
	}

	~Base()
	{
		Console.WRiteLine($"{this.Name}.~Base()");
	}

	public void BaseMethod()
	{
		Console.WriteLine($"{Name}.BaseMethod()");
	}


}
