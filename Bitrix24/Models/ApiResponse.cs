using System.Collections.Generic;

namespace Bitrix24.Models
{
    public class ApiResponse
    {
        public List<User> Result { get; set; }
        public int Total { get; set; }
        public TimeInfo Time { get; set; }
    }

    public class TimeInfo
    {
        public double Start { get; set; }
        public double Finish { get; set; }
        public double Duration { get; set; }
        public double Processing { get; set; }
        public string DateStart { get; set; }
        public string DateFinish { get; set; }
        public int OperatingResetAt { get; set; }
        public double Operating { get; set; }
    }
}
