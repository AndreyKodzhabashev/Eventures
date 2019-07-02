using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandBox.Views.Shared.Components.LastUser
{
    public class LastUserViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return this.View();
        }
    }
}
