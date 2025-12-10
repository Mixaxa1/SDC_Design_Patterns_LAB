using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task2v2.Db;
using Task2v2.Db.Entities;
using Task2v2.SecondController;

namespace Task2v2
{
    [ApiController]
    [Route("[controller]")]
    public class SecondApiController : ControllerBase
    {
        private ISecondApiOperations _secondApiOperations;
        private IFirstApiOperations _firstApiOperations;

        public SecondApiController(ISecondApiOperations secondApiOperations, IFirstApiOperations firstApiOperations)
        {
            _secondApiOperations = secondApiOperations;
            _firstApiOperations = firstApiOperations;
        }

        [HttpPut("img/{id}")]
        public void SetImage(Guid id, [FromQuery] string image)
        {
            _secondApiOperations.SetImage(id, image);
        }

        [HttpGet("img/{id}")]
        public string GetImage(Guid id)
        {
            return _secondApiOperations.GetImage(id);
        }

        [HttpGet("img/many/")]
        public List<SomeImageEntity> GetEntitiesByFilter([FromQuery] Expression<Func<SomeImageEntity, bool>> filter)
        {
            return _secondApiOperations.GetEntitiesByFilter(filter);
        }

        [HttpPost]
        public void Create(SomeImageEntity entity)
        {
            _firstApiOperations.Create(entity);
        }

        [HttpPut]
        public void Update(SomeImageEntity entity)
        {
            _firstApiOperations.Update(entity);
        }

        [HttpGet("{id}")]
        public async Task<SomeImageEntity?> GetOneById(Guid id)
        {
            return await _firstApiOperations.GetOneById(id);
        }

        [HttpGet]
        public async Task<List<SomeImageEntity>?> GetMany()
        {
            return await _firstApiOperations.GetMany();
        }

        [HttpGet("byFilter/")]
        public async Task<SomeImageEntity?> GetByFilter([FromQuery] Expression<Func<SomeImageEntity, bool>> filter)
        {
            return await _firstApiOperations.GetByFilter(filter);
        }

        [HttpDelete]
        public void Delete([FromQuery] Guid id)
        {
            _firstApiOperations.Delete(id);
        }

        [HttpDelete("many/")]
        public void DeleteMany([FromQuery] List<Guid> entityRange)
        {
            _firstApiOperations.DeleteMany(entityRange);
        }

        [HttpGet("print/{id}")]
        public void PrintById(Guid id)
        {
            _firstApiOperations.PrintById(id);
        }

        [HttpGet("print/")]
        public void PrintMany()
        {
            _firstApiOperations.PrintMany();
        }

        [HttpPut("changeStatus/{id}")]
        public void SetStatus(Guid entityId, [FromQuery] string status)
        {
            _firstApiOperations.SetStatus(entityId, status);
        }


        [HttpPut("changeStatus/activate")]
        public void Activate(Guid entityId)
        {
            _firstApiOperations.Activate(entityId);
        }

        [HttpPut("changeStatus/deactivate")]
        public void Deactivate(Guid entityId)
        {
            _firstApiOperations.Deactivate(entityId);
        }
    }
}
