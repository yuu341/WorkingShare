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
    
    public partial class mUserType
    {
        public int UserTypeId { get; set; }
        public string UserTypeName { get; set; }
        public bool CanSelect { get; set; }
    
        public virtual tProjectMember tProjectMember { get; set; }
    }
}