using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace xamarinplayground.MVVM
{
    public class MyPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int counter = 0;

        private string result;
        public string Result
        {
            get
            {
                return result;
            }
            private set
            {
                if (result != value)
                {
                    result = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Result)));
                }
            }
        }

        private ICommand incrementCommand;
        public ICommand IncrementCommand
        {
            get
            {
                if (incrementCommand == null)
                {
                    incrementCommand = new Command(IncrementProcedure);
                }

                return incrementCommand;
            }
        }

        private void IncrementProcedure()
        {
            counter++;
            Result = counter.ToString();
        }

    }
}
