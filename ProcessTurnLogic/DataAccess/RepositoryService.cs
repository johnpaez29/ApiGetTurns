using ProcessTurnLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProcessTurnLogic.DataAccess
{
    public class RepositoryService : IrepositoryService<Servicio>
    {
        ControlTurnContext turnContext;
        public RepositoryService(ControlTurnContext turnContext)
        {
            this.turnContext = turnContext;
        }
        public Servicio GetDataByName(string name)
        {
            var a = turnContext.servicios.Where(company => true);
            return turnContext.servicios.FirstOrDefault(company => company.nom_servicio == name);

        }
    }
}
