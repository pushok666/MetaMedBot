using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using MetaMedBot.ModelData;

namespace MetaMedBot
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static int countUserC = 0;
        public static ContentPresenter MContent;
        public static Initials initPerson = new Initials();
        public static PropertyPerson PropertyPerson = new PropertyPerson();
        public static List<string> AnswerList =new List<string>();
        public static List<string> SmokerList = new List<string>();
        public static List<Analysis> AnalysesList = new List<Analysis>();
        public static List<Analysis> AnalysesList2 = new List<Analysis>();
       
    }
}
