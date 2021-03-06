// <auto-generated />
using System;
using CompositionWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CompositionWebApp.Migrations
{
    [DbContext(typeof(CompositionContext))]
    partial class CompositionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CompositionWebApp.Models.Compositions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IdFirstPhoto");

                    b.Property<string>("Name");

                    b.Property<int>("NumberPhotos");

                    b.HasKey("Id");

                    b.ToTable("Compositions");
                });

            modelBuilder.Entity("CompositionWebApp.Models.Photos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompositionId");

                    b.Property<byte[]>("Image");

                    b.Property<string>("RightKey");

                    b.HasKey("Id");

                    b.HasIndex("CompositionId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("CompositionWebApp.Models.Photos", b =>
                {
                    b.HasOne("CompositionWebApp.Models.Compositions", "Composition")
                        .WithMany("Photos")
                        .HasForeignKey("CompositionId");
                });
#pragma warning restore 612, 618
        }
    }
}
