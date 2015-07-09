using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkingShare.Database
{
    public partial class mMenu
    {
        /// <summary>
        /// 子要素が入るかどうか
        /// </summary>
        public bool HasChild
        {
            get
            {
                return ChildMenu != null && ChildMenu.Count > 0;
            }
        }


        public bool IsActive
        {
            get
            {
                return false;
            }
        }

        public List<mMenu> ChildMenu
        {
            get;
            set;
        }
    }
}