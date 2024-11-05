﻿namespace Store4.Core.Dtos.Orders
{
	public class OrderItemsDto
	{
		public int ProductId { get; set; }
		public string ProductName { get; set; }
		public string PictureUrl { get; set; }
		public decimal Price { get; set; }
		public int Quantity { get; set; }
	}
}