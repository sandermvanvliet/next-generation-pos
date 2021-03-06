﻿namespace WebApi.Configuration
{
    public class ApplicationConfiguration
    {
        public string ConnectionString { get; set; }
        public string GetProductsQuery { get; set; }
        public string SearchProductsQuery { get; set; }
        public string GetProductBundlesQuery { get; set; }
        public string CreateOrderCommand { get; set; }
        public string AddProductToOrderCommand { get; set; }
        public string GetOrderByIdQuery { get; set; }
        public string GetProductsInBundleQuery { get; set; }
        public string CreateUserCommand { get; set; }
    }
}