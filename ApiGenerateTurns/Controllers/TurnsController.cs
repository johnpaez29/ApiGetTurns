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
        IRepositoryTurn<Turno, RequestTurn> repositoryTurn;
        IrepositoryService<Servicio> repositoryService;

        public TurnsController(IRepositoryTurn<Turno, RequestTurn> repositoryTurn, IrepositoryService<Servicio> repositoryService) 
        {
            this.repositoryTurn = repositoryTurn;
            this.repositoryService = repositoryService;
        }


        [HttpPost]
        public IEnumerable<Turno> GetTurns(VMRequestTurn requestTurn)
        {
            if (!ModelState.IsValid)
                return null;
            IEnumerable<Turno> turnos;
            Servicio servicio;
            try
            {
                servicio = repositoryService.GetDataByName(requestTurn.IdServicio);
                if (servicio == null || servicio.id_servicio == 0)
                    return null;
                RequestTurn requestTurnData = new RequestTurn
                {
                    FechaInicio = requestTurn.FechaInicio,
                    FechaFin = requestTurn.FechaFin,
                    IdServicio = 43
                };
                turnos = repositoryTurn.GetData(requestTurnData);

            }
            catch (Exception e)
            {

                return null;
            }

            return turnos;
        }
    }
}
