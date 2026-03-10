using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalBomCodigo.Models
{
    public class Exam
    {
        public Guid Id { get; private set; }
        public string Type { get; set; }
        public string? Description { get; private set; }
        public ExamStatus Status { get; private set; } = ExamStatus.Pending;

        public bool NotificationSent { get; private set; }
        public DateTime? ResultReleasedAt { get; private set; }

    }

    public enum ExamStatus
    {
        Pending = 1,
        Released = 2
    }
}

