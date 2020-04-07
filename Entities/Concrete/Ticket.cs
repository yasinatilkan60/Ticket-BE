using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Ticket : IEntity
    {
        public int Id { get; set; }
        public int JourneyId { get; set; }
        public int UserId { get; set; }
        
        public Journey Journey { get; set; }
        


    }
    public class TicketEntityConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasOne(t => t.Journey).WithMany(j => j.Tickets).HasForeignKey(t => t.JourneyId).OnDelete(DeleteBehavior.Restrict).IsRequired(); ;
        }
    }
}
