﻿
#region ClassHeader
//=============================================================================
// All rights reserved to [[Company]].
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR
// FITNESS FOR A PARTICULAR PURPOSE.
//=============================================================================

//*****************************************************************************
//* Name		    	: BaseMDM
//* Type		    	: Class
//* Description		    :
//* References		    :
//* Author	    		: Pavan Kalyan Ram Alamuru
//* Created Date        : Feb 27th 2015
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
#endregion


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectMonkey.Framework.BusinessObjects;

namespace V1.ProjectMonkey.BusinessObjects
{/// <summary>
    /// Abstract base class for business objects for mdm schema, which will have mdm properties.
    /// Contains basic business rule infrastructure.
    /// </summary>
    public abstract class BaseMDM : BusinessObject
    {
        public int? LocalVersionNo { get; set; }
        public int? GlobalVersionNo { get; set; }
        public Boolean? SyncToMDMStatus { get; set; }
        public DateTime? LastUpdatedFromMDM { get; set; }
        public DateTime? LastUpdatedToMDM { get; set; }
    }
}
