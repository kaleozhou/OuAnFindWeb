//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MODEL
{
    using System;
    using System.Collections.Generic;
    
    /// <summary>
    /// FindDocument
    /// </summary>
    public partial class FindDocument
    {
        /// <summary>
        /// 
        /// </summary>
        public int FdoId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<int> FuId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FdoName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FdoType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FdoUseFor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FdoUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FdoOperator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<System.DateTime> FdoOperateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<bool> FdoStatus { get; set; }
    
        public virtual FindUsers FindUsers { get; set; }
    }
}
