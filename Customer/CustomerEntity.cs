namespace Customer
{
    public class CustomerEntity
    {
        public CustomerEntity(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }

        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }
    }
}
