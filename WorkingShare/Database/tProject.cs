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
    
    public partial class tProject
    {
        public tProject()
        {
            this.tTicket = new HashSet<tTicket>();
        }
    
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int ProjectStateCode { get; set; }
        public bool isDelete { get; set; }
        public Nullable<System.DateTime> DeleteTime { get; set; }
    
        public virtual ICollection<tTicket> tTicket { get; set; }
    }
}
