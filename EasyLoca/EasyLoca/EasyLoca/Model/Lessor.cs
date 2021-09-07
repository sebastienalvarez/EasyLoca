/****************************************************************************************************************************************
 * 
 * Class Lessor
 * Author : S. ALVAREZ
 * Date : 04-09-2021
 * Status : In Progress
 * Version : 1
 * Revisions : 1 - 04-09-2021 : first version
 *  
 * Object : class that represent a lessor, inherits from Person class.
 * 
 ****************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace EasyLoca.Model
{
    public class Lessor : Person
    {
        // PROPERTIES
        /// <summary>
        /// Bank IBAN
        /// </summary>
        public string Iban { get; set; }

        /// <summary>
        /// Parameterized email
        /// </summary>
        public Email Email { get; set; }

        /// <summary>
        /// Signature filepath
        /// </summary>
        public string Signature { get; set; }

        // CONSTRUCTORS
        /// <summary>
        /// Default constructor
        /// </summary>
        public Lessor() : base()
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
        /// <param name="a_iban">Bank IBAN</param>
        /// <param name="a_email">Parameterized email</param>
        /// <param name="a_signature">Signature filepath</param>
        public Lessor(string a_name,
                      string a_firstname,
                      Address a_address,
                      string a_phoneNumber,
                      string a_mobilePhoneNumber,
                      string a_iban,
                      Email a_email,
                      string a_signature) : base(a_name, a_firstname, a_address, a_phoneNumber, a_mobilePhoneNumber, a_email.Address)
        {
            Iban = a_iban;
            Email = a_email;
            Signature = a_signature;
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
        /// <param name="a_iban">Bank IBAN</param>
        /// <param name="a_email">Parameterized email</param>
        /// <param name="a_signature">Signature filepath</param>
        public Lessor(string a_name, 
                      string a_firstname, 
                      string a_address1, 
                      string a_address2,
                      string a_cityCode, 
                      string a_cityName, 
                      string a_phoneNumber, 
                      string a_mobilePhoneNumber,
                      string a_iban, 
                      Email a_email, 
                      string a_signature) : base(a_name, a_firstname, a_address1, a_address2, a_cityCode, a_cityName, a_phoneNumber, a_mobilePhoneNumber, a_email.Address)
        {
            Iban = a_iban;
            Email = a_email;
            Signature = a_signature;
        }

        // METHODS
        // No method...

    }
}