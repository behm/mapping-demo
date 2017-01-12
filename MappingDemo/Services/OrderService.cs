using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MappingDemo.Services.Models;

namespace MappingDemo.Services
{
	public class OrderService
	{
		public WebOrder[] GetWebOrders()
		{
			return new List<WebOrder>
			{
				new WebOrder
				{
					CustomerId = "ABC123123210-32",
					Name = "John Doe",
					AddressLine1 = "123 S Main St",
					AddressLine2 = "",
					City = "Sioux Falls",
					State = "SD",
					Zip = "57108",
					OrderDate = new DateTime(2017, 1, 4, 12, 34, 03),
				}
			}.ToArray();
		}
	}
}
