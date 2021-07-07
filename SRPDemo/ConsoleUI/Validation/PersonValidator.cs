namespace ConsoleUI
{
    public class PersonValidator
    {
        public static bool Validate(Person person)
        {
            //checks to be sure the first and last names are valid
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                StandardMessages.DisplayValidatorError("frist name");
                return false;
            }
            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                StandardMessages.DisplayValidatorError("last name");
                return false;
            }
            return true;
        }
    }
}
