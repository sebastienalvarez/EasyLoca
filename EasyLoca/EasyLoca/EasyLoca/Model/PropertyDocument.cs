/****************************************************************************************************************************************
 * 
 * Class PropertyDocument
 * Author : S. ALVAREZ
 * Date : 07-09-2021
 * Status : In Progress
 * Version : 1
 * Revisions : 1 - 07-09-2021 : first version
 *  
 * Object : class that represent a property document such as an energetic bilan, an insurance or a funding appeal.
 * 
 ****************************************************************************************************************************************/

using System;

namespace EasyLoca.Model
{
    public class PropertyDocument
    {
        // PROPERTIES
        /// <summary>
        /// Property document start date
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Property document end date
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Property document file path
        /// </summary>
        public string DocumentFilePath { get; set; }

        /// <summary>
        /// Property document price
        /// </summary>
        public double Price { get; set; }

        // CONSTRUCTORS
        /// <summary>
        /// Default constructor
        /// </summary>
        public PropertyDocument()
        {
        }

        /// <summary>
        /// Creates an instance
        /// </summary>
        /// <param name="a_startDate">Property document start date</param>
        /// <param name="a_endDate">Property document date</param>
        /// <param name="a_documentFilePath">Property document file path</param>
        /// <param name="a_price">Property document price</param>
        public PropertyDocument(DateTime a_startDate,
                                DateTime a_endDate,
                                string a_documentFilePath = null,
                                double a_price = 0.0)
        {
            StartDate = a_startDate;
            if(a_endDate > a_startDate)
            {
                EndDate = a_endDate;
            }
            else
            {
                EndDate = a_startDate.AddMonths(3);
            }
            DocumentFilePath = a_documentFilePath;
            Price = a_price;
        }

        // METHODS
        /// <summary>
        /// Adds document file path
        /// </summary>
        /// <param name="a_documentFilePath">Document file path</param>
        public void AddDocument(string a_documentFilePath)
        {
            DocumentFilePath = a_documentFilePath;
        }

        /// <summary>
        /// Ends the document validity
        /// </summary>
        /// <param name="a_endDate">Property document end date</param>
        public void EndDocumentValidity(DateTime a_endDate)
        {
            EndDate = a_endDate;
        }

    }
}