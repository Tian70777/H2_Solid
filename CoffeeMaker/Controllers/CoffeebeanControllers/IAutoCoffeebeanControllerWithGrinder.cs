using CoffeeMaker.Controllers.CoffeebeanController;
using CoffeeMaker.Models.Grinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker.Controllers
{
    public interface IAutoCoffeebeanControllerWithGrinder: IAutoCoffeebeanController, IGrinder
    {
    }
}
