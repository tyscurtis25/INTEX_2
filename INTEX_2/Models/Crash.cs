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
        [Required]
        [DataType(DataType.DateTime,
        ErrorMessage = "Must be in valid DateTime Format")]
        public DateTime? crash_datetime { get; set; }
        [Required]
        [Range(1, 1000, ErrorMessage = "Value must be between 1 to 1000")]
        public int? route { get; set; }
        [Required]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Value must have 2 decimal places")]
        public double? milepoint { get; set; }
        [Required]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Value must have 2 decimal places")]
        public double? lat_utm_y { get; set; }
        [Required]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Value must have 2 decimal places")]
        public double? long_utm_x { get; set; }
        [Required]
        [StringLength(50)]
        public string? main_road  { get; set; }
        [Required]
        [StringLength(50)]
        public string? city { get; set; }
        [Required]
        [StringLength(50)]
        public string? county_name { get; set; }
        [Required]
        [Range(1,5,
        ErrorMessage = "Value must be between 1 and 5.")]
        public int crash_severity_id { get; set; }
        [Required]
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} (to indicate 'false') and {2} (to indicate 'true').")]
        public int? work_zone_related { get; set; }
        [Required]
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} (to indicate 'false') and {2} (to indicate 'true').")]
        public int? pedestrian_involved { get; set; }
        [Required]
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} (to indicate 'false') and {2} (to indicate 'true').")]
        public int? bicyclist_involved { get; set; }
        [Required]
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} (to indicate 'false') and {2} (to indicate 'true').")]
        public int? motorcycle_involved { get; set; }
        [Required]
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} (to indicate 'false') and {2} (to indicate 'true').")]
        public int? improper_restraint { get; set; }
        [Required]
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} (to indicate 'false') and {2} (to indicate 'true').")]
        public int? unrestrained { get; set; }
        [Required]
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} (to indicate 'false') and {2} (to indicate 'true').")]
        public int? dui { get; set; }
        [Required]
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} (to indicate 'false') and {2} (to indicate 'true').")]
        public int? intersection_related { get; set; }
        [Required]
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} (to indicate 'false') and {2} (to indicate 'true').")]
        public int? wild_animal_related { get; set; }
        [Required]
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} (to indicate 'false') and {2} (to indicate 'true').")]
        public int? domestic_animal_related { get; set; }
        [Required]
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} (to indicate 'false') and {2} (to indicate 'true').")]
        public int? overturn_rollover { get; set; }
        [Required]
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} (to indicate 'false') and {2} (to indicate 'true').")]
        public int? commercial_motor_veh_involved { get; set; }
        [Required]
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} (to indicate 'false') and {2} (to indicate 'true').")]
        public int? teenage_driver_involved { get; set; }
        [Required]
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} (to indicate 'false') and {2} (to indicate 'true').")]
        public int? older_driver_involved { get; set; }
        [Required]
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} (to indicate 'false') and {2} (to indicate 'true').")]
        public int? night_dark_condition { get; set; }
        [Required]
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} (to indicate 'false') and {2} (to indicate 'true').")]
        public int? single_vehicle { get; set; }
        [Required]
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} (to indicate 'false') and {2} (to indicate 'true').")]
        public int? distracted_driving { get; set; }
        [Required]
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} (to indicate 'false') and {2} (to indicate 'true').")]
        public int? drowsy_driving { get; set; }
        [Required]
        [Range(0, 1,
        ErrorMessage = "Value for {0} must be between {1} (to indicate 'false') and {2} (to indicate 'true').")]
        public int? roadway_departure { get; set; }

    }
}
