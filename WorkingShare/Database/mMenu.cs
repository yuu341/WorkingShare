//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはテンプレートから生成されました。
//
//     このファイルを手動で変更すると、アプリケーションで予期しない動作が発生する可能性があります。
//     このファイルに対する手動の変更は、コードが再生成されると上書きされます。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorkingShare.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class mMenu
    {
        public mMenu()
        {
            this.mMenu1 = new HashSet<mMenu>();
        }
    
        public int MenuId { get; set; }
        public Nullable<int> ParentMenuId { get; set; }
        public string MenuName { get; set; }
        public string Area { get; set; }
        public bool isVisible { get; set; }
    
        public virtual ICollection<mMenu> mMenu1 { get; set; }
        public virtual mMenu mMenu2 { get; set; }
    }
}
