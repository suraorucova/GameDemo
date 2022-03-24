using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    internal interface ICanpaignService
    {
        void Add(ICanpaignsService canpaignsService);
        void Delete(ICanpaignsService canpaignsService);
        void Update(ICanpaignsService canpaignsService);
    }
}
