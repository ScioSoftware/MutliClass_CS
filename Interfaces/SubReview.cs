using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiClass_CS.Interfaces
{
    interface SubReview : DatabaseItem
    {
        String result { get; }
        BaseReview.ReviewType type { get; }
    }
}
