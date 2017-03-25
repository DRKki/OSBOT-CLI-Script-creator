using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSBotCreator
{
    public abstract class Variables
    {
        public static string cliString;

        public static string osbotJarPath;

        public static string memory;
        public static string debugPort;
        public static string allowDataCollection;
        public static string allowPermission;
        public static string proxy;


        public static string osbotLogin;
        public static string osbotUsername;
        public static string osbotPassword;

        public static bool editing;
        public static bool illegalCharacters;

        public static string botLogin;
        public static string botUsername;
        public static string botPassword;
        public static string botPin;

        public static string script;
        public static string scriptIdName;
        public static string scriptParams;
        public static string world;

        public static List<ListviewRecord> listOfScripts = new List<ListviewRecord>();


        public static string userProfile = System.Environment.GetEnvironmentVariable("USERPROFILE");
        public static string configFolder = userProfile + "\\Documents\\OSBot Script Creator\\Config";
        public static string collectionFile = userProfile + "\\Documents\\OSBot Script Creator\\Config\\Collection.ini";
    }
}
