using Microsoft.AspNetCore.Mvc;
using R2.Data.NoSql.MongoDb.Api.Application.ViewModel;
using R2.Data.NoSql.MongoDb.Api.Domain.Interface;
using System;
using System.Threading.Tasks;

namespace R2.Data.NoSql.MongoDb.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : BaseController
    {
        private readonly IUserRepository _repository;

        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]UserRequest vmodel)
        {
            try
            {
                if (vmodel == null)
                    return Response(null, new ArgumentException("Requisicao invalida!"));

                await _repository.Add(vmodel);

                return Response(true);
            }
            catch (Exception e)
            {
                return Response(null, e);
            }
        }
    }
}