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
    /// FindAlimama
    /// </summary>
    public partial class FindAlimama
    {
        public FindAlimama()
        {
            this.FindAdversitement = new HashSet<FindAdversitement>();
        }
    
        /// <summary>
        /// 
        /// </summary>
        public int FalId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FalName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<decimal> FalLength { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<decimal> FalWidth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FalAdStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FalOperator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<System.DateTime> FalOperateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<bool> FalStatus { get; set; }
    
        public virtual ICollection<FindAdversitement> FindAdversitement { get; set; }
    }
}
