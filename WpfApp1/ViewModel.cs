using System.ComponentModel;
using System.Runtime.CompilerServices;
using WpfApp1.Annotations;

namespace WpfApp1
{
    public class ViewModel : INotifyPropertyChanged
    {
        private Model _model;

        public ViewModel()
        {
            Model = new Model {Name = "Model One"};
        }

        public Model Model
        {
            get => _model;
            set
            {
                _model = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
