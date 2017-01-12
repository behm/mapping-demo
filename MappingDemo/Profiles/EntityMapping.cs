using AutoMapper;
using MappingDemo.Models;
using MappingDemo.Services.Models;

namespace MappingDemo.Profiles
{
	public class EntityMapping : Profile
	{
		public EntityMapping()
		{
			// Order mapping
			CreateMap<WebOrder, Order>()
				.ForMember(d => d.FirstName, e => e.MapFrom(s => s.Name.Split(' ')[0]))
				.ForMember(d => d.LastName, e => e.MapFrom(s => s.Name.Split(' ')[1]));
			CreateMap<Order, WebOrder>()
				.ForMember(d => d.Name, e => e.MapFrom(s => $"{s.FirstName} {s.LastName}"));

			// Customer mapping
			CreateMap<WebCustomer, Customer>();
			CreateMap<Customer, WebCustomer>()
				.ForMember();
		}
	}
}