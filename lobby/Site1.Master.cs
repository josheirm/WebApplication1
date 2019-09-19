


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


         
        string[] holdsbuttonspressed = new string[] {"0","0","0","0","0" };
        ChangeUser swapuser = new ChangeUser();
        int counter = 0;

        int rand = 0;
        List<OneChatRoom> list1 = new List<OneChatRoom>();

        List<OneChatRoom> list2 = new List<OneChatRoom>();
        List<OneChatRoom> list3 = new List<OneChatRoom>();
        List<OneChatRoom> list4 = new List<OneChatRoom>();
        List<OneChatRoom> list5 = new List<OneChatRoom>();
        OneChatRoom a = new OneChatRoom("y", "y", "y");



       
        protected void Application_Start(object sender, EventArgs e)
        {

            



        }

        protected void Session_Start(object sender, EventArgs e)
        {

           

            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //these are scoped in event here, event handlers
            
            //in global.asax now
            //Application["ThisIsFirstPageLoad"] = "1";
           
            //in global.asax now
            //Application["CommandWasReceived"] = "no";
            if (Page.IsPostBack)
            {


            }


            else
            {
                
               
                

                var temp1 = Application["MyUserNumber"];
                
                //////////////////////create this variable from previous page
                var temp2 = Application["ThisIsFirstPageLoad"];
                

               

               

                

                //DOES THESE NEED TO BE TOSTRING()?!?!?
                //this is the first time on this page, it is user 2
                //other user will be sending 
                if (temp2 == "1" && temp1 == "0")
                {
                    Application["ThisIsFirstPageLoad"] = "2";

                    ThreadStart childthread = new ThreadStart(childthreadcall);
                    Response.Write("Child Thread Started <br/>");
                    Thread child = new Thread(childthread);

                    child.Start();

                    var temp3a = Application["WaitingForCOde"];

                    //affectivly frozen here
                    //initial user two is in here, waiting on a thread until sent message is received
                    //!!!!received called and than users are switched and than user leaves thread waiting loop!!!!
                    //and was swapped, so receiver is now sender

                    //double loop mechanism to create a way to wait for command
                    while (temp3a != "yes")
                    {
                        temp3a = Application["WaitingForCode"];
                        Thread.Sleep(2000);
                    }
                        
                    //abort thread because command received by receiver
                    child.Abort();
                }

                

                rand = new Random().Next(1, 5);
                Application["randomnumber1"] = rand.ToString();

                //put in global and set in previous page
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


            

        }
        //called with thread while waiting on send - just room one for now
        public void childthreadcall()
        {
           

            int flag = 1;
            while (flag == 1)
            {
                //make sure receive is ready when send is allowed
                Application["WaitingForCode"] = "yes";
                //set at one for now
                var temp = Session["roomnumber"];
                ///////////////!!!!
                ///change this!
                temp = 1;

                //create all the other 4 rooms,when read...
                if (temp == "1")
                {
                    var code = Application["Application_list1"];

                    //has recieved senders code, sender is now recieiver
                    if (code != "")
                    {

                       
                        //leaving while loop that get's code so code is done recieving in the while
                        Application["WaitingForCode"] = "no";
                        // call recieve code function here
                        Receive(code.ToString());
                        //recieved here so receivers can abort thread
                       

                       //has been swapped, reciever now sender
                       Application["CommandWasReceived"] = "yes";

                    }
                }

            }
        }






        //player one goes first
        protected void Button1_Click(object sender, EventArgs e)
        {
            
            //was test
            //var variable = Application["ThisIsFirstPageLoad"];

            //string thisstring = variable.ToString();

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
           // testfunction();


        }
        public void testfunction()
        {
            Button6.Enabled = false;
        }
        //////////////////////this is where user one starts - user 2 should be in while loop waiting for code
        //put thread start and stop at end to wait for receiving
        public void SendMessage(string buttonpressed)//, ref List<OneChatRoom> list9a, ref List<OneChatRoom> list9b, ref List<OneChatRoom> list9c, ref List<OneChatRoom> list9d, ref List<OneChatRoom> list5e)
        {
            //code is recieved to be received so send 
            if(Application["WaitingForReceiver"] ==  "yes")
            { 



            //make an array that holds real state of buttons
            //so restore after all buttons disabled after send
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








            var holder1 = HttpContext.Current.Application["randomnumber1"];


            //you won got right pick
            if (holder1.ToString() == buttonpressed)
            {

                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('You Win!'); ", true);
            }


            //wrong pick - send message with code to while of thread, it will disable in the receive function 
            //called by while routine
            else
            {

                ///////////////////////////////////////////////////////////////////////
                //this, below, a function//////////////////////////////////////////////
                ///////////////////////////////////////////////////////////////////////
                string msg = holder1.ToString();
                //should be 1 - 5 is the message
                OneChatRoom message = new OneChatRoom(msg, "0", "0");
                //list1.Add(msg1);


                //////////!!!!!!!!!!!!!!!!!!!!!TWO OF THESE!!!! forcing
                //variable will be set at previous screen
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
            //}old brace
            //array at top holds real button states for renewal at end of receive
            Button6.Enabled = false;
            Button2.Enabled = false;
            Button3.Enabled = false;
            Button4.Enabled = false;
            Button5.Enabled = false;

            //after this is not sender, is becoming reciever
            swapuser.SwapWhoseTurn();

            //this user now waits for a code to be sent back
            ThreadStart childthread = new ThreadStart(childthreadcall);
            Thread child = new Thread(childthread);

            //is receiver, so waits here until recieved message, when receive function done 
            //and changes to sender, this sender has swapped and becomes reciever waiting for 
            //message to be sent with button press.
            child.Start();
            
                
            //sending messager is now reciever  stays here until code received
            //double loop mechanism
            var temp3b = Application["WaitingForCode"]; 
            while (temp3b != "yes")
            {
                temp3b = Application["WaitingForCode"]; 
                Thread.Sleep(2000);
            }

            /////////////

            child.Abort();




        }    
        //end send message
        }
        //////////////////////

        //at start user two is in while loop and when code received goes here
        //public void Receive(ref int buttontodisable, ref List<OneChatRoom> list1, ref List<OneChatRoom> list2, ref List<OneChatRoom> list3, ref List<OneChatRoom> list4, ref List<OneChatRoom> list5)
        public void Receive(string buttontodisable)
        {


            //if (HttpContext.Current.Session["MyUserNumber"] != HttpContext.Current.Application["whoseturnisit"])
            //{old brace

                ////////////for testing
                //string msg = buttontodisable;
                //OneChatRoom message = new OneChatRoom(msg, "0", "0");
                //list1.Add(message);
                //HttpContext.Current.Application["Application_list1"] = list1;
                ////list1.Add(message);
                //list1 = (List<OneChatRoom>)HttpContext.Current.Application["Application_list1"];
                ////////////end testing


                //TWO OF THESE!!!!! - determined by previous page - hack
                var roomnumber = 1;

                if (roomnumber == 1)
                {

                    //the code is the number of the button sent to disable
                    //var code = (List<OneChatRoom>)HttpContext.Current.Application["Application_list1"];
                    list1.RemoveAt(0);
                    //Session["thecode"] = code ;

                    //to use after

                    //held in an HttpContext.Current.Application variable
                    HttpContext.Current.Application["Application_list1"] = list1;
                    ////Button6.Enabled = false;



                }
                else if (roomnumber == 2)
                {
                    //var code = (List<OneChatRoom>)HttpContext.Current.Application["Application_list2"];
                    list2.RemoveAt(0);
                    //Session["thecode"] = code;
                    HttpContext.Current.Application["Application_list2"] = list2;
                    ////Button2.Enabled = false;
                }
                else if (roomnumber == 3)
                {
                    //var code = (List<OneChatRoom>)HttpContext.Current.Application["Application_list3"];
                    list3.RemoveAt(0);
                    //Session["thecode"] = code;
                    HttpContext.Current.Application["Application_list3"] = list3;
                    ////Button3.Enabled = false;
                }
                else if (roomnumber == 4)
                {
                    //var code = (List<OneChatRoom>)HttpContext.Current.Application["Application_list4"];
                    list4.RemoveAt(0);
                    //Session["thecode"] = code;
                    HttpContext.Current.Application["Application_list4"] = list4;
                    ////Button4.Enabled = false;
                }
                else if (roomnumber == 5)
                {
                    //var code = (List<OneChatRoom>)HttpContext.Current.Application["Application_list5"];
                    list5.RemoveAt(0);
                    //Session["thecode"] = code;
                    HttpContext.Current.Application["Application_list5"] = list5;
                    ////Button5.Enabled = false;
                }


                //renew save state
                //holdsbuttonspressed[0]

                
                if(holdsbuttonspressed[0] != "1")
                {
                        //this is correct!
                        Button6.Enabled = true;
                }
                if (holdsbuttonspressed[1] != "1")
                {
                    Button2.Enabled = true;

                }

                if (holdsbuttonspressed[2] != "1")
                {
                    Button3.Enabled = true;
                }

                if (holdsbuttonspressed[3] != "1")
                {
                    Button4.Enabled = true;
                }
                if (holdsbuttonspressed[4] != "1")
                {
                    Button5.Enabled = true;
                }

                //?
                swapuser.SwapWhoseTurn();

                //child.Abort();
                // return;

            //}old brace

            //namespace
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            SendMessage("1");
           // Receive("1");
            

        }
    }

}

    public class ChangeUser
    {
        public void SwapWhoseTurn()
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
    
    //this is the start of the program by user number 1, user number 2 should be 
    //in while loop

    class MyClass2
    {
        public void SendMessage(string buttonpressed, ref List<OneChatRoom> list1, ref List<OneChatRoom> list2, ref List<OneChatRoom> list3, ref List<OneChatRoom> list4, ref List<OneChatRoom> list5)
        {

            if (HttpContext.Current.Session["MyUserNumber"] == HttpContext.Current.Application["whoseturnisit"])
            {

                //do this in event handler on press of button for each event handler
                //Button6.Enabled = false;


                var holder1 = HttpContext.Current.Application["randomnumber1"];

                //you won got right pick
                if (holder1.ToString() == buttonpressed)
                {
                    //Response.Write("You won!");
                    //Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('You Win!'); ", true);
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