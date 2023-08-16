namespace FantasyGenerator.Core.Constants
{
    public class ErrorMessages
    {
        public const string STRING_LENGTH = "{0} must be between {2} and {1} characters";

        public const string EMAIL_ADSRESS = "Must be valid email";

        public const string CONFIRM_PASSWORD = "Password and ConfirmPassword don`t match";

        public const string USER_EXIST = "Username already exist";

        public const string ELEMENT_EXIST = "{0} already exist";

        public const string DB_ERROR = "Impossible save in DB. Error";

        public const string DB_ERROR_LOAD = "Db SQL Error";

        public const string DB_SAVE_OK = "Save to DB success";

        public const string PRICE_ERROR = "Price must be between 0.05 and 1000";
    }
}
