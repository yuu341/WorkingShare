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
    
    public partial class tTicket
    {
        public int TicketId { get; set; }
        public int ProjectId { get; set; }
        public int SendUserId { get; set; }
        public string SendUserName { get; set; }
        public System.DateTime SendTime { get; set; }
        public string Title { get; set; }
        public int TicketType { get; set; }
        public int AskUserId { get; set; }
        public string AskUserName { get; set; }
        public Nullable<System.DateTime> AskTime { get; set; }
        public bool IsComplete { get; set; }
        public Nullable<System.DateTime> CompleteTime { get; set; }
        public int Point { get; set; }
        public bool IsDelete { get; set; }
        public Nullable<System.DateTime> DeleteTime { get; set; }
        public Nullable<System.DateTime> DeadLine { get; set; }
    
        public virtual tProject tProject { get; set; }
    }
}
