using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01522297_Assignment2_JoshColvin.Controllers
{
    /***************/
    /*   J3 2017   */
    /***************/
    public class J3Controller : ApiController
    {
        /// <summary>
        /// Takes two coordinates and determines if an additional integer parameter can follow the path
        /// from the first coordinate to the last coordinate without having any more or less steps left
        /// 
        /// Constraints:
        /// (x1,y1)(-1000 <= x1 <= 1000; -1000 <= y1 <= 1000)
        /// (x2,y2)(-1000 <= x2 <= 1000; -1000 <= y2 <= 1000)
        /// 0 <= batteryCharge <= 10000
        /// </summary>
        /// <param name="x1">Integer value of starting x position</param>
        /// <param name="y1">Integer value of starting y position</param>
        /// <param name="x2">Integer value of ending x position</param>
        /// <param name="y2">Integer value of ending y position</param>
        /// <param name="batteryCharge">Amount of steps to check</param>
        /// <example>
        ///     GET api/J3/ExactlyElectrical/3/4/3/3/3  -> "Y"
        /// </example>
        /// <example>
        ///     GET api/J3/ExactlyElectrical/1/1/4/2/5  -> "N"
        /// </example>
        /// <example>
        ///     GET api/J3/ExactlyElectrical/5/2/0/5/12 -> "Y"
        /// </example>
        /// <returns>String containing "Y" or "N" indicating if route can be completed</returns>
        [HttpGet]
        [Route("api/J3/ExactlyElectrical/{x1}/{y1}/{x2}/{y2}/{batteryCharge}")]
        public string ExactlyElectrical(int x1, int y1, int x2, int y2, int batteryCharge)
        {
            // Start with pessimistic approach: user cannot make it
            string canTraverse = "N";

            // Determine minimum charge needed to make it to destination (add the differences of respective coordinates)
            int minCharge = (y2 - y1) + (x2 - x1);

            // Check if user meets minimum requirements 
            if (batteryCharge >= minCharge)
            {
                /*
                    Values greater than minCharge can make it if:
                        minCharge is odd and batteryCharge is odd
                        -or-
                        minCharge is even and batteryCharge is even
                */
                // Check if both values are even (divisible by 2)
                if ((minCharge % 2 == 0) && (batteryCharge % 2 == 0))
                    canTraverse = "Y";
                // Else check if both values are odd (not divisible by 2)
                else if ((minCharge % 2 != 0) && (batteryCharge % 2 != 0))
                    canTraverse = "Y";
            }

            return canTraverse;
        }
    }
}
