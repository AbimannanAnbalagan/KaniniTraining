using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public partial class Appointment
    {
        public int AppointmentId { get; set; }

        public int? PatientId { get; set; }

        public int? DoctorId { get; set; }

        public DateTime? Date { get; set; }

        public TimeSpan? Time { get; set; }

        public string? Purpose { get; set; }

        public int? PatientAge { get; set; }

        public string? PatientGender { get; set; }

        public string? Status { get; set; }

        public virtual Doctor? Doctor { get; set; }

        public virtual Patient? Patient { get; set; }
    }
}
