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
    /// FindUsers
    /// </summary>
    public partial class FindUsers
    {
        public FindUsers()
        {
            this.FindAccounts = new HashSet<FindAccounts>();
            this.FindApply = new HashSet<FindApply>();
            this.FindBackList = new HashSet<FindBackList>();
            this.FindCircle = new HashSet<FindCircle>();
            this.FindDevice = new HashSet<FindDevice>();
            this.FindDocument = new HashSet<FindDocument>();
            this.FindFlow = new HashSet<FindFlow>();
            this.FindFriendGroup = new HashSet<FindFriendGroup>();
            this.FindFriends = new HashSet<FindFriends>();
            this.FindGameRoom = new HashSet<FindGameRoom>();
            this.FindHonor = new HashSet<FindHonor>();
            this.FindMessage = new HashSet<FindMessage>();
            this.FindMoney = new HashSet<FindMoney>();
            this.FindPower = new HashSet<FindPower>();
            this.FindPublicMessage = new HashSet<FindPublicMessage>();
            this.FindRecharge = new HashSet<FindRecharge>();
            this.FindTrendComments = new HashSet<FindTrendComments>();
            this.FindTrends = new HashSet<FindTrends>();
            this.FindVerify = new HashSet<FindVerify>();
            this.FindWithDrawCash = new HashSet<FindWithDrawCash>();
        }
    
        /// <summary>
        /// 
        /// </summary>
        public int FuId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FuName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FuRealName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FuNickName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FuSex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FuPassword { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<decimal> FuAge { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FuAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FuProvience { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FuCity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FuCounty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FuEmail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FuTeleph { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FuNationality { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FuNation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FuConstellation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FuBloodType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<decimal> FuStature { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<decimal> FuWeight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FuHomepace { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<System.DateTime> FuDateBirth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FuVocation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<decimal> FuQq { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FuGraduateSchool { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FuCurrentCompany { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FuSpecialSkill { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FuAccomplish { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<decimal> FuEmpiricValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<decimal> FuVipLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FuHeadSculpture1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FuHeadSculpture2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<System.DateTime> FuRegisterDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FuOperator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<System.DateTime> FuOperateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<bool> FuStatus { get; set; }
    
        public virtual ICollection<FindAccounts> FindAccounts { get; set; }
        public virtual ICollection<FindApply> FindApply { get; set; }
        public virtual ICollection<FindBackList> FindBackList { get; set; }
        public virtual ICollection<FindCircle> FindCircle { get; set; }
        public virtual ICollection<FindDevice> FindDevice { get; set; }
        public virtual ICollection<FindDocument> FindDocument { get; set; }
        public virtual ICollection<FindFlow> FindFlow { get; set; }
        public virtual ICollection<FindFriendGroup> FindFriendGroup { get; set; }
        public virtual ICollection<FindFriends> FindFriends { get; set; }
        public virtual ICollection<FindGameRoom> FindGameRoom { get; set; }
        public virtual ICollection<FindHonor> FindHonor { get; set; }
        public virtual ICollection<FindMessage> FindMessage { get; set; }
        public virtual ICollection<FindMoney> FindMoney { get; set; }
        public virtual ICollection<FindPower> FindPower { get; set; }
        public virtual ICollection<FindPublicMessage> FindPublicMessage { get; set; }
        public virtual ICollection<FindRecharge> FindRecharge { get; set; }
        public virtual ICollection<FindTrendComments> FindTrendComments { get; set; }
        public virtual ICollection<FindTrends> FindTrends { get; set; }
        public virtual ICollection<FindVerify> FindVerify { get; set; }
        public virtual ICollection<FindWithDrawCash> FindWithDrawCash { get; set; }
    }
}
