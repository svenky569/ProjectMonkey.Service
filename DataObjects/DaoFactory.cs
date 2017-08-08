using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using V1.ProjectMonkey.DataObjects.Interface;

namespace V1.ProjectMonkey.DataObjects
{
    /// <summary>
    /// Factory of factories. This class is a factory class that creates
    /// data-base specific factories which in turn create data acces objects.
    /// </summary>
    /// <remarks>
    /// GoF Design Patterns: Factory.
    ///
    /// This is the abstract factory design pattern applied in a hierarchy
    /// in which there is a factory of factories.
    /// </remarks>
    public class DaoFactory
    {
        //=============================================================================
        // All rights reserved to [[Company]].
        // THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
        // OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
        // LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR
        // FITNESS FOR A PARTICULAR PURPOSE.
        //=============================================================================

        //*****************************************************************************
        //* Name		    	: DaoFactory
        //* Type		    	: Class
        //* Description		    :
        //* References		    :
        //* Author	    		:
        //* Created Date        : Feb 09th 2015
        //*****************************************************************************
        //*                             MODIFICATION LOG
        //*****************************************************************************
        //* Ver	Date	     Modified By			Description
        //*
        //*
        //*****************************************************************************
        // The static field initializers below are thread safe.
        // Furthermore, they are executed in the order in which they appear
        // in the class declaration. Note: if a static constructor
        // is present you want to initialize these in that constructor.
        //*                             Code Review LOG
        //*****************************************************************************
        //* Ver        Date                Code Review By            Observations
        //*****************************************************************************
        /// <summary>
        /// Gets a provider specific (i.e. database specific) factory
        ///
        /// GoF Design Pattern: Factory
        /// </summary>
        /// <param name="dataProvider">Database provider.</param>
        /// <returns>Data access object factory.</returns>
        ///
        #region DaoFactory
        public static IDaoFactory GetFactory(string dataProvider)
        {
            // Return the requested DaoFactory
            switch (dataProvider)
            {
                case "ADO.NET.SqlExpress":
                case "ADO.NET.SqlServer": return new SqlServer.SqlServerDaoFactory();


                case "ADO.NET.Access":
                case "ADO.NET.Oracle":
                case "LinqToSql.SqlExpress":
                case "LinqToSql.SqlServer":
                case "EntityFramework.SqlExpress":
                case "EntityFramework.SqlServer":
                    throw new NotSupportedException("Currently application is not supporting " + dataProvider);

                // Default: SqlExpress
                default: return new SqlServer.SqlServerDaoFactory();
            }
        }
        #endregion
    }
}
