using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CompositionWebApp.Models
{
    public partial class CompositionContext : DbContext
    {
        public CompositionContext(DbContextOptions<CompositionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Composition> Compositions { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }

    }
}
