using System;

namespace MySqlDemo.Entity
{
	 	//Territories
		public class Territories
	{
	
      	/// <summary>
		/// TerritoryId
        /// </summary>
        public virtual long TerritoryId
        {
            get; 
            set; 
        }        
		/// <summary>
		/// TerritoryDescription
        /// </summary>
        public virtual string TerritoryDescription
        {
            get; 
            set; 
        }        
		/// <summary>
		/// RegionId
        /// </summary>
        public virtual long RegionId
        {
            get; 
            set; 
        }        
		   
	}
}