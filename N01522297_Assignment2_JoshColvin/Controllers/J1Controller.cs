using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01522297_Assignment2_JoshColvin.Controllers
{
    /***************/
    /*   J1 2017   */
    /***************/
    public class J1Controller : ApiController
    {
        /// <summary>
        /// Takes a coordinate and returns what quadrant in the X-Y axis it resides in
        /// 
        /// Constraints:
        /// -1000 <= x <= 1000; x != 0
        /// -1000 <= y <= 1000; y != 0
        /// </summary>
        /// <example>
        ///     GET api/J1/QuadrantSelection/12/5     -> 1
        /// </example>
        /// <example>
        ///     GET api/J1/QuadrantSelection/9/-13    -> 4
        /// </example>
        /// <example>
        ///     GET api/J1/QuadrantSelection/-12/5    -> 2
        /// </example>
        /// <example>
        ///     GET api/J1/QuadrantSelection/-12/-5   -> 3
        /// </example>
        /// <example>
        ///     GET api/J1/QuadrantSelection/12/-5     -> 4
        /// </example>
        /// <param name="x">Integer value for x-coordinate</param>
        /// <param name="y">Integer value for y-coordinate</param>
        /// <returns>Integer quadrant</returns>
        [HttpGet]
        [Route("api/J1/QuadrantSelection/{x}/{y}")]
        public int QuadrantSelection(int x, int y)
        {
            int quadrant = 0;

            // Check if x is positive
            if (x > 0)
            {
                // Check if y is positive
                if (y > 0)
                {
                    // Coordinates reside in quadrant 1 (both coordinates are positive)
                    quadrant = 1;
                }
                else
                {
                    // Coordinates reside in quadrant 4 (x-coordinate is positive and y-coordinate is negative)
                    quadrant = 4;
                }
            }
            else
            {
                // Check if y is positive
                if (y > 0)
                {
                    // Coordinates reside in quadrant 2 (x-coordinate is negative and y-coordniate is positive
                    quadrant = 2;
                }
                else
                {
                    // Coordinates reside in quadrant 3 (booth coordinates are negative)
                    quadrant = 3;
                }
            }

            return quadrant;
        }
    }
}
