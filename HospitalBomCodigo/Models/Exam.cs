using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalBomCodigo.Models
{
    public class Exam
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string? Description { get; set; }
        public ExamStatus Status { get; set; } = ExamStatus.Pending;
        public bool NotificationSent { get; set; }
        public DateTime? ResultReleasedAt { get; set; }
        public Guid PatientId { get; set; }
        public Patient Patient { get; set; }

    }

    public enum ExamStatus
    {
        Pending = 1,
        Released = 2
    }
}

