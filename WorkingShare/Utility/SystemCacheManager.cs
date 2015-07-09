using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using WorkingShare.Database;

namespace WorkingShare.Utility
{
    public class SystemCacheManager
    {
        public static List<mMenu> MenuList
        {
            get
            {
                if (GetCache() == null)
                {
                    using (var ent = new TicketEntities())
                    {
                        SetCache(CreateTreeMenu(ent.mMenu.ToList()));
                    }
                }
                return GetCache() as List<mMenu>;
            }
        }

        private static List<mMenu> CreateTreeMenu(List<mMenu> menu)
        {
            List<mMenu> result = new List<mMenu>();

            result = menu.Where(p => p.ParentMenuId == null).OrderBy(p => p.SortNo).ToList();

            foreach (var each in result)
            {
                CreateChild(each);
            }

            return result;
        }
        private static void CreateChild(mMenu menu)
        {
            if (menu.mMenu1.Count == 0)
                return;

            menu.ChildMenu = menu.mMenu1.OrderBy(p => p.SortNo).ToList();
            foreach (var each in menu.ChildMenu)
            {
                CreateChild(each);
            }

        }

        //public static List<MST_USER> UserList
        //{
        //    get
        //    {
        //        return new DBManageEntities().MST_USER.ToList();
        //        if (GetCache() == null)
        //        {
        //            using (var ent = new DBManageEntities())
        //            {
        //                SetCache(ent.MST_USER.ToList());
        //            }
        //        }
        //        return GetCache() as List<MST_USER>;
        //    }
        //}

        //public static MST_USER GetUser(string login_id)
        //{
        //    var user = UserList.SingleOrDefault(p => p.LOGIN_ID == login_id);

        //    if (user == null)
        //    {
        //        user = UserList.Single(p => p.LOGIN_ID == "empty");
        //    }
        //    return user;
        //}

        private static object GetCache([CallerMemberName]string key = "")
        {
            return HttpContext.Current.Cache[key];
        }

        private static void SetCache(object value, [CallerMemberName]string key = "")
        {
            HttpContext.Current.Cache[key] = value;
        }
    }
}