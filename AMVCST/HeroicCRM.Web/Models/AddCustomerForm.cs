﻿using Heroic.AutoMapper;
using HeroicCRM.Web.Core;

namespace HeroicCRM.Web.Models
{
	public class AddCustomerForm : IMapTo<Customer>
	{
		public string Name { get; set; }

		public string WorkEmail { get; set; }

		public string HomeEmail { get; set; }

		public string WorkPhone { get; set; }

		public string HomePhone { get; set; }

		public string WorkAddress { get; set; }

		public string HomeAddress { get; set; }
	}
}