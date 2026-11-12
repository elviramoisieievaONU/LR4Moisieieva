using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace LR4Moisieieva
{
    public class Resource : INotifyPropertyChanged
    {
        private Process activeProcess;

        public Process ActiveProcess
        {
            get { return activeProcess; }
            set
            {
                activeProcess = value;
                OnPropertyChanged();
            }
        }

        public void WorkingCycle()
        {
            if (!IsFree())
            {
                activeProcess.IncreaseWorkTime();
            }
        }

        public bool IsFree()
        {
            return activeProcess == null;
        }

        public void Clear()
        {
            ActiveProcess = null;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}