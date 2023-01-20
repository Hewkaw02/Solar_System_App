using Phichaya_1911310512.Model;
using Phichaya_1911310512.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Phichaya_1911310512.ViewModel
{
    class PicViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        IPicService _rest = DependencyService.Get<IPicService>();

        public PicViewModel() {

            GetPics();

        }

        private async void GetPics()
        {
            var result = await _rest.getPic();
            if (result != null)
            {
                PicDetail = new ObservableCollection<PicDetail>() { result };
            }
        }

        private ObservableCollection<PicDetail> picDetail;

        public ObservableCollection<PicDetail> PicDetail
        {
            get { return picDetail; }
            set
            {
                picDetail = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PicDetail"));
            }
        }
    }
}
