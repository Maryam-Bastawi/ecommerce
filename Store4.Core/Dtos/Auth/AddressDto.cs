﻿using Store4.Core.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store4.Core.Dtos.Auth
{
	public class AddressDto
	{
		public string FName { get; set; }
		public string LName { get; set; }
		public string City { get; set; }
		public string Street { get; set; }
		public string country { get; set; }
	}
}