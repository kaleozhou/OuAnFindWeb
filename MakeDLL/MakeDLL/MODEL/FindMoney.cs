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
    /// FindMoney
    /// </summary>
    public partial class FindMoney
    {
        /// <summary>
        /// 
        /// </summary>
        public int FmoId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<int> FuId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FmoName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FmoType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<decimal> FmoAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<decimal> FmoRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FmoDescribe { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FmoUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FmoOperator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<System.DateTime> FmoOperateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<bool> FmoStatus { get; set; }
    
        public virtual FindUsers FindUsers { get; set; }
    }
}
