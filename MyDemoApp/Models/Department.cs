﻿using MyDemoApp.Models;
using System;

public class Department
{
	public int Id { get; set; }

	public string Name { get; set; }

	public ICollection<Employee> Employee { get; set; }
}
