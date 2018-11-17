using Dapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace HH_client_manager.Models.Database
{
    public class HHDBQuery
{

        // get single object; based off of https://www.davepaquette.com/archive/2018/01/22/loading-an-object-graph-with-dapper.aspx 
        //        [HttpGet("{id}")]
        //        public async Task<Aircraft> Get(int id)
        //        {
        //            Aircraft aircraft;
        //            using (var connection = new SqlConnection("Server=tcp:hopehealing.database.windows.net,1433;Initial Catalog=HopeandHealingDashboardSystem;Persist Security Info=False;User ID=ArianneKJones;Password=NetAssets2018;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
        //            {
        //                await connection.OpenAsync();
        //                var query = @"
        //SELECT 
        //       Id
        //      ,Manufacturer
        //      ,Model
        //      ,RegistrationNumber
        //      ,FirstClassCapacity
        //      ,RegularClassCapacity
        //      ,CrewCapacity
        //      ,ManufactureDate
        //      ,NumberOfEngines
        //      ,EmptyWeight
        //      ,MaxTakeoffWeight
        //  FROM Aircraft WHERE Id = @Id";

        //                aircraft = await connection.QuerySingleAsync<Aircraft>(query, new { Id = id });
        //            }
        //            return aircraft;
        //        }



        // get group of objects; based off of https://www.davepaquette.com/archive/2018/01/22/loading-an-object-graph-with-dapper.aspx
        [HttpGet]
        public async Task<IEnumerable<Gender>> Get()
        {
            IEnumerable<Gender> gender;

            using (var connection = new SqlConnection("Server=tcp:hopehealing.database.windows.net,1433;Initial Catalog=HopeandHealingDashboardSystem;Persist Security Info=False;User ID={username};Password={password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                await connection.OpenAsync();
                var query = @"
SELECT 
       Gender
  FROM Gender";
                gender = await connection.QueryAsync<Gender>(query);
            }
            return gender;
        }
    }
}
