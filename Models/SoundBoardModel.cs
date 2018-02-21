namespace WebAPIAuth
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SoundBoardModel : DbContext
    {
        public SoundBoardModel()
            : base("name=SoundBoardContext")
        {
        }

        public virtual DbSet<BoardModel> Boards { get; set; }
        public virtual DbSet<PointModel> Points { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
