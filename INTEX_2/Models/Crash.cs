using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

#nullable enable

namespace INTEX_2.Models
{
    public class Crash
    {
        [Key]
        [Required]
        public int crash_id { get; set; }
        public DateTime? crash_datetime { get; set; }
        public int? route { get; set; }
        public double? milepoint { get; set; }
        public double? lat_utm_y { get; set; }
        public double? long_utm_x { get; set; }
        public string? main_road  { get; set; }
        public string? city { get; set; }
        public string? county_name { get; set; }
        [Required]
        public int crash_severity_id { get; set; }
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int? work_zone_related { get; set; }
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int? pedestrian_involved { get; set; }
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int? bicyclist_involved { get; set; }
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int? motorcycle_involved { get; set; }
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int? improper_restraint { get; set; }
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int? unrestrained { get; set; }
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int? dui { get; set; }
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int? intersection_related { get; set; }
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int? wild_animal_related { get; set; }
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int? domestic_animal_related { get; set; }
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int? overturn_rollover { get; set; }
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int? commercial_motor_veh_involved { get; set; }
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int? teenage_driver_involved { get; set; }
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int? older_driver_involved { get; set; }
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int? night_dark_condition { get; set; }
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int? single_vehicle { get; set; }
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int? distracted_driving { get; set; }
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int? drowsy_driving { get; set; }
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int? roadway_departure { get; set; }

    }
}
