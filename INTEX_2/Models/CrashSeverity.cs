using Microsoft.ML.OnnxRuntime.Tensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INTEX_2.Models
{
    public class CrashSeverity
    {
        public float Lat_utm_y { get; set; }
        public float Long_utm_x { get; set; }
        public float Intersection_Related_False { get; set; }
        public float Intersection_Related_True { get; set; }
        public float Teenage_driver_involved_false { get; set; }
        public float Teenage_driver_involved_true { get; set; }
        public float Older_driver_involved_false { get; set; }
        public float Older_driver_involved_true { get; set; }
        public float Night_dark_condition_false { get; set; }
        public float Night_dark_condition_true { get; set; }
        public float Single_vehicle_false { get; set; }
        public float Single_vehicle_true { get; set; }
        public float Roadway_departure_false { get; set; }
        public float Roadway_departure_true { get; set; }
        public float Route_15 { get; set; }
        public float Route_Other { get; set; }
        public float Main_road_name_Other { get; set; }
        public float Main_road_name_I15 { get; set; }
        public float milepoint_0_1 { get; set; }
        public float Crash_severity_id { get; set; }
        public float Hour_17 { get; set; }
        public float Month_1 { get; set; }
        public float Year_2018 { get; set; }
        public float Year_2017 { get; set; }
        public float Year_2016 { get; set; }
        public float County_name_UTAH { get; set; }
        public float County_name_SALT_LAKE { get; set; }
        public float County_name_Other { get; set; }
        public float City_Other { get; set; }
        public float City_OUTSIDE_CITY_LIMITS { get; set; }

        public Tensor<float> AsTensor()
        {
            float[] data = new float[]
            {
                Lat_utm_y, Long_utm_x, Intersection_Related_False, Intersection_Related_True,
                Teenage_driver_involved_false, Teenage_driver_involved_true, Older_driver_involved_false,
                Older_driver_involved_true, Night_dark_condition_false, Night_dark_condition_true, Single_vehicle_false,
                Single_vehicle_true, Roadway_departure_false, Roadway_departure_true, Route_15, Route_Other, Main_road_name_Other, Main_road_name_I15,
                milepoint_0_1, Crash_severity_id, Hour_17, Month_1, Year_2018, Year_2017, Year_2016, County_name_UTAH, 
                County_name_SALT_LAKE, County_name_Other, City_Other, City_OUTSIDE_CITY_LIMITS

            };
            int[] dimensions = new int[] { 1, 30 };
            return new DenseTensor<float>(data, dimensions);
        }
    }
}
