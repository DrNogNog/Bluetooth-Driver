using System;
using Windows.Devices.Bluetooth.Advertisement;

namespace Blueberry.Desktop.WindowsApp.Bluetooth
{
    public class BluetoothClass
    {
        // private region
        #region Private Members
        
        private BluetoothClass newWatcher;
        
        #endregion
        
        #region Public Events

        public event Action StoppedListening = () => {};
        #endregion 
        
        #region Constructor


        /// Wrap class and uses packaged Bluetooth
        public BluetoothClass(){
            newWatcher = new BluetoothClass
            {
                ScanningMode = BluetoothLEScanningMode.Active
            };
            //Listen out for new Advertisements
            newWatcher.Recieved += WatcherAdvertisementRecieved;
            newWatcher.Stopped += (watcher, e) => 
            {
                //TODO
                StoppedListening();
            };


        }
        #endregion

        #region Private Methods
        // We don't know what was recieved yet, so leave this blank, revisit later.
        private void WatcherAdvertisementRecieved(BluetoothClass sender, BluetoothClass reciever)
        {

        }
        #endregion
    }
}