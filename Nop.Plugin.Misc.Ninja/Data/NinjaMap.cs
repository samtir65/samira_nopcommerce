using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nop.Data.Mapping;
using Nop.Plugin.Misc.Ninja.Domain;

namespace Nop.Plugin.Misc.Ninja.Data
{
    public class NinjaMap:NopEntityTypeConfiguration<NinjaCms>
    {
        public override void Configure (EntityTypeBuilder<NinjaCms> builder)
        {
            builder.ToTable(nameof(NinjaCms));
            builder.HasKey(ninjaitem => ninjaitem.Id);

        }

    }
}
