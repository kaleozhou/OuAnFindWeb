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
    /// FindPublicMessage
    /// </summary>
    public partial class FindPublicMessage
    {
        /// <summary>
        /// 
        /// </summary>
        public int FpmId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<int> FuId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FpmType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FpmBinding { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FpmTitle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FpmConent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<System.DateTime> FpmPublishDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FpmOperator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<System.DateTime> FpmOperateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<bool> FpmStatus { get; set; }
    
        public virtual FindUsers FindUsers { get; set; }
    }
}
