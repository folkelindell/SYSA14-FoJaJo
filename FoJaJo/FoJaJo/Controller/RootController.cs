using FoJaJo.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoJaJo.Controller
{
    public class RootController
    {
        public RootForm RootForm { get; set; }
        public RootController(RootForm rootForm)
        {
            RootForm = rootForm;
        }

    }
}
