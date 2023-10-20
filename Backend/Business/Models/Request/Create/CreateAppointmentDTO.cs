using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class CreateAppointmentDTO
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }
        public string Reason { get; set; }
        public bool IsConfirmed { get; set; }
        public int UserID { get; set; }
    }
}
