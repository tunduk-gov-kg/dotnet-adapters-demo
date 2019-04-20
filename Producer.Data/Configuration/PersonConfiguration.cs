using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Producer.Data.Configuration
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(person => person.Pin);

            builder.Property(person => person.Name).HasMaxLength(100).IsRequired();
            builder.Property(person => person.Gender).IsRequired();
            builder.Property(person => person.BirthDate).IsRequired();
            builder.Property(person => person.Photo).HasMaxLength(1024 * 256).IsRequired();
        }
    }
}