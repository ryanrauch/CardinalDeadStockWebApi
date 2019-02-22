using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CardinalDeadStockWebApi
{
    public enum ShoeType
    {
        [Display(Name = "Nike Launch")]
        NikeLaunch,
        [Display(Name = "Nike Regular")]
        NikeRegular,
        [Display(Name = "Adidas")]
        Adidas
    };
}
