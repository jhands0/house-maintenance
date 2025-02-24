namespace backend.Models;
{
    public class TaskEntry
    {
        public long Id { get; set; }
        public int RoomNo { get; set; }
        public string Task { get; set; }
        public int Code { get; set; }
        public string Comments { get; set; }
        public bool Completed { get; set; }
        public DateTime Date { get; set; }
        public int Priority { get; set; }

        # TODO: Change RoomNo, Code and Priority records to their own Enums
    }
}