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



        //string b = a;


        int rand = 0;
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
        protected void Application_Start(object sender, EventArgs e)
        {
            // Session["string1"] = rand.ToString();


           
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            

            //Label1.Text = "aa";// Application["randomnumber1"].ToString();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
            }
            else
            {
                rand = new Random().Next(1, 5);
                Application["randomnumber1"] = rand;
                Application["whoseturnisit"] = 1;
                Label1.Text = rand.ToString();
                //initial set
                Application["Application_list1"] = list1;
                Application["Application_list2"] = list2;
                Application["Application_list3"] = list3;
                Application["Application_list4"] = list4;
                Application["Application_list5"] = list5;




            }


            // string temp = Session["string1"];

            // Label1.Text = Session["string1"];


        }
        

        protected void Button1_Click(object sender, EventArgs e)
        {

            if(Session["MyUserNumber"] != Application["whoseturnisit"])
            {
                return;
            }
            //get code and proceed
            else
            {




            }
            //list1 = (List<OneChatRoom>)Application["Application_list1"];

            //OneChatRoom msg = new OneChatRoom("y", "y", "y");
            //list1.Add(msg);
            //OneChatRoom msg1 = new OneChatRoom("z", "z", "z");
            //list1.Add(msg1);

            //Application["Holder"] = list1;
           
            //list1 = (List<OneChatRoom>)Application["Holder"];



            Button6.Enabled = false;
            var  holder1 = Application["randomnumber1"];
            //you won got right pick
            if (holder1 == "1")
            {
                list2.Add(a);
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('You Win!'); ", true);

            }
            //wrong pick - send message with disable code
            else
            {




                //assumption : person in same room and is in room object
               


                
                //this, below, a function

                OneChatRoom message = new OneChatRoom("1", "0", "0");
                //list1.Add(msg1);

                var roomnumber = 1;
                //variable at previous screen

                //sends message
                switch (roomnumber)
                {
                    case 1:
                        list1.Add(message);
                        Application["Application_list1"] = list1;
                        break;

                    case 2:
                        list2.Add(message);
                        Application["Application_list2"] = list2;
                        break;
                    case 3:
                        list3.Add(message);
                        Application["Application_list3"] = list3;
                        break;
                    case 4:
                        list4.Add(message);
                        Application["Application_list4"] = list4;
                        break;
                    case 5:
                        list5.Add(message);
                        Application["Application_list5"] = list5;
                        break;
                    //case 6:
                    //    list2.Add(msg);
                    //    break;
                    //case 7:
                    //    list2.Add(msg);
                    //    break;
                    //case 8:
                    //    list2.Add(msg);
                    //    break;
                    //case 9:
                    //    list2.Add(msg);
                    //    break;
                    //case 10:
                    //    list2.Add(msg);
                    //    break;

                    default:

                        break;
                }
                var temp = Application["whoseturnisit"];
                if ((string)temp == "1")
                {
                    Application["whoseturnisit"] = 0;
                }
                else
                {
                    Application["whoseturnisit"] = 1;
                }


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
            var holder1 = Application["randomnumber1"];
            if (holder1 == "5")
            {

                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('You Win!'); ", true);

            }

        }
    }
}