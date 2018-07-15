using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookiesNApplication
{
    public partial class Default : System.Web.UI.Page
    {
        public static int mCount = 0;
        public static int mTotalCount = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            subscriptionComlete.Visible = false;
            //читаем куки
            HttpCookie cookie = Request.Cookies["Preferences"];
            string subscription;
            if (cookie != null)
            {
                subscription = cookie["subscription"];
                if (subscription != null && subscription == "true")
                {
                    subscriptionForm.Visible = false;
                }
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            mTotalCount++;
            if (this.Request.Params["lastname"] == "")
            {
                mCount++;
                //...
                subscriptionForm.Visible = false;
                subscriptionComlete.Visible = true;
                // Создать объект cookie-набора.
                HttpCookie cookie = new HttpCookie("Preferences");
                // Установить значение в нем.
                cookie["subscription"] = "true";
                // Добавить в него еще одно значение.
                //cookie["Country"] = "US";
                //Хранить 1 год
                cookie.Expires = DateTime.Now.AddYears(1);
                // Добавить cookie-набор к текущему веб-ответу.
                Response.Cookies.Add(cookie);
            }
            else {

            }
        }
    }
}