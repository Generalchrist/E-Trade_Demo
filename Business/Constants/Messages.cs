using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants {
    public static class Messages {
        public static string ProductAdded = "Product added";
        public static string ProductNameInvalid = "Product name invalid";
        internal static string MaintenanceTime = "System is in maintenance";
        internal static string ProductsListed = "Products are listed";
        internal static string ProductCountOfCategoryError = "Product category count is suspicious";
        internal static string ProductNameAlreadyExists = "Product name is already exist";
        internal static string CategoryLimitExcedeed = "Category limit is excedeed";
    }
}
