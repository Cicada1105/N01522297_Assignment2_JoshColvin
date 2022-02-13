using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01522297_Assignment2_JoshColvin.Controllers
{
    /***************/
    /*   J2 2017   */
    /***************/
    public class J2Controller : ApiController
    {
        /// <summary>
        /// Takes an integer numShifts and loops through each number (starting at 0), 
        /// raising 10 to the numShifts power each time and adding it to a sum. 
        /// This sum is returned
        /// 
        /// Constraints:
        /// 1 <= startingNum <= 10000
        /// 0 <= numShifts <= 5
        /// </summary>
        /// <param name="startingNum">Number to apply shift sum</param>
        /// <param name="numShifts">Number of shifts applied to startingNum</param>
        /// <example>
        ///     GET api/J2/ShiftySum/12/0   ->  12
        /// </example>
        /// <example>
        ///     GET api/J2/ShiftySum/12/1   ->  132
        /// </example>
        /// <example>
        ///     GET api/J2/ShiftySum/12/2   ->  1332
        /// </example>
        /// <example>
        ///     GET api/J2/ShiftySum/12/3   ->  13332
        /// </example>
        /// <example>
        ///     GET api/J2/ShiftySum/12/4   ->  133332
        /// </example>
        /// <example>
        ///     GET api/J2/ShiftySum/12/5   ->  1333332
        /// </example>
        /// <returns>The sum of adding up startingNum * 10 ^numShifts recursively?</returns>
        [HttpGet]
        [Route("api/J2/ShiftySum/{startingNum}/{numShifts}")]
        public int ShiftySum(int startingNum, int numShifts)
        {
            int sum = 0;

            for (int power = 0; power <= numShifts; power++)
            {
                sum += startingNum * (int)Math.Pow(10, power);
            }

            return sum;
        }
    }
}
