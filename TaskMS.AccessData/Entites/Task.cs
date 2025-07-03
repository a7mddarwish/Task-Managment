using TaskMS.AccessData.Entites.Enums;

namespace TaskMS.AccessData.Entites
{
    public class Task
    {


        public int Id { get; set; }

        public string Title{ get; set; }

        public string? Description{ get; set; }

        public DateTime DueDate { get; set; }

        public enStatus Status { get; set; }

        public enPriority Priority { get; set; }


    }
}
