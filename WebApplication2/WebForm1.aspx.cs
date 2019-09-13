using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public class OneChatRoom
{






    public OneChatRoom(string a, string Personis, string Chatroomname)
    {


        this.Strin = a;

        this.Personis = Personis;
        this.Chatroomname = Chatroomname;

    }
    public string Strin { get; set; }
    public string Personis { get; set; }
    public string Chatroomname { get; set; }

}



namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        List<OneChatRoom> list2 = new List<OneChatRoom>();
        OneChatRoom a = new OneChatRoom("y", "y", "y");
        OneChatRoom b = new OneChatRoom("b", "b", "b");
        OneChatRoom d = new OneChatRoom("z", "z", "z");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                list2.Add(a);
                Application["test2"] = list2;
            }
            else
            {

                list2 = (List<OneChatRoom>)Application["test2"];
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            
            list2.Add(d);

            Application["test2"] = list2;
            list2 = (List<OneChatRoom>)Application["test2"];


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string var = "test";
            
            list2.Add(b);

            Application["test2"] = list2;
            list2 = (List<OneChatRoom>)Application["test2"];
            //ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + list2[0].Personis + list2[1].Personis + list2[2].Personis + "');", true);
            Session[var] = "1";
            string temp = Session["test"].ToString();


        }
    }
}