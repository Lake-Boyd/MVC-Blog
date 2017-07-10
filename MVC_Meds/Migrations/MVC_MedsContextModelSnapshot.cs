using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MVC_Meds.Models;

namespace MVC_Meds.Migrations
{
    [DbContext(typeof(MVC_MedsContext))]
    partial class MVC_MedsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVC_Meds.Models.Meds", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("acctID");

                    b.Property<int>("doses");

                    b.Property<int>("dosesLeft");

                    b.Property<bool>("email");

                    b.Property<DateTime>("fillDate");

                    b.Property<DateTime>("refillDate");

                    b.Property<int>("rxAmount");

                    b.Property<string>("rxName");

                    b.Property<int>("rxNumber");

                    b.Property<string>("rxPhone");

                    b.Property<bool>("text");

                    b.HasKey("ID");

                    b.ToTable("Meds");
                });
        }
    }
}
