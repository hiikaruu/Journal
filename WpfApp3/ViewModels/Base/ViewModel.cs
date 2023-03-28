using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace WpfApp3.ViewModels.Base
{
    internal abstract class ViewModel : INotifyPropertyChanged, IDisposable
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
        protected virtual bool Set<T>(ref T filed, T value, [CallerMemberName] string PeopsertName = null)
        {
            if (Equals(filed, value)) return false;
            filed = value;
            OnPropertyChanged(PeopsertName);
            return true;
        }
        //~ViewModel()
        //{
        //    Dispose(false);
        //}
        public void Dispose()
        {
            Dispose(true);
        }
        private bool _Disposed;
        protected virtual void Dispose(bool Disposing)
        {
            if (!Disposing || _Disposed) return;
            _Disposed = true;
        }

    }
}
