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
        

        
        #region Constructor


        /// Wrap class and uses packaged Bluetooth
        public BluetoothClass(){
            newWatcher = new BluetoothClass
            {
                ScanningMode = BluetoothLEScanningMode.Active

            };
            //Listen out for new Advertisements
            newWatcher.Recieved += WatcherAdvertisementRecieved;


        }
        // We don't know what was recieved yet, so leave this blank, revisit later.
        private void WatcherAdvertisementRecieved(BluetoothClass sender, BluetoothClass reciever)
        {

        }
        #endregion
    }
}