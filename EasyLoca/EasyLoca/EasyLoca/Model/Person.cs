/****************************************************************************************************************************************
 * 
 * Class Person
 * Author : S. ALVAREZ
 * Date : 04-09-2021
 * Status : In Progress
 * Version : 1
 * Revisions : 1 - 04-09-2021 : first version
 *  
 * Object : class that represent a person.
 * 
 ****************************************************************************************************************************************/

namespace EasyLoca.Model
{
    public class Person
    {
        // PROPERTIES
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Firstname
        /// </summary>
        public string Firstname { get; set; }

        /// <summary>
        /// Postal address
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Phone number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Mobile phone number
        /// </summary>
        public string MobilePhoneNumber { get; set; }

        /// <summary>
        /// Email address
        /// </summary>
        public string EmailAddress { get; set; }

        // CONSTRUCTORS
        /// <summary>
        /// Default constructor
        /// </summary>
        public Person()
        {
        }

        /// <summary>
        /// Creates an instance
        /// </summary>
        /// <param name="a_name">Name</param>
        /// <param name="a_firstname">Firstname</param>
        /// <param name="a_address">Postal address</param>
        /// <param name="a_phoneNumber">Phone number</param>
        /// <param name="a_mobilePhoneNumber">Mobile phone number</param>
        /// <param name="a_emailAddress">Email address</param>
        public Person(string a_name,
                      string a_firstname,
                      Address a_address,
                      string a_phoneNumber,
                      string a_mobilePhoneNumber,
                      string a_emailAddress)
        {
            Name = a_name;
            Firstname = a_firstname;
            Address = a_address;
            PhoneNumber = a_phoneNumber;
            MobilePhoneNumber = a_mobilePhoneNumber;
            EmailAddress = a_emailAddress;
        }

        /// <summary>
        /// Creates an instance
        /// </summary>
        /// <param name="a_name">Name</param>
        /// <param name="a_firstname">Firstname</param>
        /// <param name="a_address1">Postal address</param>
        /// <param name="a_address2">Postal address (complement)</param>
        /// <param name="a_cityCode">City code</param>
        /// <param name="a_cityName">City name</param>
        /// <param name="a_phoneNumber">Phone number</param>
        /// <param name="a_mobilePhoneNumber">Mobile phone number</param>
        /// <param name="a_emailAddress">Email address</param>
        public Person(string a_name,
                      string a_firstname,
                      string a_address1,
                      string a_address2,
                      string a_cityCode,
                      string a_cityName,
                      string a_phoneNumber,
                      string a_mobilePhoneNumber,
                      string a_emailAddress)
        {
            Name = a_name;
            Firstname = a_firstname;
            Address = new Address(a_address1, a_address2, a_cityCode, a_cityName);
            PhoneNumber = a_phoneNumber;
            MobilePhoneNumber = a_mobilePhoneNumber;
            EmailAddress = a_emailAddress;
        }

        // METHODS
        // No method...

    }
}