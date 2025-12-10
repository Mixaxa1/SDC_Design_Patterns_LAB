using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web;
using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Task2v2.Db;
using Task2v2.Db.Entities;

namespace Task2v2.SecondController
{
    public class FirstControllerProxy : IFirstApiOperations
    {
        private AppDbContext _dbContext;
        private DbSet<SomeImageEntity> _imgEntities;
        private string _basePath = "a" + "FirstApi";

        public async Task Activate(Guid entityId)
        {
            var client = new HttpClient();
            var entity = _imgEntities.FirstOrDefault(x => x.Id == entityId);

            await client.GetAsync(new Uri(_basePath + $"activate/{entity.SomeEntityId}"));
        }

        public async Task<SomeImageEntity?> Create(SomeImageEntity entity)
        {
            var client = new HttpClient();

            var responce = await client.PostAsJsonAsync(new Uri(_basePath), entity.SomeEntity);

            var content = await responce.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<SomeEntity?>(content);

            var newEnt = new SomeImageEntity
            {
                Id = Guid.NewGuid(),
                SomeEntityId = result.Id,
                ImageUrl = entity.ImageUrl
            };

            _imgEntities.Add(newEnt);
            _dbContext.SaveChanges();

            return newEnt;  
        }

        public async Task Deactivate(Guid entityId)
        {
            var client = new HttpClient();
            var entity = _imgEntities.FirstOrDefault(x => x.Id == entityId);

            await client.GetAsync(new Uri(_basePath + $"deactivate/{entity.SomeEntityId}"));
        }

        public async Task Delete(Guid id)
        {
            var toDelete = await _imgEntities.FirstOrDefaultAsync(x => x.Id == id);

            var client = new HttpClient();

            await client.DeleteAsync(new Uri(_basePath + $"{toDelete.SomeEntityId}"));

            _imgEntities.Remove(toDelete);
            _dbContext.SaveChanges();
        }

        public async Task DeleteMany([FromQuery] List<Guid> entityRange)
        {
            var toDelete = _imgEntities.Where(x => entityRange.Contains(x.Id)).ToList();
            var listInnerEntitiesIds = new List<Guid>();

            foreach(var entity in toDelete)
            {
                listInnerEntitiesIds.Add(entity.SomeEntityId);
            }

            var builder = new UriBuilder(_basePath + "many/");
            var query = HttpUtility.ParseQueryString(string.Empty);
            query["entityRange"] = listInnerEntitiesIds.ToString();
            builder.Query = query.ToString();

            var client = new HttpClient();

            await client.DeleteAsync(builder.ToString());

            _imgEntities.RemoveRange(toDelete);
            _dbContext.SaveChanges();
        }

        public async Task<SomeImageEntity?> GetByFilter([FromQuery] Expression<Func<SomeImageEntity, bool>> filter)
        {
            var builder = new UriBuilder(_basePath + "byFilter/");
            var query = HttpUtility.ParseQueryString(string.Empty);
            query["filter"] = filter.ToString();
            builder.Query = query.ToString();

            var client = new HttpClient();

            var responce = await client.GetAsync(builder.ToString());
            var content = await responce.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<SomeEntity?>(content);
            var ent = _imgEntities.Where(x => x.SomeEntityId == result.Id).FirstOrDefault();
            ent.SomeEntity = result;

            return ent;
        }

        public async Task<List<SomeImageEntity>?> GetMany()
        {
            return await _imgEntities.ToListAsync();
        }

        public async Task<SomeImageEntity?> GetOneById(Guid id)
        {
            var ent = _imgEntities.FirstOrDefault(x => x.Id == id);

            var client = new HttpClient();

            var responce = await client.GetAsync(new Uri(_basePath) + $"{ent.SomeEntityId}");
            var content = await responce.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<SomeImageEntity?>(content);

            return result;
        }

        public async Task PrintById(Guid id)
        {
            var client = new HttpClient();

            await client.GetAsync(new Uri(_basePath + $"print/{id}"));
        }

        public async Task PrintMany()
        {
            var client = new HttpClient();

            await client.GetAsync(new Uri(_basePath + $"print/"));
        }

        public async Task SetStatus(int entityId, string status)
        {
            var builder = new UriBuilder(_basePath + "many/");
            var query = HttpUtility.ParseQueryString(string.Empty);
            query["status"] = status;
            builder.Query = query.ToString();

            var client = new HttpClient();

            await client.GetAsync(builder.ToString());
        }

        public Task SetStatus(Guid entityId, string status)
        {
            throw new NotImplementedException();
        }

        public async Task<SomeImageEntity> Update(SomeImageEntity entity)
        {
            var client = new HttpClient();

            var responce = await client.PutAsJsonAsync(new Uri(_basePath), entity.SomeEntity);

            var content = await responce.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<SomeEntity?>(content);

            entity.SomeEntityId = result.Id;
            _imgEntities.Update(entity);
            _dbContext.SaveChanges();

            return entity;
        }
    }
}
