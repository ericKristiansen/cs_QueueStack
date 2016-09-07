
using System.Web.UI.WebControls;
using System.Drawing;

namespace WebControlFunc
{
    /// <summary>
    /// This is a simple Utility class to be used for
    /// general WebControl property manipulation. Currently,
    /// it is used to toggle the enabled property, and set the
    /// disabled forecolor to a color we currently use at work
    /// for disabled WebControls.
    /// </summary>
    public static class WCFunc
    {
        const int INACTIVE_COLOR = 0x555555;

        /// <summary>
        /// Set the variable web control to enabled or disabled,
        /// and set the forecolor appropriately.
        /// </summary>
        /// <param name="wc"></param>
        /// <param name="isEnabled">This variable is by default true.</param>
        public static void SetEnabled(WebControl wc, bool isEnabled = true)
        {
            wc.Enabled = isEnabled;
            if (!isEnabled)
            { wc.ForeColor = Color.FromArgb(INACTIVE_COLOR); }
            else { wc.ForeColor = Color.Black; }
        }
    }


    /// <summary>
    /// This is a simple static class to host methods
    /// employing the Page object. It is currently used
    /// specifically for the Page.Request object.
    /// </summary>
    public static class RequestFunc
    {
        const string PAGE_NUMBER = "page_number";
        const string EQUALS = "=";
        const string AMP = "&";
        const string QUESTION_MARK = "?";

        /// <summary>
        /// This Function will return the query strings of a given
        /// page as a string.
        /// </summary>
        /// <param name="myPage"></param>
        /// <returns></returns>
        public static string GetQueryStrings(System.Web.UI.Page myPage)
        {
            string result = null;
            //Add each Query string from collection to src path string
            if (myPage.Request.QueryString.AllKeys.Length > 0)
            {
                int i = 1;
                result = QUESTION_MARK;
                foreach (string key in myPage.Request.QueryString.AllKeys)
                {
                    result += key + EQUALS + myPage.Request.QueryString[key];
                    if (i < myPage.Request.QueryString.AllKeys.Length)
                    { result += AMP; }
                    i++;
                }
            }
            return result;
        }

    }

}
