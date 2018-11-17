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
        [HttpGet("{id}")]
        public async Task<Aircraft> Get(int id)
        {
            Aircraft aircraft;
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var query = @"
SELECT 
       Id
      ,Manufacturer
      ,Model
      ,RegistrationNumber
      ,FirstClassCapacity
      ,RegularClassCapacity
      ,CrewCapacity
      ,ManufactureDate
      ,NumberOfEngines
      ,EmptyWeight
      ,MaxTakeoffWeight
  FROM Aircraft WHERE Id = @Id";

                aircraft = await connection.QuerySingleAsync<Aircraft>(query, new { Id = id });
            }
            return aircraft;
        }



        // get group of objects; based off of https://www.davepaquette.com/archive/2018/01/22/loading-an-object-graph-with-dapper.aspx
        [HttpGet]
        public async Task<IEnumerable<Aircraft>> Get()
        {
            IEnumerable<Aircraft> aircraft;

            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var query = @"
SELECT 
       Id
      ,Manufacturer
      ,Model
      ,RegistrationNumber
      ,FirstClassCapacity
      ,RegularClassCapacity
      ,CrewCapacity
      ,ManufactureDate
      ,NumberOfEngines
      ,EmptyWeight
      ,MaxTakeoffWeight
  FROM Aircraft";
                aircraft = await connection.QueryAsync<Aircraft>(query);
            }
            return aircraft;
        }
    }
}
