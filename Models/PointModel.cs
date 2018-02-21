namespace WebAPIAuth
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PointModel
    {
        public int Id { get; set; }

        public int BoardId { get; set; }

        public int XCor { get; set; }

        public int YCor { get; set; }
    }
}
