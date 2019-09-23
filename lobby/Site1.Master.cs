


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


        this.Strin = -1;

        this.Personis = Personis;
        this.Chatroomname = Chatroomname;

    }
    public int Strin { get; set; }
    public string Personis { get; set; }
    public string Chatroomname { get; set; }

}

namespace lobby
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        //FIX THIS!!!
        string rand2 = "0";
        string[] holdsbuttonspressed = new string[] {"0","0","0","0","0" };
        ChangeUser swapuser = new ChangeUser();
        int counter = 0;
       
        List<OneChatRoom> list1 = new List<OneChatRoom>();

        List<OneChatRoom> list2 = new List<OneChatRoom>();
        List<OneChatRoom> list3 = new List<OneChatRoom>();
        List<OneChatRoom> list4 = new List<OneChatRoom>();
        List<OneChatRoom> list5 = new List<OneChatRoom>();
        OneChatRoom a = new OneChatRoom("y", "y", "y");



       
        protected void Application_Start(object sender, EventArgs e)
        {

            var temp1 = Session["MyUserNumber"];



        }

        protected void Session_Start(object sender, EventArgs e)
        {

           

            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //this is called when a control is used
            if (Page.IsPostBack)
            {
                Response.Write("in postback<br>");

            }


            else
            {


                //Random rand2 = new Random();
                //needs to be reworked
                rand2 = "1";
                Response.Write("in else<br>");
                //in previous page   - whose using current send
                var temp1 = Session["MyUserNumber"];
                string temp1a = temp1.ToString();
                //creates this variable from previous page
                var temp2 = Application["ThisIsFirstPageLoad"];
                string temp2a = temp2.ToString();

                 //starting, user two goes in these (previous page)
                if (temp1a == "0")
                {
                    if (temp2a == "1")
                    {
                        

                         Application["ThisIsFirstPageLoad"] = "2";

                        Response.Write("new response call<br>");
                        NewResponseCall();

                        
                        ///////////////////




                       
                    }
                }


            }



            //return ("B");
        }

        public void  function1()
        {
            AllDisabledClick(new object(), new EventArgs());
            
        }

        //called with thread while waiting on send - just room one for now
        public void NewResponseCall()
        {

            

            string flag = "1";

            
            Response.Write("in new respones function<br>");
            



            //waits for list to be added too

            list1 = (List<OneChatRoom>)Application["Application_list1"];
            while(list1 == null)
            {
                list1 = (List<OneChatRoom>)Application["Application_list1"];
            }
            

            //TWO OF THESE!!!!! - determined by previous page - hack
            string roomnumber = "1";

            if (roomnumber == "1")
            {

                var firstItem = list1.ElementAt(0);
                list1.RemoveAt(0);
                int item = firstItem.Strin;


                holdsbuttonspressed[item] = "1";
                
                //kept current
                Application["Application_list1"] = list1;



            }
            //else if (roomnumber == "2")
            //{

            //    list2.RemoveAt(0);

            //    Application["Application_list2"] = list2;

            //}
            //else if (roomnumber == "3")
            //{

            //    list3.RemoveAt(0);

            //    Application["Application_list3"] = list3;

            //}
            //else if (roomnumber == "4")
            //{
            //    list4.RemoveAt(0);

            //    Application["Application_list4"] = list4;

            //}
            //else if (roomnumber == "5")
            //{
            //    list5.RemoveAt(0);

            //   Application["Application_list5"] = list5;

            //}

            ////enable / disable buttons
            UpdateButtons(new object(), new EventArgs());


            Response.Write("recieve function - swap user<br>");
            
            //swap user
            var temp = Application["whoseturnisit"];
            string temp2 = temp.ToString();
            if (temp2 == "1")
            {
                Application["whoseturnisit"] = "0";
            }
            else
            {
               Application["whoseturnisit"] = "1";
            }




            
            /////////////////////////////////////////////////////////

            Application["WaitingForReciever"] = "done";
            while (flag == "1")
            {
                var waitforsender = Application["WaitingForSender"];
                string waitforsend = waitforsender.ToString();
                var waitforreceiver = Application["WaitingForReciever"];
                string waitforrec = waitforreceiver.ToString();
                if(waitforrec == "done" && waitforsend == "done")
                {
                    flag = "0";
                }

            }



            
        }


        
        
       

        //player one goes first
        protected void Button1_Click(object sender, EventArgs e)
        {



            //Button6.Enabled = false;
            
            if (rand2 == "1")

            {
                Application["randomnumber1"] = rand2;
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('You Win!'); ", true);

            }
            Button6.Enabled = false;
            Button2.Enabled = false;
            Button3.Enabled = false;
            Button4.Enabled = false;
            Button5.Enabled = false;
            SendMessage("1");
            

        }
        protected void Button2_Click(object sender, EventArgs e)
        {

            //Button2.Enabled = false;
             //rand2 = new Random().Next(1, 5);
            if (rand2 == "2")

            {
                Application["randomnumber1"] = rand2;

                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('You Win!'); ", true);

            }
            Button6.Enabled = false;
            Button2.Enabled = false;
            Button3.Enabled = false;
            Button4.Enabled = false;
            Button5.Enabled = false;
            SendMessage("2");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //Button3.Enabled = false;
             //rand2 = new Random().Next(1, 5);
            if (rand2 == "3")

            {
                Application["randomnumber1"] = rand2;
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('You Win!'); ", true);

            }
            Button6.Enabled = false;
            Button2.Enabled = false;
            Button3.Enabled = false;
            Button4.Enabled = false;
            Button5.Enabled = false;
            SendMessage("3");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //Button4.Enabled = false;
             //rand2 = new Random().Next(1, 5);
            if (rand2 == "4")
            
            {
                Application["randomnumber1"] = rand2;
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('You Win!'); ", true);

            }
            Button6.Enabled = false;
            Button2.Enabled = false;
            Button3.Enabled = false;
            Button4.Enabled = false;
            Button5.Enabled = false;
            SendMessage("4");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            
            if (rand2 == "5")
            {
                Application["randomnumber1"] = rand2;
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('You Win!'); ", true);

            }
            Button6.Enabled = false;
            Button2.Enabled = false;
            Button3.Enabled = false;
            Button4.Enabled = false;
            Button5.Enabled = false;
            string a = SendMessage("test");
           
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
           
            
            testfunction();


        }
        public void testfunction()
        {
            
            Button6.Enabled = false;

        }
        //this is the new event handler to handle everything

        protected void AllDisabledClick(object sender, EventArgs e)
        {
            Button6.Enabled = false;
            Button2.Enabled = false;
            Button3.Enabled = false;
            Button4.Enabled = false;
            Button5.Enabled = false;

        }
            protected void UpdateButtons(object sender, EventArgs e)
        {

            Button6.Enabled = true;
            Button2.Enabled = true;
            Button3.Enabled = true;
            Button4.Enabled = true;
            Button5.Enabled = true;
            //RESTORE THIS

            if (holdsbuttonspressed[0] == "1")
            {
                //this is correct!
                Button6.Enabled = false;
            }
            if (holdsbuttonspressed[1] == "1")
            {
                Button2.Enabled = false;

            }

            if (holdsbuttonspressed[2] == "1")
            {
                Button3.Enabled = false;
            }

            if (holdsbuttonspressed[3] == "1")
            {
                Button4.Enabled = false;
            }
            if (holdsbuttonspressed[4] == "1")
            {
                Button5.Enabled = false;
            }


            Label2.Text = "testing this...";
        }
        //////////////////////this is where user one starts - user 2 should be in while loop waiting for code
        //put thread start and stop at end to wait for receiving
        public string SendMessage(string buttonpressed)//, ref List<OneChatRoom> list9a, ref List<OneChatRoom> list9b, ref List<OneChatRoom> list9c, ref List<OneChatRoom> list9d, ref List<OneChatRoom> list5e)
        {
            
            Response.Write("in send message<br>");

            Button6.Enabled = false;
            Button2.Enabled = false;
            Button3.Enabled = false;
            Button4.Enabled = false;
            Button5.Enabled = false;



            var temp1 = Application["whoseturnisit"];
            var temp2 = Session["MyUserNumber"];
            string temp1a = temp1.ToString();
            string temp2a = temp2.ToString();

            
            if (temp1a == temp2a)
            {
                Response.Write("  2:  in send message<br>");
               

                ////make an array that holds real state of buttons
                ////so restore after all buttons disabled after send
                if (buttonpressed == "1")
                {
                    holdsbuttonspressed[0] = "1";
                }
                else if (buttonpressed == "2")
                {
                    holdsbuttonspressed[1] = "1";
                }
                else if (buttonpressed == "3")
                {
                    holdsbuttonspressed[2] = "1";
                }
                else if (buttonpressed == "4")
                {
                    holdsbuttonspressed[3] = "1";

                }
                else if (buttonpressed == "5")
                {
                    holdsbuttonspressed[4] = "1";
                }



                




                string msg = buttonpressed;
                //should be 1 - 5 is the message
                OneChatRoom message = new OneChatRoom(msg, "0", "0");



                //////////!!!!!!!!!!!!!!!!!!!!!TWO OF THESE!!!! forcing
                //variable will be set at previous screen
                int roomnumber = 1;

                Response.Write("adding a message<br>");
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

                Response.Write("swapping turn<br>");
                swapuser.SwapWhoseTurn();

                

                string flag = "1";
                Application["WaitingForSender"] = "done";
                while (flag == "1")
                {
                    var waitforsender = Application["WaitingForSender"];
                    string waitforsend = waitforsender.ToString();
                    var waitforreceiver = Application["WaitingForReciever"];
                    string waitforrec = waitforreceiver.ToString();
                    if (waitforrec == "done" && waitforsend == "done")
                    {
                        flag = "0";
                    }

                }
                NewResponseCall();

            }
            
            return ("A");

        }
        //////////////////////

       

        protected void Button10_Click(object sender, EventArgs e)
        {
            SendMessage("1");

            
            //int num = r.Next();
            //string randnum = num.ToString();
           

        }
    }

}

    public class ChangeUser
    {
        public string SwapWhoseTurn()
        {
        
        //switch whose turn
        var temp = HttpContext.Current.Application["whoseturnisit"];
        string temp2 = temp.ToString();
            if (temp2 == "1")
            {
                HttpContext.Current.Application["whoseturnisit"] = "0";
            }
            else
            {
                HttpContext.Current.Application["whoseturnisit"] = "1";
            }
        return ("D");

    }

    }




    

   


