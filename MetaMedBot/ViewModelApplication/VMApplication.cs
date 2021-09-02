using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MetaMedBot.ModelData;
using System.Collections.ObjectModel;

namespace MetaMedBot.ViewModelApplication
{
    class VMApplication : INotifyPropertyChanged
    {
        private Answer selectAnswer;
        public ObservableCollection<Answer> AnswerQ1 { get; set; }
        public ObservableCollection<Answer> AnswerQ2 { get; set; }
        public ObservableCollection<Answer> AnswerQ3_8 { get; set; }
        public ObservableCollection<Answer> AnswerQ9_10 { get; set; }
        public ObservableCollection<Answer> AnswerQ11 { get; set; }
        public ObservableCollection<Answer> AnswerQ14 { get; set; }
        public ObservableCollection<Answer> AnswerQ13 { get; set; }
        public ObservableCollection<Answer> AnswerQ12_1516 { get; set; }
        public Answer SelectedAnswer
        {
            set
            {
                selectAnswer = value;
                OnPropertyChanged("SelectedAnswer");
            }
            get { return selectAnswer; }
           
        }
        public VMApplication()
        {
            AnswerQ1 = new ObservableCollection<Answer>
            {
                new Answer{Id = 1, Aanswer = "Никогда", Score = 0},
                new Answer{Id = 2, Aanswer = "Раз в месяц или реже", Score = 1},
                new Answer{Id = 3, Aanswer = "2-4 раза в месяц", Score = 2},
                new Answer{Id = 4, Aanswer = "2-3 раза в неделю", Score = 3},
                new Answer{Id = 5, Aanswer = "4 и более раз в неделю", Score = 4}
            };
            AnswerQ2 = new ObservableCollection<Answer>
            {
                new Answer{Id = 1, Aanswer ="1 или 2 стандартных порций", Score = 0},
                new Answer{Id = 2, Aanswer ="3 или 4 стандартных порций", Score = 1},
                new Answer{Id = 3, Aanswer ="5 или 6 стандартных порций", Score = 2},
                new Answer{Id = 4, Aanswer ="7 или 8 стандартных порций", Score = 3},
                new Answer{Id = 5, Aanswer ="10 и более стандартных порций", Score = 4}
            };
            AnswerQ3_8 = new ObservableCollection<Answer>
            {
                new Answer{Id = 1, Aanswer = "Никогда", Score = 0},
                new Answer{Id = 2, Aanswer = "Меньше, чем раз в месяц", Score = 1},
                new Answer{Id = 3, Aanswer = "Ежемесячно", Score = 2},
                new Answer{Id = 4, Aanswer = "Еженедельно", Score = 3},
                new Answer{Id = 5, Aanswer = "Ежедневно или почти ежедневно", Score = 4}
            };
            AnswerQ9_10 = new ObservableCollection<Answer>
            {
                new Answer{Id = 1, Aanswer = "Никогда", Score = 0},
                new Answer{Id = 2, Aanswer = "Да, но это было год назад", Score = 2},
                new Answer{Id = 3, Aanswer = "Да, в течении этого года", Score = 4}
            };
            AnswerQ11 = new ObservableCollection<Answer>
            {
                new Answer{Id = 1, Aanswer = "В течении первых 5 минут", Score = 3},
                new Answer{Id = 2, Aanswer = "В течении первых 6-30 минут", Score = 2},
                new Answer{Id = 3, Aanswer = "В течении первых 30-60 минут", Score = 1},
                new Answer{Id = 4, Aanswer = "В течении  часа", Score = 0 }
            };
            AnswerQ14 = new ObservableCollection<Answer>
            {
                new Answer{Id = 1, Aanswer = "10 или меньше", Score = 0},
                new Answer{Id = 2, Aanswer = "11-20", Score = 1},
                new Answer{Id = 3, Aanswer = "21-30", Score = 2},
                new Answer{Id = 4, Aanswer = "31 и более", Score = 3}
            };
            AnswerQ13 = new ObservableCollection<Answer>
            {
                new Answer{Id= 1, Aanswer = "Первая сигарета утром", Score = 1},
                new Answer{Id = 2, Aanswer = "Все остальное", Score =0}
            };
            AnswerQ12_1516 = new ObservableCollection<Answer>
            {
                new Answer{Id = 1, Aanswer = "Да", Score = 1},
                new Answer{Id = 1, Aanswer = "Нет", Score = 0}
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
