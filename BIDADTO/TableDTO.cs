using System;

namespace BIDADTO
{
    public class TableDTO
    {
        public int IdTable { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public string Status { get; set; }
        public DateTime? StartTime { get; set; }
        public TimeSpan? PlayTime { get; set; }
        public string KhuVuc { get; set; } 

        public TableDTO(int idTable, string name, int typeId, string typeName, string status, string khuVuc, DateTime? startTime = null)
        {
            IdTable = idTable;
            Name = name;
            TypeId = typeId;
            TypeName = typeName;
            Status = status;
            KhuVuc = khuVuc; 
            this.StartTime = startTime;
            PlayTime = null;
        }
    }
}