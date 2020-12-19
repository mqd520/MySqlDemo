using System;

namespace MySqlDemo.Entity
{
	 	//EmployeeTerritories
		public class EmployeeTerritories
	{
	
      	/// <summary>
		/// EmployeeId
        /// </summary>
        public virtual int EmployeeId
        {
            get; 
            set; 
        }        
		/// <summary>
		/// TerritoryId
        /// </summary>
        public virtual long TerritoryId
        {
            get; 
            set; 
        }        
		   
	}
}