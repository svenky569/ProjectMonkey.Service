#region ClassHeader
//=============================================================================
// All rights reserved to [[Company]].
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR
// FITNESS FOR A PARTICULAR PURPOSE.
//=============================================================================

//*****************************************************************************
//* Name		    	: IDaoFactory
//* Type		    	: Interface
//* Description		    :
//* References		    :
//* Author	    		: Krishna Murthy
//* Created Date       : Feb 09th 2015
//*****************************************************************************
//*                             MODIFICATION LOG
//*****************************************************************************
//* Ver	Date	     Modified By			Description
//* 	22/4/2015	 Spandana	            Added IPermissionDao,IAppModuleDao
//* 	23/04/2015   Spandana				Added IAppFunctionDao,IAppFunctionPermissionDao
//*     29/04/2015   Spandana               Added IRolePermission
//*****************************************************************************
//*                             Code Review LOG
//*****************************************************************************
//* Ver        Date                Code Review By            Observations
//* 1.0        02/20/2015           Self
//* 1.0        02/24/2015           Pavan      Interface name should be in singular
//*****************************************************************************
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1.ProjectMonkey.DataObjects.Interface
{

    // abstract factory interface. Creates data access objects.
    // ** GoF Design Pattern: Factory.

    public interface IDaoFactory
    {
        IAgeGroupDao AgeGroupDao { get; }
    }
}
