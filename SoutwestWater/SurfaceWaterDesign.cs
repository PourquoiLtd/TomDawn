using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoutwestWater
{
    public class SurfaceWaterDesign
    {

        public SurfaceWaterDesign(string sudMeasures,
                               string other
                               )
            {
                SudMeasures = sudMeasures;
                Other = other;
            }

        public SurfaceWaterDesign()
            {

            }

        public string SudMeasures { get; set; }
        public string Other { get; set; }
        }
    
}
