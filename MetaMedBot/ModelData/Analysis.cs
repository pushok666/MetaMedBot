using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MetaMedBot.ModelData
{
    public class Analysis : INotifyPropertyChanged
    {
        private string name;
        private int result;
        private int startRange;
        private int endRange;
        private string inRange;
        private string recomendations;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public int Result
        {
            get { return result; }
            set
            {
                result = value;
                CheckRange();
                OnPropertyChanged("Result");
            }
        }
        public int StartRange
        {
            get { return startRange; }
            set
            {
                startRange = value;
                OnPropertyChanged("StartRange");
            }
        }
        public int EndRange
        {
            get { return endRange; }
            set
            {
                endRange = value;
                OnPropertyChanged("EndRenge");
            }
        }
        public string InRange
        {
            get { return inRange; }
            set
            {
                inRange = value;
                OnPropertyChanged("InRange");
            }
        }
        public string Recomendations
        {
            get { return recomendations; }
            set
            {
                recomendations = value;
                OnPropertyChanged("Recomendations");
            }
        }

        public void CheckRange()
        {
            if (StartRange <= Result && EndRange >= Result)
            {
                InRange = "Соответсвует";
                Recomendations = "Консультация врача не требуется";
            }
            else
            {
                InRange = " Не соответсвует";
                Recomendations = "Требуется косультация врача";
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
