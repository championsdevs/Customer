namespace Customer
{
    public class CustomerAgeValidator : ICustomerAgeValidator
    {
        private const int eighteenYearsInDays = 6570;

        public bool IsOfLegalAge(DateTime birthDate)
        {
            return (DateTime.Now.Date - birthDate.Date).Days > eighteenYearsInDays;
        }
    }
}
