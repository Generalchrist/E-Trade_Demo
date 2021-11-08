using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants {
    public static class Messages {
        public static string ProductAdded = "Product added";
        public static string ProductNameInvalid = "Product name invalid";
        public static string MaintenanceTime = "System is in maintenance";
        public static string ProductsListed = "Products are listed";
        public static string ProductCountOfCategoryError = "Product category count is suspicious";
        public static string ProductNameAlreadyExists = "Product name is already exist";
        public static string CategoryLimitExcedeed = "Category limit is excedeed";
        public static string AuthorizationDenied = "User has no authorize";
        public static string UserRegistered = "user registered";
        public static string UserNotFound = "user not found";
        public static string PasswordError = "password is wrong";
        public static string SuccessfulLogin = "user succesfully logined";
        public static string UserAlreadyExists = "user already exists";
        public static string AccessTokenCreated = "token created";
    }
}
