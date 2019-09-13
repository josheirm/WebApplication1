using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Diagnostics;
using System.ComponentModel;
//List<object> list2 = new List<Object>();





public class Room
{
   // string Name = "";
   // string Room = "";



    public Room(string room1, string name1)
    {
        this.Nyroom = room1;
        this.Name = name1;

    }
    public void Setnewroom()
    {

    }
    public void Setnewname()
    {


    }
    public void JoinRoom()
    {
        





        


    }


public string Name { get; set; }
public string Nyroom { get; set; }

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




class Test
{




    public Test()
    {
        //https://stackoverflow.com/questions/18865574/multidimensional-array-of-object-c-sharp
        //List<object[]>.
        OneChatRoom[,] obj = new OneChatRoom[10, 10];
        OneChatRoom[][] obj2 = new OneChatRoom[10][];
    }
         void GetText(string path, string filename)
        {

        for (int i = 0; i <= 10; i++)
        {
            //check messages for any application level messages in queue and if so print in text box
            //loop through chatroom array and if chatroom is current (selected) than put text in current textbox
            //and send mesaage to any other chosen chatrooms with an application level message looping through chatroom


        //go through array of chatrooms in order are   person  room   string  
        //room is known as user is in that room (all)
        //if room is encountered post that string

        }


        



    }



}


namespace WebApplication1
{





    public partial class About : Page
    {
       // public bool IsPostBack { get; }

       


    //List<object> list2 = new List<Object>();
    //list2.GetB {"a"};

    //OneChatRoom test1; 


    List<OneChatRoom> list2 = new List<OneChatRoom>();
        OneChatRoom a = new OneChatRoom("y", "y", "y");
        OneChatRoom b = new OneChatRoom("b", "b", "b");
        OneChatRoom d = new OneChatRoom("z", "z", "z");

        //list2(1)
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
        protected void L3a(object sender, EventArgs e)
        {
            Label1.Text = "changed";
        }

        protected void Browser2Click(object sender, EventArgs e)
        {
            Label1.Text = "changed";
        }

            protected void Click(object sender, System.EventArgs e)
        {
            //Room Roomlist = new Room("a", "a");


            //var listCache = new MyListCache();

            //listCache.MyList.Add(Roomlist);




            Button1.Style.Add("background-color", "green");
            
            Label1.Text = "changed";





        }
        protected void L1(object sender, System.EventArgs e)
        {
            Button1.Style.Add("background-color", "green");

            var a = "test";

            Label1.Text = a;



        }

       


        protected void OnSubmit1(object sender, System.EventArgs e)
        {
            

            //string sendthisstring = Text2.Text;
            //Text1.Text += Environment.NewLine;
            //Text1.Text += sendthisstring; 
            //Text2.Text = " ";


        }

        protected void Text1_TextChanged(object sender, EventArgs e)
        {

        }

        
        //protected void Button2_Click(object sender, EventArgs e)
        //{
        // Get an instance


        //}

        //List<object> list2 = new List<Object>();

        //protected void Browser2Click(object sender, EventArgs e)
        //{



        //OneChatRoom a = new OneChatRoom("d", "d", "f");




        //list2 = (List<OneChatRoom>)Session["var1"];
        //List<OneChatRoom> list2 = new List<OneChatRoom>();
        //OneChatRoom b = new OneChatRoom("a", "b", "c");

        //List<OneChatRoom> list2;


        //list2.Add(b);


        //List<OneChatRoom> list2;

        //string w = "1";
        //string x = "2";
        //different list2 in repeated page
        //if(Room == 1)
        //Application["test1"] = list1;
        //if(Room == 2)


        //Application["test2"] = list2;
        //list2 = (List<OneChatRoom>)Application["test2"];



        //foreach(var item in list2)
        //{

        ////  Label1.Text = "jjj";// list2[0].Personis.ToString();

        //ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + list2[0].Personis + list2[1].Personis +list2[2].Personis + "');", true);
        // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + list2[1].Personis + "');", true);
        // Debug.WriteLine(item.Personis.ToString());
        //}

        //Application[x] = list2;
        //Application["test4"] = list4;


        //for (int i = 0; i <= 2; i++)
        //{
        //    list2 = (List<OneChatRoom>)Application["test1"];
        //    list2 = Application["test2"];
        //    list2[i] = list2[1];

        //    list2[i].Chatroomname = "a";
        //}
        ////list2 = (List<OneChatRoom>)Application["test2"];

        //Session["var1"] = list2;





        //   OneChatRoom a = new OneChatRoom("a", "b", "c");


        //    list2.Add(a);
        //    list2.Add(a);

        //    Cache["ObjectList"] = list2;                 // add


        //     list2 = (List<object>)Cache["ObjectList"]; // retrieve

        // Session["holder"] = list2;



        //neChatRoom a = new OneChatRoom("a", "b", "c");
        // Get an instance
        //var listCache = new MyListCache();

        //// Add something
        //listCache.MyList.Add(a);

        // Enumerate
        //foreach (var o in listCache.MyList)
        //{
        //    Debug.WriteLine(o.ToString());
        //}

        //Debug.WriteLine("hello");

        //}
        protected void Browser1Click(object sender, EventArgs e)
        {
           // list2 = (List<OneChatRoom>)Application["test2"];

            //OneChatRoom b = new OneChatRoom("a", "b", "c");



            //list2 = (List<OneChatRoom>)Session["var1"];
            //OneChatRoom b = new OneChatRoom("d", "d", "f");
            //List<object> list2 = new List<Object>();


            list2.Add(d);

            Application["test2"] = list2;
            list2 = (List<OneChatRoom>)Application["test2"];
            



            //list2 = (List<OneChatRoom>)Application["test2"];

            //Session["var1"] = list2;



            //Cache["ObjectList"] = list2;                 // add


            //list2 = (List<object>)Cache["ObjectList"]; // retrieve

            //Application["OneChat"] = b;
            //var a  = Application["OneChat"];





            //OneChatRoom b = new OneChatRoom("d", "e", "f");
            //// Get an instance
            //var listCache = new MyListCache();

            //// Add something
            //listCache.MyList.Add(b);

            //// Enumerate
            //foreach (var o in listCache.MyList)
            //{
            //    Debug.WriteLine(o.ToString());
            //}

        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {

        }
        //protected void Click(object sender, System.EventArgs e)




    }

}



