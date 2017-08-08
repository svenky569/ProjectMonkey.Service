#region ClassHeader
//=============================================================================
// All rights reserved to [[Company]].
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR
// FITNESS FOR A PARTICULAR PURPOSE.
//=============================================================================

//*****************************************************************************
//* Name		    	: BaseDao
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
//*****************************************************************************
//*                             Code Review LOG
//*****************************************************************************
//* Ver        Date                Code Review By            Observations
//*
//*
//*****************************************************************************
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V1.ProjectMonkey.DataObjects.SqlServer
{
    public class BaseDao
    {
        #region Properties
        /// <summary> Connection String </summary>
        ///

        public string ConnectionString { get; set; }

        #endregion
    }
}
