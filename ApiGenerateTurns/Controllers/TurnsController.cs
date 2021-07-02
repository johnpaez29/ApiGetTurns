using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProcessTurnLogic.DataAccess;
using ProcessTurnLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGenerateTurns.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TurnsController : ControllerBase
    {
        IRepositoryTurn<Turno, VMRequestTurn> repositoryTurn;
        public TurnsController(IRepositoryTurn<Turno, VMRequestTurn> repositoryTurn) 
        {
            this.repositoryTurn = repositoryTurn;
        }

        [HttpPost]
        public IEnumerable<Turno> GetTurns(VMRequestTurn requestTurn)
        {
            if (requestTurn == null)
                return null;
            IEnumerable<Turno> turnos = repositoryTurn.GetData(requestTurn);

            return turnos;
        }
    }
}
