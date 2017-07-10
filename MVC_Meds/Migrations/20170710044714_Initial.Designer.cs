using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MVC_Meds.Models;

namespace MVC_Meds.Migrations
{
    [DbContext(typeof(MVC_MedsContext))]
    [Migration("20170710044714_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVC_Meds.Models.Meds", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accountID");

                    b.Property<DateTime>("dateFilled");

                    b.Property<DateTime>("dateToRefill");

                    b.Property<int>("dosesLeft");

                    b.Property<bool>("emailReminder");

                    b.Property<int>("numDoses");

                    b.Property<string>("pharmacyPhone");

                    b.Property<string>("rxName");

                    b.Property<int>("rxNumber");

                    b.Property<int>("rxPerAmount");

                    b.Property<bool>("textReminder");

                    b.HasKey("ID");

                    b.ToTable("Meds");
                });
        }
    }
}
