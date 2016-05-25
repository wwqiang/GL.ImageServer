namespace GL.DBOptions.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GL_Member
    {
        [Key]
        [StringLength(32)]
        public string sId { get; set; }

        [Required]
        [StringLength(20)]
        public string sUserName { get; set; }

        [StringLength(30)]
        public string sUserEmail { get; set; }

        [StringLength(11)]
        public string sUserPhone { get; set; }

        [Required]
        [StringLength(32)]
        public string sUserPwd { get; set; }

        public bool bState { get; set; }

        public bool bIsDelete { get; set; }

        public DateTime dCreateTime { get; set; }

        public DateTime? dUpdateTime { get; set; }
    }
}