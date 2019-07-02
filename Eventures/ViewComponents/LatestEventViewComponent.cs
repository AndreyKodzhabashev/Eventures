using Eventures.Data;
using Eventures.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventures.ViewComponents
{
       public class LatestEventViewComponent : ViewComponent
    {
       
        public LatestEventViewComponent()
        {
           
        }

        public  IViewComponentResult Invoke()
        {          

            return View(new LatestEventViewModel { Name = "Test", Place = "Test", Start = DateTime.UtcNow});

        }
    }
}