/****************************************************************************************************************************************
 * 
 * Class Rental
 * Author : S. ALVAREZ
 * Date : 07-09-2021
 * Status : In Progress
 * Version : 1
 * Revisions : 1 - 07-09-2021 : first version
 *  
 * Object : class that represent a rental.
 * 
 ****************************************************************************************************************************************/


using System;
using System.Collections.Generic;
using System.Text;

namespace EasyLoca.Model
{
    public class Rental
    {
        // PROPERTIES
        /// <summary>
        /// Property related to the rental
        /// </summary>
        public Property Property { get; set; }

        /// <summary>
        /// Rental start date
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Rental end date
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Rent amount, it is a 3rd dimension array that correspond to rent without charge, charge and waste tax
        /// </summary>
        public double[] Rent { get; set; }

        /// <summary>
        /// Tenant
        /// </summary>
        public Person Tenant { get; set; }

        /// <summary>
        /// Guarantor
        /// </summary>
        public Person Guarantor { get; set; }

        /// <summary>
        /// Flag that indicates if the rental is empty (true) or with furniture (false)
        /// </summary>
        public bool IsEmpty { get; set; }

        /// <summary>
        /// Security Deposit
        /// </summary>
        public double SecurityDeposit { get; set; }

        /// <summary>
        /// Default payment day used to generate receipt
        /// </summary>
        public byte DefaultPaymentDay { get; set; }

        /// <summary>
        /// Signed contract file path
        /// </summary>
        public string SignedContractFilePath { get; set; }

        /// <summary>
        /// Charge Regularisation data per year
        /// </summary>
        public Dictionary<int, double> ChargeRegularizations { get; set; }

        // CONSTRUCTORS
        /// <summary>
        /// Default constructor
        /// </summary>
        public Rental()
        {
        }

        /// <summary>
        /// Creates an instance
        /// </summary>
        /// <param name="a_property">Property related to the rental</param>
        /// <param name="a_startDate">Rental start date</param>
        /// <param name="a_rent">Rent amount, it is a 3rd dimension array that correspond to rent without charge, charge and waste tax</param>
        /// <param name="a_tenant">Tenant</param>
        /// <param name="a_isEmpty">Flag that indicates if the rental is empty (true) or with furniture (false)</param>
        /// <param name="a_securityDeposit">Security Deposit</param>
        /// <param name="a_defaultPaymentDay">Default payment day used to generate receipt</param>
        /// <param name="a_guarantor">Guarantor</param>
        public Rental(Property a_property,
                      DateTime a_startDate,
                      double[] a_rent,
                      Person a_tenant,
                      bool a_isEmpty,
                      double a_securityDeposit,
                      byte a_defaultPaymentDay,
                      Person a_guarantor = null)
        {
            Property = a_property;
            StartDate = a_startDate;
            Rent = a_rent;
            Tenant = a_tenant;
            IsEmpty = a_isEmpty;
            SecurityDeposit = a_securityDeposit;
            DefaultPaymentDay = a_defaultPaymentDay;
            Guarantor = a_guarantor;
        }


        // METHODS
        /// <summary>
        /// Adds charge regularization for the given year
        /// </summary>
        /// <param name="a_year">Year</param>
        /// <param name="a_taxAmount">a_chargeRegularization</param>
        public void AddChargeRegularization(int a_year, double a_chargeRegularization)
        {
            if (ChargeRegularizations == null)
            {
                ChargeRegularizations = new Dictionary<int, double>();
            }

            if (ChargeRegularizations.ContainsKey(a_year))
            {
                ChargeRegularizations[a_year] = a_chargeRegularization;
            }
            else
            {
                ChargeRegularizations.Add(a_year, a_chargeRegularization);
            }
        }

        /// <summary>
        /// Adds signed contract file path
        /// </summary>
        /// <param name="a_signedContractFilePath">Signed contract file path</param>
        public void AddDocument(string a_signedContractFilePath)
        {
            SignedContractFilePath = a_signedContractFilePath;
        }

        /// <summary>
        /// Ends the rental
        /// </summary>
        /// <param name="a_endDate">Rental end date</param>
        public void EndRental(DateTime a_endDate)
        {
            EndDate = a_endDate;
        }

    }
}