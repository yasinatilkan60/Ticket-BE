using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Journey : IEntity
    {
        public int Id { get; set; }
        public int BusId { get; set; }
        public string Station { get; set; }
        public string Destination { get; set; }
        public string price { get; set; }
        public Bus Bus { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
        public DateTime JourneyDate { get; set; }
    }
    public class JourneyEntityConfiguration : IEntityTypeConfiguration<Journey>
    {
        public void Configure(EntityTypeBuilder<Journey> builder)
        {
            builder.HasOne(b => b.Bus).WithMany(b => b.Journeies).HasForeignKey(j => j.BusId).OnDelete(DeleteBehavior.Restrict).IsRequired();
            //builder.HasOne<Ticket>(t => t.Ticket).WithOne(j => j.Journey).HasForeignKey<Ticket>(j => j.JourneyId);
        }
    }
}
