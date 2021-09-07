/****************************************************************************************************************************************
 * 
 * Class Property
 * Author : S. ALVAREZ
 * Date : 07-09-2021
 * Status : In Progress
 * Version : 1
 * Revisions : 1 - 07-09-2021 : first version
 *  
 * Object : class that represent a property.
 * 
 ****************************************************************************************************************************************/

using System.Collections.Generic;

namespace EasyLoca.Model
{
    public class Property
    {
        // PROPERTIES
        /// <summary>
        /// Property name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Postal address
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// File path of representative photography
        /// </summary>
        public string PhotoFilePath { get; set; }

        /// <summary>
        /// Property price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Tax data per year
        /// </summary>
        public Dictionary<int, double> Taxes { get; set; }

        /// <summary>
        /// Insurance data
        /// </summary>
        public List<PropertyDocument> Insurances { get; set; }

        /// <summary>
        /// Energetic bilan data
        /// </summary>
        public List<PropertyDocument> EnergeticBilans { get; set; }

        /// <summary>
        /// Funding appeal data
        /// </summary>
        public List<PropertyDocument> FundingAppeals { get; set; }

        // CONSTRUCTORS
        /// <summary>
        /// Default constructor
        /// </summary>
        public Property()
        {
        }

        /// <summary>
        /// Creates an instance
        /// </summary>
        /// <param name="a_name">Property name</param>
        /// <param name="a_address">Postal address</param>
        /// <param name="a_price">Property price</param>
        /// <param name="a_photoFilePath">File path of representative photography</param>
        public Property(string a_name,
                        Address a_address,
                        double a_price,
                        string a_photoFilePath = null)
        {
            Name = a_name;
            Address = a_address;
            Price = a_price;
            PhotoFilePath = a_photoFilePath;
            Taxes = new Dictionary<int, double>();
            Insurances = new List<PropertyDocument>();
            EnergeticBilans = new List<PropertyDocument>();
            FundingAppeals = new List<PropertyDocument>();
        }

        // METHODS
        /// <summary>
        /// Adds tax amount for the given year
        /// </summary>
        /// <param name="a_year">Year</param>
        /// <param name="a_taxAmount">Tax amount</param>
        public void AddTaxData(int a_year, double a_taxAmount)
        {
            if(Taxes == null)
            {
                Taxes = new Dictionary<int, double>();
            }

            if (Taxes.ContainsKey(a_year))
            {
                Taxes[a_year] = a_taxAmount;
            }
            else
            {
                Taxes.Add(a_year, a_taxAmount);
            }
        }

        /// <summary>
        /// Adds a property document (insurance, energetic bilan or funding appeal)
        /// </summary>
        /// <param name="a_collection">Collection of PopertyDocument objects</param>
        /// <param name="a_documentData">PropertyDocument object</param>
        /// <returns>Flag that indicates of document adding is successfull or not</returns>
        public bool AddPropertyDocument(List<PropertyDocument> a_collection, PropertyDocument a_documentData)
        {
            bool isPropertyDocumentAdded = true;

            if (a_collection == null)
            {
                a_collection = new List<PropertyDocument>();
            }

            PropertyDocument lastPropertyDocument = a_collection.Count > 0 ? a_collection[a_collection.Count - 1] : null;
            if (lastPropertyDocument != null)
            {
                if (a_documentData.StartDate > lastPropertyDocument.StartDate)
                {
                    if (lastPropertyDocument.EndDate >= a_documentData.StartDate)
                    {
                        lastPropertyDocument.EndDocumentValidity(a_documentData.StartDate.AddDays(-1.0));
                    }
                    a_collection.Add(a_documentData);
                }
                else
                {
                    isPropertyDocumentAdded = false;
                }
            }
            else
            {
                a_collection.Add(a_documentData);
            }

            return isPropertyDocumentAdded;
        }

    }
}