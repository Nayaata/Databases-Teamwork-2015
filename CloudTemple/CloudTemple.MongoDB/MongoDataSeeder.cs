﻿namespace CloudTemple.MongoDB
{
    using System.Collections.Generic;

    using Excel;

    using Models;

    public class MongoDataSeeder
    {
        private ExcelXlsHandler excelHandler;

        private MongoDbHandler mongoHandler;

        public void Seed()
        {
            this.mongoHandler = new MongoDbHandler();
            this.excelHandler = new ExcelXlsHandler();
            this.SeedVendors();
            this.SeedCategories();
            this.SeedDetails();
            this.SeedProducts();
        }

        private void SeedVendors()
        {
            var allVendors = new List<Vendor>();

            this.excelHandler.ReadInitialDataFile(
                "Vendors$",
                row => { allVendors.Add(new Vendor { Id = (int)(double)row[0], Name = (string)row[1] }); });

            this.mongoHandler.WriteCollection("Vendors", allVendors);
        }

        private void SeedCategories()
        {
            var allCategories = new List<ProductCategory>();

            this.excelHandler.ReadInitialDataFile(
                "Categories$",
                row => { allCategories.Add(new ProductCategory { Id = (int)(double)row[0], Name = (string)row[1] }); });

            this.mongoHandler.WriteCollection("ProductCategories", allCategories);
        }

        private void SeedDetails()
        {
            var allDetails = new List<ProductDetails>();

            this.excelHandler.ReadInitialDataFile(
                "ProductDetails$",
                row =>
                    {
                        allDetails.Add(
                            new ProductDetails
                                {
                                    Id = (int)(double)row[0],
                                    Type = (string)row[1],
                                    Description = (string)row[2]
                                });
                    });

            this.mongoHandler.WriteCollection("ProductDetails", allDetails);
        }

        private void SeedProducts()
        {
            var allProducts = new List<Product>();

            this.excelHandler.ReadInitialDataFile(
                "Products$",
                row =>
                    {
                        allProducts.Add(
                            new Product
                                {
                                    Id = (int)(double)row[0],
                                    Name = (string)row[1],
                                    VendorId = (int)(double)row[2],
                                    CategoryId = (int)(double)row[3],
                                    DetailsId = (int)(double)row[4],
                                    Measure = (ProductMeasureUnit)(int)(double)row[5],
                                    BasePrice = (decimal)(double)row[6]
                                });
                    });

            this.mongoHandler.WriteCollection("Products", allProducts);
        }
    }
}