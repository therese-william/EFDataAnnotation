using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI.Entities
{
    [MetadataType(typeof(DealerMetaData))]
    public partial class Dealer
    {
    }

    [MetadataType(typeof(DealerCityMetaData))]
    public partial class DealerCity { }


    [MetadataType(typeof(SubBrandMetaData))]
    public partial class SubBrand { }


    [MetadataType(typeof(FinishMetaData))]
    public partial class Finish { }


    [MetadataType(typeof(ItemMetaData))]
    public partial class Item { }


    [MetadataType(typeof(ItemColorMetaData))]
    public partial class ItemColor { }


    [MetadataType(typeof(WebsiteMetaData))]
    public partial class Website { }

    [MetadataType(typeof(GroupMetaData))]
    public partial class Group { }

    [MetadataType(typeof(ColorMetaData))]
    public partial class Color { }
}
