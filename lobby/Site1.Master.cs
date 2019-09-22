


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
        //FIX THIS!!!
        string rand2 = "0";
        string[] holdsbuttonspressed = new string[] {"0","0","0","0","0" };
        ChangeUser swapuser = new ChangeUser();
        int counter = 0;
        Random r = new Random();
        //int rand = 0;
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
                //string msg = "a";
                //OneChatRoom message = new OneChatRoom(msg, "0", "0");
                //list1.Add(message);
                //HttpContext.Current.Application["Application_list1"] = list1;
                ////list1.Add(message);
                //list1 = (List<OneChatRoom>)HttpContext.Current.Application["Application_list1"];

                Response.Write("in else<br>");
                //Receive("1");

                ////////////////////
                //in previous page   - whose using current send
                var temp1 = Session["MyUserNumber"];
                string temp1a = temp1.ToString();
                //creates this variable from previous page
                var temp2 = Application["ThisIsFirstPageLoad"];
                string temp2a = temp2.ToString();

                //this is right, don't forget to pick user on previous page (user 2 is zero value)
                if (temp1a == "0")
                {
                    if (temp2a == "1")
                    {
                        

                         Application["ThisIsFirstPageLoad"] = "2";

                        ThreadStart childthread = new ThreadStart(childthreadcall);
                       
                        Thread child = new Thread(childthread);
                      
                        Response.Write("Child Thread Started <br/>");
                        child.Start();
                        var temp3a = Application["WaitingForCode"];
                        string temp3b = temp3a.ToString();
                       
                        while (temp3b != "yes")
                        {
                            Response.Write("waiting for thred...<br>");

                            temp3a = Application["WaitingForCode"];
                            temp3b = temp3a.ToString();
                           
                        }
                        
                        child.Abort();
                        Application["WaitingForCode"] = "no";
                        Response.Write("thread done<br>");
                        ///////////////////




                        //while (temp3b != "yes")
                        //{
                        //    Response.Write("waiting for thred...<br>");

                        //    temp3a = Application["WaitingForCode"];
                        //    temp3b = temp3a.ToString();
                        //    //Thread.Sleep(2000);
                        //}
                        ////so receive internal while changes to not using while loop so this user can  
                        ////Thread.Sleep(2000);    
                        ////abort thread because command received by receiver
                        //Response.Write("aborting thread<br>");

                        //child.Abort();
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
        public void childthreadcall()
        {


            Response.Write("in thread<br>");
            //AllDisabledClick(new object(), new EventArgs());
            //Button6.Enabled = true;
            // Button2.Enabled = true;
            //Button3.Enabled = true;
            //Button4.Enabled = true;
            //Button5.Enabled = false;

            string flag = "1";

            //set at one for now
            //var temp = Session["roomnumber"];
            ///////////////!!!!

            var code = Application["Application_list1"];
            string code2 = "";
            //Response.Write("made it <br>");

            //Receive(code2); 
            //string flag = "1";
            /////////////////////////////////////////////////////////
            //{
                Response.Write("in recieve function<br>");
                //return ("S");



                ////////////for testing - sends a message (code)/////////

                //string msg = buttontodisable;
                //OneChatRoom message = new OneChatRoom(msg, "0", "0");
                //list1.Add(message);
                //HttpContext.Current.Application["Application_list1"] = list1;
                ////list1.Add(message);
                //list1 = (List<OneChatRoom>)HttpContext.Current.Application["Application_list1"];

                ////////////end testing

                //renew save state 


                //TWO OF THESE!!!!! - determined by previous page - hack
                string roomnumber = "1";

            if (roomnumber == "1")
            {


                list1.RemoveAt(0);

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
            //Response.Write("receive fundtion - enable buttons <br>");
            ////enable buttons
            //SomeButton_Click(new object(), new EventArgs());

            //Response.Write("recieve function - sleep<br>");
            ////Thread.Sleep(2000);

            Response.Write("recieve function - swap<br>");
            // swapuser.SwapWhoseTurn();

            ////////////////////////////////
            ///

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
            //return ("D");

            ////////////////////

            ////enable buttons
            SomeButton_Click(new object(), new EventArgs());
            /////////////////////////////////////////////////////////
            while (flag == "1")
            {
                Application["WaitingForCode"] = "yes";
            }



            //while (flag == "1")
            //{



               
            //    //create all the other 4 rooms,when read...
                
            //        code = Application["Application_list1"];
            //        code2 = code.ToString();
                    
            //       //has recieved senders code, sender is now recieiver
            //        if (code2 != "")
            //        {
            //            //Application["WaitingForCode"] = "yes";

            //            flag = "2";
            //            // call recieve code function here and changes receiver to sender
            //            Receive(code2);
                        
            //            //recieved here so receivers can abort thread
            //            //leaving while loop that get's code so code is done recieving in the while
            //            //Application["WaitingForCode"] = "no";



            //        }
                

            //}

            //string flag2 = "1";
            //while(flag2 ==  "1")
            //{
            //    Application["WaitingForCode"] = "yes";
            //    //flag2 = "0";
            //}
        }


        
        
       

        //player one goes first
        protected void Button1_Click(object sender, EventArgs e)
        {
            
            

            //Button6.Enabled = false;
             //rand2 = new Random().Next(1, 5);
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
            protected void SomeButton_Click(object sender, EventArgs e)
        {

            Button6.Enabled = false;
            Button2.Enabled = false;
            Button3.Enabled = true;
            Button4.Enabled = true;
            Button5.Enabled = true;
            //RESTORE THIS

            //if (holdsbuttonspressed[0] != "1")
            //{
            //    //this is correct!
            //    Button6.Enabled = true;
            //}
            //if (holdsbuttonspressed[1] != "1")
            //{
            //    Button2.Enabled = true;

            //}

            //if (holdsbuttonspressed[2] != "1")
            //{
            //    Button3.Enabled = true;
            //}

            //if (holdsbuttonspressed[3] != "1")
            //{
            //    Button4.Enabled = true;
            //}
            //if (holdsbuttonspressed[4] != "1")
            //{
            //    Button5.Enabled = true;
            //}
            Label2.Text = "testing this...";
        }
        //////////////////////this is where user one starts - user 2 should be in while loop waiting for code
        //put thread start and stop at end to wait for receiving
        public string SendMessage(string buttonpressed)//, ref List<OneChatRoom> list9a, ref List<OneChatRoom> list9b, ref List<OneChatRoom> list9c, ref List<OneChatRoom> list9d, ref List<OneChatRoom> list5e)
        {
            
            Response.Write("in send message<br>");
            //return ("a");
            var temp1 = Application["whoseturnisit"];
            var temp2 = Session["MyUserNumber"];
            string temp1a = temp1.ToString();
            string temp2a = temp2.ToString();

            //if (Application["whoseturnisit"] != Session["MyUserNumber"])
            if (temp1a == temp2a)
            {
                Response.Write("2in send message<br>");
                //    return("a");

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



                //wrong pick - send message with code to while of thread,
                //else
                //{




                string msg = buttonpressed;
                //should be 1 - 5 is the message
                OneChatRoom message = new OneChatRoom(msg, "0", "0");



                //////////!!!!!!!!!!!!!!!!!!!!!TWO OF THESE!!!! forcing
                //variable will be set at previous screen
                int roomnumber = 1;


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




                //}
                //used until asych tasks with await used.
                //paused to make sure reciver is done first





                //after this this is not sender, is becoming reciever
                //reciever already finished
                //this user will be use the receive
                //reciever will be sender
                Response.Write("send message swapping turn<br>");
                swapuser.SwapWhoseTurn();

                //////////////////////test
                //string msg2 = "a";
                //OneChatRoom message2 = new OneChatRoom(msg2, "0", "0");
                //list1.Add(message2);
                //HttpContext.Current.Application["Application_list1"] = list1;
                //list1.Add(message);
                //list1 = (List<OneChatRoom>)HttpContext.Current.Application["Application_list1"];

                //Application["ThisIsFirstPageLoad"] = "1";

                ///////////////////



                Button6.Enabled = false;
                Button2.Enabled = false;
                Button3.Enabled = false;
                Button4.Enabled = false;
                Button5.Enabled = false;


                ThreadStart childthread2 = new ThreadStart(childthreadcall);

                        Thread child2 = new Thread(childthread2);

                        Response.Write("Child Thread Started <br/>");
                        child2.Start();
                        var _temp3a = Application["WaitingForCode"];
                        string _temp3b = _temp3a.ToString();

                        while (_temp3b != "yes")
                        {
                            Response.Write("waiting for thred...<br>");

                            _temp3a = Application["WaitingForCode"];
                            _temp3b = _temp3a.ToString();

                        }
                       
                        child2.Abort();
                        Application["WaitingForCode"] = "no";

                        Response.Write("thread done<br>");
                        ///////////////////


                        //    //this user now waits for a code to be sent back
                        //    ThreadStart childthread = new ThreadStart(childthreadcall);
                        //    Thread child = new Thread(childthread);

                        //    //this function has a pause so that reciever is done first, 
                        //    //so we can use Application["WaitingForCode"]; 


                        //    //this is the receiver thread, so waits there until recieved message by the new sender, when receive function done 
                        //    //and changes to sender, this sender has swapped and becomes reciever waiting for 
                        //    //message to be sent with button press.

                        //    //sender creates a reciever thread that calls the recieve function
                        //    // this thread will be added to by next sender which will finish last again after reciever 

                        //    child.Start();
                        //    Response.Write("in send message waiting for sender<br>");
                        //    //double loop mechanism - creates a 2nd thread again
                        //    //makes sender the reciever
                        //    //this user is now the receiver called by internals
                        //    //the other user will run this send routine
                        //    var temp3b = Application["WaitingForCode"];
                        //    string temp3ba = temp3b.ToString();   
                        //while (temp3ba != "yes")
                        //{
                        //    temp3b = Application["WaitingForCode"];
                        //        temp3ba = temp3b.ToString();
                        //    //Thread.Sleep(2000);
                        //}
                        //    Application["WaitingForCode"] = "no";

                        ///////////////

                        //child.Abort();
                        //    Response.Write("done send message<br>");



                        //end send message
                    //}
                //}
            }
                    return ("A");

        }
        //////////////////////

        //at start user two is in while loop and when code received goes here
        //public void Receive(ref int buttontodisable, ref List<OneChatRoom> list1, ref List<OneChatRoom> list2, ref List<OneChatRoom> list3, ref List<OneChatRoom> list4, ref List<OneChatRoom> list5)

        //called from recievers internal 
        public string Receive(string buttontodisable)
        {
            Response.Write("in recieve function<br>");
            //return ("S");



            ////////////for testing - sends a message (code)/////////

            //string msg = buttontodisable;
            //OneChatRoom message = new OneChatRoom(msg, "0", "0");
            //list1.Add(message);
            //HttpContext.Current.Application["Application_list1"] = list1;
            ////list1.Add(message);
            //list1 = (List<OneChatRoom>)HttpContext.Current.Application["Application_list1"];

            ////////////end testing

            //renew save state 


            //TWO OF THESE!!!!! - determined by previous page - hack
            var roomnumber = 1;

                if (roomnumber == 1)
                {

                    
                    list1.RemoveAt(0);
                    
                    //kept current
                    HttpContext.Current.Application["Application_list1"] = list1;
                    


                }
                else if (roomnumber == 2)
                {
                    
                    list2.RemoveAt(0);
                    
                    HttpContext.Current.Application["Application_list2"] = list2;
                    
                }
                else if (roomnumber == 3)
                {
                    
                    list3.RemoveAt(0);
                    
                    HttpContext.Current.Application["Application_list3"] = list3;
                    
                }
                else if (roomnumber == 4)
                {
                   list4.RemoveAt(0);
                   
                    HttpContext.Current.Application["Application_list4"] = list4;
                    
                }
                else if (roomnumber == 5)
                {
                     list5.RemoveAt(0);
                    
                    HttpContext.Current.Application["Application_list5"] = list5;
                   
                }
            Response.Write("receive fundtion - enable buttons <br>");
            //enable buttons
            SomeButton_Click(new object(), new EventArgs());

            Response.Write("recieve function - sleep<br>");
            Thread.Sleep(2000);

            Response.Write("recieve function - swap<br>");
            swapuser.SwapWhoseTurn();

            return ("B");
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            SendMessage("1");

            
            int num = r.Next();
            string randnum = num.ToString();
           

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