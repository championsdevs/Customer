namespace Customer
{
    public interface ICustomerAgeValidator
    {
        bool IsOfLegalAge(DateTime birthDate);
    }
}
