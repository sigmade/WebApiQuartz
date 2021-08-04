using System;

namespace WebApiQuartz.DB
{
    public class RecordMddel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Message { get; set; }
    }
}