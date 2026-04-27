using System;
using System.Collections.Generic;
using System.Text;

namespace SharedLibrary.Models
{
    internal class VitalSigns
    {


        int Id;
        int PatientCaseId;
        int BloodPressure;
        double HeartRate;
        int OxygenSaturation;
        double Temperature;
        TimeSpan TimeStamp;
    }
}
