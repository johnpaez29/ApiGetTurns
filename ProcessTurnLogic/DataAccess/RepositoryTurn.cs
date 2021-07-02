using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ProcessTurnLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessTurnLogic.DataAccess
{
    public class RepositoryTurn : IRepositoryTurn<Turno, VMRequestTurn>
    {
        ControlTurnContext ControlTurnContext;

        public RepositoryTurn(ControlTurnContext controlTurn)
        {
            this.ControlTurnContext = controlTurn;
        }
        public IEnumerable<Turno> GetData(VMRequestTurn info)
        {
            var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@IdServicio",
                            SqlDbType =  System.Data.SqlDbType.BigInt,
                            Size = 100,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = info.IdServicio
                        },
                        new SqlParameter() {
                            ParameterName = "@FechaInicio",
                            SqlDbType =  System.Data.SqlDbType.DateTime,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = info.FechaInicio.ToString("dd/MM/yyyy")
                        },
                        new SqlParameter() {
                            ParameterName = "@FechaFin",
                            SqlDbType =  System.Data.SqlDbType.DateTime,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = info.FechaFin.ToString("dd/MM/yyyy")
                        }};
            return ControlTurnContext.Turnos.FromSqlRaw("GetTurns @IdServicio, @FechaInicio, @FechaFin", param);
        }
    }
}
