﻿using System.ComponentModel.DataAnnotations;

namespace MusicBlazor
{
	public class Artists_Songs
	{
		public int Id { get; set; }
		
		public int Song_Id { get; set; }
		
		public int Artist_Id { get; set; }
	}
}
