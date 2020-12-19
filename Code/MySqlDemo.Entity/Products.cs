using System;

namespace MySqlDemo.Entity
{
	 	//Products
		public class Products
	{
	
      	/// <summary>
		/// ProductId
        /// </summary>
        public virtual int ProductId
        {
            get; 
            set; 
        }        
		/// <summary>
		/// ProductName
        /// </summary>
        public virtual string ProductName
        {
            get; 
            set; 
        }        
		/// <summary>
		/// SupplierId
        /// </summary>
        public virtual int? SupplierId
        {
            get; 
            set; 
        }        
		/// <summary>
		/// CategoryId
        /// </summary>
        public virtual int? CategoryId
        {
            get; 
            set; 
        }        
		/// <summary>
		/// QuantityPerUnit
        /// </summary>
        public virtual string QuantityPerUnit
        {
            get; 
            set; 
        }        
		/// <summary>
		/// UnitPrice
        /// </summary>
        public virtual decimal? UnitPrice
        {
            get; 
            set; 
        }        
		/// <summary>
		/// UnitsInStock
        /// </summary>
        public virtual int? UnitsInStock
        {
            get; 
            set; 
        }        
		/// <summary>
		/// UnitsOnOrder
        /// </summary>
        public virtual int? UnitsOnOrder
        {
            get; 
            set; 
        }        
		/// <summary>
		/// ReorderLevel
        /// </summary>
        public virtual int? ReorderLevel
        {
            get; 
            set; 
        }        
		/// <summary>
		/// Discontinued
        /// </summary>
        public virtual bool Discontinued
        {
            get; 
            set; 
        }        
		/// <summary>
		/// ShippingWeight
        /// </summary>
        public virtual decimal? ShippingWeight
        {
            get; 
            set; 
        }        
		   
	}
}