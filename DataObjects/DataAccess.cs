using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using V1.ProjectMonkey.DataObjects.Interface;

namespace V1.ProjectMonkey.DataObjects
{
    /// <summary>
    /// This class shields the client from the details of database specific
    /// data-access objects. It returns the appropriate data-access objects
    /// according to the configuration in web.config.
    /// </summary>
    /// <remarks>
    /// GoF Design Patterns: Factory, Singleton, Proxy.
    ///
    /// This class makes extensive use of the Factory pattern in determining which
    /// database specific DAOs (Data Access Objects) to return.
    ///
    /// This class is like a Singleton -- it is a static class (Shared in VB) and
    /// therefore only one 'instance' will ever exist.
    ///
    /// This class is a Proxy as it 'stands in' for the actual Data Access Object Factory.
    /// </remarks>
    ///
    public static class DataAccess
    {
        //=============================================================================
        // All rights reserved to [[Company]].
        // THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
        // OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
        // LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR
        // FITNESS FOR A PARTICULAR PURPOSE.
        //=============================================================================

        //*****************************************************************************
        //* Name		    	: DataAccess
        //* Type		    	: Class
        //* Description		    :
        //* References		    :
        //* Author	    		: krishna Murthy
        //* Created Date       : Feb 09th 2015
        //*****************************************************************************
        //*                             MODIFICATION LOG
        //*****************************************************************************
        //* Ver	Date	     Modified By			Description
        //*****************************************************************************
        // The static field initializers below are thread safe.
        // Furthermore, they are executed in the order in which they appear
        // in the class declaration. Note: if a static constructor
        // is present you want to initialize these in that constructor.
        //*                             Code Review LOG
        //*****************************************************************************
        //* Ver        Date                Code Review By            Observations
        //*****************************************************************************

        private static readonly string dataProviderName = ConfigurationManager.AppSettings.Get("DataProvider");

        private static readonly IDaoFactory factory = DaoFactory.GetFactory(dataProviderName);


        #region "DataAcess get property"

        /// <summary>
        /// Gets a provider-specific Agegroup data access object.
        /// </summary>
        public static IAgeGroupDao AgeGroupDao
        {
            get { return factory.AgeGroupDao; }
        }
        #endregion "DataAccess get property"
    }
}
