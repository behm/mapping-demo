using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MappingDemo.Models;
using MappingDemo.Profiles;
using MappingDemo.Services;
using MappingDemo.Services.Models;

namespace MappingDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Mapper.Initialize(cfg => cfg.AddProfile<EntityMapping>());

			var orderService = new OrderService();

			var webOrders = orderService.GetWebOrders();

			foreach (var webOrder in webOrders)
			{
				var order = Mapper.Map<Order>(webOrder);
				Console.WriteLine($"Ordered by '{order?.FirstName} {order?.LastName}'");

				// todo: insert order into database here

				// Convert back
				var wOrder = Mapper.Map<WebOrder>(order);
				Console.WriteLine("Order Name: {0}", wOrder.Name);
			}
		}
	}
}
