/****************************************************************************************************************************************
 * 
 * Class Address
 * Author : S. ALVAREZ
 * Date : 04-09-2021
 * Status : In Progress
 * Version : 1
 * Revisions : 1 - 04-09-2021 : first version
 *  
 * Object : class that represent a postal address.
 * 
 ****************************************************************************************************************************************/

namespace EasyLoca.Model
{
    public class Address
    {
        // PROPERTIES
        /// <summary>
        /// Postal address
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// Postal address (complement)
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// City code
        /// </summary>
        public string CityCode { get; set; }

        /// <summary>
        /// City name
        /// </summary>
        public string CityName { get; set; }

        // CONSTRUCTORS
        /// <summary>
        /// Default constructor
        /// </summary>
        public Address()
        {
        }

        /// <summary>
        /// Creates an instance
        /// </summary>
        /// <param name="a_address1">Postal address</param>
        /// <param name="a_address2">Postal address (complement)</param>
        /// <param name="a_cityCode">City code</param>
        /// <param name="a_cityName">City name</param>
        public Address(string a_address1,
                      string a_address2,
                      string a_cityCode,
                      string a_cityName)
        {
            Address1 = a_address1;
            Address2 = a_address2;
            CityCode = a_cityCode;
            CityName = a_cityName;
        }

        // METHODS
        // No method...

    }
}