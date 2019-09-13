using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication1
{
    


    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {

            //List<OneChatRoom> list2 = new List<OneChatRoom>();
            //Application["UserList"] = list2;

            //List<object> list2 = new List<Object>();
            //List<object> list2 = new List<Object>();

            //room and person 
            //when user joins a room 
            //name is put in room object list
            //is a counter

            //you made a message and you check how many people are in room with you
            //person and message is put on the main queue for you too.

            //each user goes continuously through list to check for user is them
            //starting from the latest 
            //if them print for them and remove

            //Room Roomlist = new Room("a", "a");
            //List<Room> myList2 = new List<Room>();

            //Application["varroomlist"] = Roomlist;


            // https://stackoverflow.com/questions/1259934/store-list-to-session
            //OneChatRoom a = new OneChatRoom("a","a","a");
            //List<OneChatRoom> myList = new List<OneChatRoom>();

            //Application["var"] = myList;

            //myList = (List<OneChatRoom>)Application["var"];
            //myList.Add(a);


            //Application["obj1"] = obj;

            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        void Session_Start(object sender, EventArgs e)
        {
            //List<OneChatRoom> list2 = new List<OneChatRoom>();
            //Application["UserList"] = list2;
            //List<OneChatRoom> userList;

            //if (Application["UserList"] != null)
            //{

            //    userList = (List<OneChatRoom>)Application["userList"];
            //}

        }

    }
}