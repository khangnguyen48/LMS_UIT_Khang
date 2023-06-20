//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryManagementSystem.Models.DataProvider
{
    using System;
    using System.Collections.Generic;
    
    public partial class ORDER_BOOKS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ORDER_BOOKS()
        {
            this.ORDER_DETAIL = new HashSet<ORDER_DETAIL>();
        }
    
        public int orderID { get; set; }
        public string orderName { get; set; }
        public string orderPhone { get; set; }
        public string orderEmail { get; set; }
        public string orderAddress { get; set; }
        public Nullable<decimal> totalValue { get; set; }
        public System.DateTime orderDate { get; set; }
        public Nullable<int> orderCusId { get; set; }
        public Nullable<int> orderStatus { get; set; }
    
        public virtual ACCOUNT ACCOUNT { get; set; }
        public virtual STATUS_ORDER STATUS_ORDER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDER_DETAIL> ORDER_DETAIL { get; set; }
    }
}
