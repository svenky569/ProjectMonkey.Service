#region ClassHeader
//=============================================================================					
// All rights reserved to [[Company]].					
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY					
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT					
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR					
// FITNESS FOR A PARTICULAR PURPOSE.					
//=============================================================================					

//*****************************************************************************					
//* Name		    	: ServiceBase		
//* Type		    	: Class		
//* Description		    : 		
//* References		    :                                                        			
//* Author	    		: Bharat	
//* Created Date       : Feb 19th 2015					
//*****************************************************************************					
//*                             MODIFICATION LOG					
//*****************************************************************************					
//* Ver	Date	     Modified By			Description
//* 					
//* 					
//***************************************************************************** 
//*                             Code Review LOG                    
//*****************************************************************************                    
//* Ver        Date                Code Review By            Observations
//* 1.0       23/20/2015           Krishna murthy                  


//*****************************************************************************  
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects = V1.ProjectMonkey.BusinessObjects;
namespace V1.ProjectMonkey.Service
{
    public abstract class ServiceBase
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
    }
}
