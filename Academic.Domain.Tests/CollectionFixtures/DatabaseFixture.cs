namespace Academic.Domain.Tests.CollectionFixtures
{
    public class DatabaseFixture : IDisposable
    {
        // What actually this class do is generate connectionString and apply it to multiple tests with CollectionFixture attribute

        public Guid ConnectionString { get; set; }

        public DatabaseFixture()
        {
            ConnectionString = Guid.NewGuid();
        }

        public void Dispose()
        {
            ConnectionString = Guid.Empty;
        }
    }
}
