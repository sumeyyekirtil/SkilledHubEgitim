﻿using System;
namespace WindowsFormsAppAdoNet
{
	public class Category
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public bool Active { get; set; }
		public DateTime CreateDate { get; set; }
	}
}