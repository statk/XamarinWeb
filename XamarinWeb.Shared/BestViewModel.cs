using System.ComponentModel;

namespace XamarinWeb.Shared
{
    public class BestViewModel : INotifyPropertyChanged
    {
        private int _bestCount;
        private bool _shouldShowBestMessage;
        public event PropertyChangedEventHandler PropertyChanged;

        public int BestCount
        {
            get => _bestCount;
            private set => Set(ref _bestCount, value);
        }

        public bool ShouldShowBestMessage
        {
            get => _shouldShowBestMessage;
            private set => Set(ref _shouldShowBestMessage, value);
        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public SimpleCommand IncreaseBestCommand { get; private set; }

        public BestViewModel()
        {
            IncreaseBestCommand = new SimpleCommand(IncreaseBestness);
        }

        private void IncreaseBestness()
        {
            BestCount++;
            if ((BestCount % 2) == 0)
                ShouldShowBestMessage = true;
            else
                ShouldShowBestMessage = false;

        }

        private void Set<T>(ref T awsomeCount, T value)
        {
            awsomeCount = value;
            OnPropertyChanged(nameof(BestCount));
        }
    }
}
