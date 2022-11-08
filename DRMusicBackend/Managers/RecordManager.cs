using DRMusicBackend.Models;

namespace DRMusicBackend.Managers
{
    public class RecordManager
    {

        private static List<Record> _records = new List<Record>()
            {
                new Record(){ Id = 1, Artist = "Eminem", Duration = 180, Title="When im gone", PublicationYear = 1999 },
                new Record(){ Id = 2, Artist = "Nirvana", Duration = 300, Title="Some", PublicationYear = 1997 },
                new Record(){ Id = 3, Artist = "Metallica", Duration = 230, Title="One", PublicationYear = 2000 }
            };
       
     

        public List<Record> getAll()
            {
                return _records;
            }

        public void add(Record record)
        {
            if(record.Artist.ToUpper() == "EMINEM")
            {
                throw new ArgumentException("no more eminem");
            }
            _records.Add(record);
        }

        public void Remove(int id)
        {
            if (id < 1)
            {
                throw new Exception("Invalid id");
            }
            else
            {
                _records.RemoveAt(id);
            }
        }
}

};