using Newtonsoft.Json.Linq;

namespace BlazorWebApp.Models
{
    public class ApiModel
    {
        public string lat { get; set; }
        public string lng { get; set; }
        public string label { get; set; }
        public string trip { get; set; }
        public string VehicleID { get; set; }
        public string BlockID { get; set; }
        public string Direction { get; set; }
        public string destination { get; set; }
        public string heading { get; set; }
        public int late { get; set; }
        public string next_stop_id { get; set; }
        public string next_stop_name { get; set; }
        public int next_stop_sequence { get; set; }
        public string estimated_seat_availability { get; set; }
        public string Offset { get; set; }
        public string Offset_sec { get; set; }
        public int timestamp { get; set; }
    }

    public class RootModel
    {
        public List<ApiModel> model { get; set; }

    }
}
