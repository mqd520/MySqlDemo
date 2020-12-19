using System;

namespace MySqlDemo.Entity
{
    //Categories
    public class Categories
    {

        /// <summary>
        /// CategoryId
        /// </summary>
        public virtual int CategoryId
        {
            get;
            set;
        }
        /// <summary>
        /// CategoryName
        /// </summary>
        public virtual string CategoryName
        {
            get;
            set;
        }
        /// <summary>
        /// Description
        /// </summary>
        public virtual string Description
        {
            get;
            set;
        }
    }
}