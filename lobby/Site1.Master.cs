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

            //this is the main hack!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


            Session["MyUserNumber"] = 1;
            //RECEIVING MESSAGE if not the same
            if (Session["MyUserNumber"] != Application["whoseturnisit"])
            {
            
              

                    //TWO OF THESE!!!!! - determined by previous page - hack
                    var roomnumber = 1;
                    
                    if (roomnumber == 1 )
                    {
                    //the code is the number of the button sent to disable
                    var code = (List<OneChatRoom>)Application["Application_list1"];
                    list1.RemoveAt(0);
                    //to use after
                    Session["thecode"] = code;
                    //held in an application variable
                    Application["Application_list1"] = list1;

                }
                    if (roomnumber == 2)
                    {
                    var code = (List<OneChatRoom>)Application["Application_list2"];
                    list2.RemoveAt(0);
                    Session["thecode"] = code;
                    Application["Application_list2"] = list1;
                }
                    if (roomnumber == 3)
                    {
                    var code = (List<OneChatRoom>)Application["Application_list3"];
                    list3.RemoveAt(0);
                    Session["thecode"] = code;
                    Application["Application_list3"] = list1;
                }
                    if (roomnumber == 4)
                    {
                    var code = (List<OneChatRoom>)Application["Application_list4"];
                    list4.RemoveAt(0);
                    Session["thecode"] = code;
                    Application["Application_list4"] = list1;
                }
                    if (roomnumber == 5)
                    {
                    var code = (List<OneChatRoom>)Application["Application_list5"];
                    list5.RemoveAt(0);
                    Session["thecode"] = code;
                    Application["Application_list5"] = list1;
                }
                    
                    //disable button of code sent

                    if(Session["thecode"] == "1")
                    {
                         Button6.Enabled = false;
                    }


                if (Session["thecode"] == "2")
                {
                    Button2.Enabled = false;
                }

                if (Session["thecode"] == "3")
                {
                    Button3.Enabled = false;
                }

                if (Session["thecode"] == "4")
                {
                    Button4.Enabled = false;
                }

                if (Session["thecode"] == "5")
                {
                    Button5.Enabled = false;
                }


                //got code 
                // now switch users and return out so user sends next time
                var temp = Application["whoseturnisit"];
                if ((string)temp == "1")
                {
                    Application["whoseturnisit"] = 0;
                }
                else
                {
                    Application["whoseturnisit"] = 1;
                }

                //exit receiving code
                return;
            }

            ///////////////////////////////////////////////
            //this here is send a message, above is receive
            ///////////////////////////////////////////////
            
            //this is button one, really - user chose button one 

            Button6.Enabled = false;
            var  holder1 = Application["randomnumber1"];
            
            //you won got right pick
            if (holder1 == "1")
            {
                //list1.Add(a);
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('You Win!'); ", true);

            }


            //wrong pick - send message with code to disable
            else
            {

                ///////////////////////////////////////////////////////////////////////
                //this, below, a function//////////////////////////////////////////////
                ///////////////////////////////////////////////////////////////////////

                OneChatRoom message = new OneChatRoom("1", "0", "0");
                //list1.Add(msg1);


                //////////!!!!!!!!!!!!!!!!!!!!!TWO OF THESE!!!! forcing
                //variable set at previous screen
                var roomnumber = 1;
                

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
                   

                    default:

                        break;
                }

                //switch whose turn
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