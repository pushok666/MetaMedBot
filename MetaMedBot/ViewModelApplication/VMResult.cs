using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MetaMedBot.ModelData;

namespace MetaMedBot.ViewModelApplication
{
    public class VMResult : INotifyPropertyChanged
    {
        
        
        public ObservableCollection<Analysis> Analyses { get; set; }
        public ObservableCollection<Analysis> Analyses2 { get; set; }

        public VMResult()
        {
            Analyses = new ObservableCollection<Analysis>();
            foreach (var item in App.AnalysesList)
            {
                Analyses.Add(item);
            }

            Analyses2 = new ObservableCollection<Analysis>();
            foreach(var item in App.AnalysesList2)
            {
                Analyses2.Add(item);
            }
            
            
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
