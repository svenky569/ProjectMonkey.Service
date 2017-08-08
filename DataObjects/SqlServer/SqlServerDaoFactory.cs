#region ClassHeader
//=============================================================================
// All rights reserved to [[Company]].
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR
// FITNESS FOR A PARTICULAR PURPOSE.
//=============================================================================

//*****************************************************************************
//* Name		    	: SqlServerDaoFactory
//* Type		    	: Class
//* Description		    :
//* References		    :
//* Author	    		: 
//* Created Date        : Feb 09th 2015
//*****************************************************************************
//*                             MODIFICATION LOG
//*****************************************************************************
//* Ver	Date	     Modified By			Description
//*****************************************************************************
//*                             Code Review LOG
//*****************************************************************************
//* Ver        Date                Code Review By            Observations
//*****************************************************************************
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V1.ProjectMonkey.DataObjects;
using V1.ProjectMonkey.DataObjects.Interface;

namespace V1.ProjectMonkey.DataObjects.SqlServer
{

    /// <summary>
    /// Sql Server specific factory that creates Sql Server specific data access objects.
    /// </summary>
    /// <remarks>
    /// GoF Design Pattern: Factory.
    /// </remarks>

    public class SqlServerDaoFactory : IDaoFactory
    {

        #region "Dao Factory"

        /// <summary>
        /// Gets a Sql server specific Agegroup data access object.
        /// </summary>
        public IAgeGroupDao AgeGroupDao
        {
            get { return new AgeGroupDao(); }

        }
        #endregion "Dao Factory"



        
    }
}
