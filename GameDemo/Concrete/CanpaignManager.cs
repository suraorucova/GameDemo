using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    internal class CanpaignManager : ICanpaignService
    {
        public void Add(ICanpaignsService canpaignsService)
        {
            canpaignsService.Add();
        }

        public void Delete(ICanpaignsService canpaignsService)
        {
            canpaignsService.Delete();
        }

        public void Update(ICanpaignsService canpaignsService)
        {
            canpaignsService.Update
        }
    }
}
