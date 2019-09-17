


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Collections;
using System.Configuration;
using System.Data;

using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;

using System.Xml.Linq;
using System.Threading;

public class SessionTest
{
    public string GetSession(string SessionVariable)
    {

        //Session["A"] = "";
        return SessionVariable;

    }
}




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




        int counter = 0;

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
                //this will be if your the second user in room than on page call
                ThreadStart childthreat = new ThreadStart(childthreadcall);
                Response.Write("Child Thread Started <br/>");
                Thread child = new Thread(childthreat);

                child.Start();

                Response.Write("Main sleeping  for 2 seconds.......<br/>");
                Thread.Sleep(2000);
                Response.Write("<br/>Main aborting child thread<br/>");

                child.Abort();


                rand = new Random().Next(1, 5);
                Application["randomnumber1"] = rand.ToString();


                Session["MyUserNumber"] = "1";

                //player one goes first


                //initial set
                Application["Application_list1"] = list1;
                Application["Application_list2"] = list2;
                Application["Application_list3"] = list3;
                Application["Application_list4"] = list4;
                Application["Application_list5"] = list5;

                Application["user1done"] = "1";
                Application["user2done"] = "0";
                Application["whoseturnisit"] = "1";

            }


            // string temp = Session["string1"];

            // Label1.Text = Session["string1"];


        }
        //called with thread while waiting on send
        public void childthreadcall()
        {
            int flag = 1;
            while (flag == 1)
            {
                var temp = Session["roomnumber"];

               
                if (temp == "1")
                {
                    var code = Application["Application_list1"];

                    if (code != "")
                    {
                        
                        // call recieve code function here
                    }
                }

            }
        }




        //try
        //{
        //    //counter = counter + 1;
        //    //string temp = counter.ToString();
        //    //Label2.Text = temp;
        //    //Label2.Text = "";
        //    Thread.Sleep(2000);
        //    Label2.Text = "<br />Child thread started <br/>";
        //    Label2.Text += "Child Thread: Coiunting to 10";

        //    for (int i = 0; i < 10; i++)
        //    {
        //        Thread.Sleep(500);
        //        Label2.Text += "<br/> in Child thread </br>";
        //    }

        //    Label2.Text += "<br/> child thread finished";

        //}
        //catch (ThreadAbortException e)
        //{

        //    Label2.Text += "<br /> child thread - exception";

        //}
        //finally
        //{
        //   Label2.Text += "<br /> child thread - unable to catch the  exception";
        //}
        //}


        //player one goes first
        protected void Button1_Click(object sender, EventArgs e)
            {
                Button6.Enabled = false;

                //this is the main hack!
                //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

                //whosturnisit is : 1


                //this goes second - user one done

                //receive code - user 1 goes first this is player 2

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
            //player 2
            protected void Button8_Click(object sender, EventArgs e)
            {

                Session["MyUserNumber"] = "0";
            }
            //player 1
            protected void Button7_Click(object sender, EventArgs e)
            {
                Session["MyUserNumber"] = "1";

            }

            protected void Button9_Click(object sender, EventArgs e)
            {
                var holder = Application["randomnumber1"];
                Label1.Text = holder.ToString();

                string var = "0";

                //MyClass MyClass1 = new MyClass();

                //Application["Temp"] = "TestValue";
                //SessionTest sessionTest = new SessionTest();
                //sessionTest.GetSession(Application["Temp"].ToString());

            }
        }

        //namespace
    }




    public class ChangeUser
    {
        public void MyFunction()
        {
            //switch whose turn
            var temp = HttpContext.Current.Session["whoseturnisit"];
            if (temp == "1")
            {
                HttpContext.Current.Session["whoseturnisit"] = "0";
            }
            else
            {
                HttpContext.Current.Session["whoseturnisit"] = "1";
            }
        }

    }




    ///////////////9/15/19
    ///RECIEVE
    class MyClass
    {

        public void Receive(ref int buttontodisable, ref List<OneChatRoom> list1, ref List<OneChatRoom> list2, ref List<OneChatRoom> list3, ref List<OneChatRoom> list4, ref List<OneChatRoom> list5)
        {


            if (HttpContext.Current.Session["MyUserNumber"] != HttpContext.Current.Application["whoseturnisit"])
            {

                ////////////for testing
                string msg = "1";
                OneChatRoom message = new OneChatRoom(msg, "0", "0");
                list1.Add(message);
                HttpContext.Current.Application["Application_list1"] = list1;
                //list1.Add(message);
                list1 = (List<OneChatRoom>)HttpContext.Current.Application["Application_list1"];
                //////////end testing


                //TWO OF THESE!!!!! - determined by previous page - hack
                var roomnumber = 1;

                if (roomnumber == 1)
                {

                    //the code is the number of the button sent to disable
                    var code = (List<OneChatRoom>)HttpContext.Current.Application["Application_list1"];
                    list1.RemoveAt(0);
                    //Session["thecode"] = code ;

                    //to use after

                    //held in an HttpContext.Current.Application variable
                    HttpContext.Current.Application["Application_list1"] = list1;
                    ////Button6.Enabled = false;



                }
                else if (roomnumber == 2)
                {
                    var code = (List<OneChatRoom>)HttpContext.Current.Application["Application_list2"];
                    list2.RemoveAt(0);
                    //Session["thecode"] = code;
                    HttpContext.Current.Application["Application_list2"] = list2;
                    ////Button2.Enabled = false;
                }
                else if (roomnumber == 3)
                {
                    var code = (List<OneChatRoom>)HttpContext.Current.Application["Application_list3"];
                    list3.RemoveAt(0);
                    //Session["thecode"] = code;
                    HttpContext.Current.Application["Application_list3"] = list3;
                    ////Button3.Enabled = false;
                }
                else if (roomnumber == 4)
                {
                    var code = (List<OneChatRoom>)HttpContext.Current.Application["Application_list4"];
                    list4.RemoveAt(0);
                    //Session["thecode"] = code;
                    HttpContext.Current.Application["Application_list4"] = list4;
                    ////Button4.Enabled = false;
                }
                else if (roomnumber == 5)
                {
                    var code = (List<OneChatRoom>)HttpContext.Current.Application["Application_list5"];
                    list5.RemoveAt(0);
                    //Session["thecode"] = code;
                    HttpContext.Current.Application["Application_list5"] = list5;
                    ////Button5.Enabled = false;
                }






                // return;

            }
        }
    }


    ////////////////////
    ///

    //send code
    //player 1 goes first
    //this is player one's first run through

    //adter send message disable button from caller instead

    class MyClass2
    {
        public void SendMessage(int buttonpressed, ref List<OneChatRoom> list1, ref List<OneChatRoom> list2, ref List<OneChatRoom> list3, ref List<OneChatRoom> list4, ref List<OneChatRoom> list5)
        {

            if (HttpContext.Current.Session["MyUserNumber"] == HttpContext.Current.Application["whoseturnisit"])
            {

                ///////////////////////////////////////////////
                //this here is send a message, above is receive
                ///////////////////////////////////////////////

                //this is button one, really - user chose button one 

                ////Button6.Enabled = false;
                var holder1 = HttpContext.Current.Application["randomnumber1"];

                //you won got right pick
                if (holder1.ToString() == "1")
                {
                    //list1.Add(a);
                    ////Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('You Win!'); ", true);

                }


                //wrong pick - send message with code to disable
                else
                {

                    ///////////////////////////////////////////////////////////////////////
                    //this, below, a function//////////////////////////////////////////////
                    ///////////////////////////////////////////////////////////////////////
                    string msg = holder1.ToString();
                    OneChatRoom message = new OneChatRoom(msg, "0", "0");
                    //list1.Add(msg1);


                    //////////!!!!!!!!!!!!!!!!!!!!!TWO OF THESE!!!! forcing
                    //variable set at previous screen
                    var roomnumber = 1;


                    //sends message
                    switch (roomnumber)
                    {
                        case 1:
                            list1.Add(message);
                            HttpContext.Current.Application["Application_list1"] = list1;
                            break;

                        case 2:
                            list2.Add(message);
                            HttpContext.Current.Application["Application_list2"] = list2;
                            break;
                        case 3:
                            list3.Add(message);
                            HttpContext.Current.Application["Application_list3"] = list3;
                            break;
                        case 4:
                            list4.Add(message);
                            HttpContext.Current.Application["Application_list4"] = list4;
                            break;
                        case 5:
                            list5.Add(message);
                            HttpContext.Current.Application["Application_list5"] = list5;
                            break;


                        default:

                            break;
                    }




                }


            }

        }
    }



class threadclaas
{

public void childthreadcall()
{
    int flag = 1;
    while (flag == 1)
    {

        //remove this on completion of first page
        HttpContext.Current.Session["roomnumber"] = "1";


        var temp = HttpContext.Current.Session["roomnumber"];
        if (temp == "1")
        {
           // if (list1.Count != 0)
          //  {
          //
          //  }
        }


    }
}
}