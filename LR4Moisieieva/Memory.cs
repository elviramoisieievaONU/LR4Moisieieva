using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LR4Moisieieva
{
    public class Memory : INotifyPropertyChanged
    {
        private long occupiedSize;
        private long freeSize;

        public long OccupiedSize
        {
            get { return occupiedSize; }
            set
            {
                occupiedSize = value;
                OnPropertyChanged();
            }
        }

        public long FreeSize
        {
            get { return freeSize; }
            set
            {
                freeSize = value;
                OnPropertyChanged();
            }
        }

        public Memory Save(long size)
        {
            FreeSize = size;
            OccupiedSize = 0;
            return this;
        }

        public Memory Clear()
        {
            FreeSize = 0;
            OccupiedSize = 0;
            return this;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}