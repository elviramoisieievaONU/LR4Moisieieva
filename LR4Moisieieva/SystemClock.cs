using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LR4Moisieieva
{
    public class SystemClock : INotifyPropertyChanged
    {
        private long clock;

        public long Clock
        {
            get { return clock; }
            private set
            {
                clock = value;
                OnPropertyChanged();
            }
        }

        public void WorkingCycle()
        {
            Clock++;
        }

        public void Clear()
        {
            Clock = 0;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}