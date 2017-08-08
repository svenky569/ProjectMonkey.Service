#region "Class Header"
//=============================================================================
// All rights reserved to [[Company]].
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR
// FITNESS FOR A PARTICULAR PURPOSE.
//=============================================================================

//*****************************************************************************
//* Name		    	: Objects
//* Type		    	: Class
//* Description		    :
//* References		    :
//* Author	    		: Sri Venkatesh.T
//* Created Date        : Jun 19th 2015
//*****************************************************************************
//*                             MODIFICATION LOG
//*****************************************************************************
//* Ver 	Date	            Modified By			Description
//*
//*****************************************************************************

//*                             Code Review LOG
//*****************************************************************************
//* Ver        Date                Code Review By            Observations
//*****************************************************************************
#endregion "Class Header"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectMonkey.Framework.BusinessObjects;
namespace V1.ProjectMonkey.BusinessObjects
{
    [Serializable]
    public sealed class Objects
    {
        #region Constuctor
        /// <summary>
        /// Default constructor
        /// </summary>
        public Objects()
            : base()
        {
            ID = null;
        }
        #endregion constuctor

        #region Properties

        public int? ID { get; set; }
        #endregion Properties
    }
}
