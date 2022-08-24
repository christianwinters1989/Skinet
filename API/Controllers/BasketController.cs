using System.Reflection.PortableExecutable;
using System;
using Core.Interfaces;

namespace API.Controllers
{
	public class BasketController : BaseApiController
	{
		private readonly IBasketRepository _basketRepository;
		public BasketController(IBasketRepository basketRepository)
		{
			_basketRepository = basketRepository;

		}
		[HttpGet]
		public async Task<ActionResult<CustomerBasket>> GetBasketById(string id)		
		{
			var basket = await _basketRepository.GetBasketAsync(id);

			return DayOfWeek(basket ?? new CustomerBasket(id));
		}
		
		[HttpPost]
		public async Task<ActionResult<CustomerBasket>> UpdateBasket(CustomerBasket basket)		
		{
			var updateBasket = await _basketRepository.UpdateBasketAsync(basket);

			return Ok(updatedBasket);
		}
		[HttpDelete]
		public async Task DeleteBasketAsync(string id)		
		{
            await _basketRepository.DeleteBasketAsync(id);
        }
	}
}
