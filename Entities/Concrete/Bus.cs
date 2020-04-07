
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Bus : IEntity
    {
        public int Id { get; set; }
        public string BusName { get; set; }
        public int Capacity { get; set; }
        public ICollection<Journey> Journeies{ get; set; }
    }
    //public class BusEntityConfiguration : IEntityTypeConfiguration<Bus>
    //{
    //    public void Configure(EntityTypeBuilder<Bus> builder)
    //    {
    //        builder.HasOne<Journey>(j => j.Journeies).WithOne(j => j.Bus).HasForeignKey<Journey>(j => j.BusId);

    //    }
    //}
}
