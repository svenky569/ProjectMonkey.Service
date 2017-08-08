#region ClassHeader
//=============================================================================					
// All rights reserved to Nunet Cube Software Solutions.					
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY					
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT					
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR					
// FITNESS FOR A PARTICULAR PURPOSE.					
//=============================================================================					

//*****************************************************************************					
//* Name		    	: ICHCDao		
//* Type		    	: Interface		
//* Description		    : Interface for Cluster details		
//* References		    :                                                        			
//* Author	    		: SivaKumar Jallu
//* Created Date        : April 06th 2015					
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
//*****************************************************************************  
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nunet.RBSK.BusinessObjects;

namespace Nunet.RBSK.DataObjects.Interface
{
    public interface ICHCDao
    {
        /// <summary>
        /// Connection String
        /// </summary>
        string ConnectionString { get; set; }
    }
}
