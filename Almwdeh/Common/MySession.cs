using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Almwdeh.Common
{
    public class MySession
    {

        private MySession()
        {
            UserID = 0;
            Email = "";
            Avatar = "";


        }

        // Gets the current session.
        public static MySession Current
        {
            get
            {
                MySession session =
                  (MySession)HttpContext.Current.Session["__MySession__"];
                if (session == null)
                {
                    session = new MySession();
                    HttpContext.Current.Session["__MySession__"] = session;
                }
                return session;
            }
        }

        // **** add your session properties here, e.g like this:
        public int UserID { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }

    }
}