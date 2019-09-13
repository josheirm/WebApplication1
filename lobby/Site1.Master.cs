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

namespace lobby
{
    public partial class Site1 : System.Web.UI.MasterPage
    {

       
        List<OneChatRoom> list1 = new List<OneChatRoom>();
        List<OneChatRoom> list2 = new List<OneChatRoom>();
        List<OneChatRoom> list3 = new List<OneChatRoom>();
        List<OneChatRoom> list4 = new List<OneChatRoom>();
        List<OneChatRoom> list5 = new List<OneChatRoom>();
        OneChatRoom a = new OneChatRoom("y", "y", "y");
        //OneChatRoom b = new OneChatRoom("b", "b", "b");
        //OneChatRoom d = new OneChatRoom("z", "z", "z");

        //if(Session["roomnumber"] == "1")
        //{
        //    List<OneChatRoom> list1 = new List<OneChatRoom>();

        //}
        //if (Session["roomnumber"] == "2")
        //{
        //    List<OneChatRoom> list2 = new List<OneChatRoom>();

        //}
        protected void Page_Load(object sender, EventArgs e)
        {
            Application["randomnumber1"]  = new Random().Next(1, 5);

            Application["whoseturnisit"] = 1;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button6.Enabled = false;
            var  holder1 = Application["randomnumber1"].ToString();
            if (holder1 == "1")
            {
                
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('You Win!'); ", true);

            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Button2.Enabled = false;
            var holder1 = Application["randomnumber1"].ToString();
            if (holder1 == "2")
            {

                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('You Win!'); ", true);

            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Button3.Enabled = false;
            var holder1 = Application["randomnumber1"].ToString();
            if (holder1 == "3")
            {

                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('You Win!'); ", true);

            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Button4.Enabled = false;
            var holder1 = Application["randomnumber1"].ToString();
            if (holder1 == "4")
            {

                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('You Win!'); ", true);

            }

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Button5.Enabled = false;
            var holder1 = Application["randomnumber1"].ToString();
            if (holder1 == "5")
            {

                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('You Win!'); ", true);

            }

        }
    }
}