using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiQuartz.DB;

namespace WebApiQuartz
{
    public class RecordSevice
    {
        private readonly ApplicationDbContext _db;

        public RecordSevice(ApplicationDbContext db)
        {
            _db = db;
        }

        //Метод который будет триггериться джобой или вручную контроллером
        public async Task AddRecord(string message)
        {
            _db.Records.Add(new RecordMddel() { Message = message });
            await _db.SaveChangesAsync();
        }

        public async Task<List<RecordMddel>> GetRecords()
        {
            return await _db.Records.ToListAsync();
        }
    }
}
