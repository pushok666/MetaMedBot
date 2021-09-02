using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MetaMedBot.ModelData
{
    class Answer : INotifyPropertyChanged
    {
        private int id;
        private string answer;
        private int score;
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }
        public int Score
        {
            get { return score; }
            set
            {
                score = value;
                OnPropertyChanged("Score");
            }
        }
        public string Aanswer
        {
            get { return answer; }
            set
            {
                answer = value;
                OnPropertyChanged("Aanswer");
            }
        }
        public string Question { get; set; }
        
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
