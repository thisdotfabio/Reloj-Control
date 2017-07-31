using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.UI.Xaml.Controls;

namespace Reloj_Control
{
    public sealed partial class Clock : UserControl, INotifyPropertyChanged
    {
        private DateTime _time;
        public DateTime Time
        {
            get { return _time; }
            set
            {
                if (_time != value)
                {
                    _time = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Clock()
        {
            this.InitializeComponent();
            this.DataContext = this;

            if(!DesignMode.DesignModeEnabled)
                Dotimer();
        }

        private async void Dotimer()
        {
            await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, async () =>
              {
                  while (true)
                  {
                      Time = DateTime.Now;
                      await Task.Delay(1000);
                  }
              });
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
