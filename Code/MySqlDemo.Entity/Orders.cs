using System;

namespace MySqlDemo.Entity
{
	 	//Orders
		public class Orders
	{
	
      	/// <summary>
		/// OrderId
        /// </summary>
        public virtual int OrderId
        {
            get; 
            set; 
        }        
		/// <summary>
		/// CustomerId
        /// </summary>
        public virtual string CustomerId
        {
            get; 
            set; 
        }        
		/// <summary>
		/// EmployeeId
        /// </summary>
        public virtual int? EmployeeId
        {
            get; 
            set; 
        }        
		/// <summary>
		/// OrderDate
        /// </summary>
        public virtual DateTime? OrderDate
        {
            get; 
            set; 
        }        
		/// <summary>
		/// RequiredDate
        /// </summary>
        public virtual DateTime? RequiredDate
        {
            get; 
            set; 
        }        
		/// <summary>
		/// ShippedDate
        /// </summary>
        public virtual DateTime? ShippedDate
        {
            get; 
            set; 
        }        
		/// <summary>
		/// ShipVia
        /// </summary>
        public virtual int? ShipVia
        {
            get; 
            set; 
        }        
		/// <summary>
		/// Freight
        /// </summary>
        public virtual decimal? Freight
        {
            get; 
            set; 
        }        
		/// <summary>
		/// ShipName
        /// </summary>
        public virtual string ShipName
        {
            get; 
            set; 
        }        
		/// <summary>
		/// ShipAddress
        /// </summary>
        public virtual string ShipAddress
        {
            get; 
            set; 
        }        
		/// <summary>
		/// ShipCity
        /// </summary>
        public virtual string ShipCity
        {
            get; 
            set; 
        }        
		/// <summary>
		/// ShipRegion
        /// </summary>
        public virtual string ShipRegion
        {
            get; 
            set; 
        }        
		/// <summary>
		/// ShipPostalCode
        /// </summary>
        public virtual string ShipPostalCode
        {
            get; 
            set; 
        }        
		/// <summary>
		/// ShipCountry
        /// </summary>
        public virtual string ShipCountry
        {
            get; 
            set; 
        }        
		   
	}
}