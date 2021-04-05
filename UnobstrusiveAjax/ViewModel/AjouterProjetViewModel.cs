using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnobstrusiveAjax.ViewModel
{
    public class AjouterProjetViewModel
    {
        public IList<ValidationMembreViewModel> Membres { get; set; }

        public AjouterProjetViewModel()
        {
            Membres = new List<ValidationMembreViewModel>() { new ValidationMembreViewModel(), new ValidationMembreViewModel() };
        }
    }
}