using Producer.Data;

namespace Producer.Service
{
    public class PersonService : IPersonService
    {
        private readonly AppDbContext _dbContext;

        public PersonService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public Person GetPerson(string pin)
        {
            return _dbContext.People.Find(pin);
        }
    }
}
