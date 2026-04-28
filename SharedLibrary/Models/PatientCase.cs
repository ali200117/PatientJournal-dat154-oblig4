using System;
using System.Collections.Generic;
using System.Text;

namespace SharedLibrary.Models
{
    public class PatientCase
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Age { get; set; }

        public string Sex { get; set; } = string.Empty;

        public double Weight { get; set; }

        public string Diagnosis { get; set; } = string.Empty;

        public bool Active { get; set; }
    }
}