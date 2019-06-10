﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenNhanShop.Model.Abstract
{
    public abstract class Auditable : IAudiable
    {
        public DateTime? CreateDate { set; get; }
        
        [MaxLength(256)]
        public string CreateBy { set; get; }

        public DateTime? UpdatedDate { get; set; }

        [MaxLength(256)]
        public string UpdatedBy { get; set; }

        [MaxLength(256)]
        public string MetaKeyword { set; get; }

        [MaxLength(256)]
        public string MetaDescription { set; get; }

        public bool Status { get; set; }
    }
}
