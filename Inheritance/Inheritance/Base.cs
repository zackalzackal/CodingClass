﻿using System;

class Base
{
	protected string Name;
	public Base(string Name)
	{ 
		this.Name = Name;
		Console.WriteLine($"{this.Name}.Base()");
	}

	~Base()
	{
		Console.WriteLine($"{this.Name}.~Base()");
	}

	public void BaseMethod()
	{
		Console.WriteLine($"{Name}.BaseMethod()");
	}


}
