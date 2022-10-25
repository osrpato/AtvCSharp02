using CarParkingAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarAPI.Controllers
{
    internal interface ICarRepository
    {
        Task Create(Car car);
        Task Delete(object id);
        Task<object> Delete();
        Task<ActionResult<Car>> Get(int id);
        Task<IEnumerable<Car>> List(int parkingId);
    }
}