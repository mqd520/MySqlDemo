using System;

namespace MySqlDemo.Entity
{
	 	//OrderLines
		public class OrderLines
	{
	
      	/// <summary>
		/// OrderLineId
        /// </summary>
        public virtual long OrderLineId
        {
            get; 
            set; 
        }        
		/// <summary>
		/// OrderId
        /// </summary>
        public virtual int OrderId
        {
            get; 
            set; 
        }        
		/// <summary>
		/// ProductId
        /// </summary>
        public virtual int ProductId
        {
            get; 
            set; 
        }        
		/// <summary>
		/// UnitPrice
        /// </summary>
        public virtual decimal UnitPrice
        {
            get; 
            set; 
        }        
		/// <summary>
		/// Quantity
        /// </summary>
        public virtual int Quantity
        {
            get; 
            set; 
        }        
		/// <summary>
		/// Discount
        /// </summary>
        public virtual decimal Discount
        {
            get; 
            set; 
        }        
		   
	}
}