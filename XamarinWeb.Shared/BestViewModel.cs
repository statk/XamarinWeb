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
            ShouldShowBestMessage = false;
        }

        private void IncreaseBestness()
        {
            BestCount++;
            ShouldShowBestMessage = (BestCount % 2) == 0;
        }

        private void Set<T>(ref T awsomeCount, T value)
        {
            awsomeCount = value;
            OnPropertyChanged(nameof(BestCount));
        }
    }
}
