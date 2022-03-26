// See https://aka.ms/new-console-template for more information
using BridgeDP.App;



IPrinter printer1 = new HpPrinter();
IPrinter printer2 = new CanonPrinter();
AbstractConnectionControl control = new WiredConnectionControl(printer1);
control.SetScan();
control = new WifiConnectionControl(printer2);
control.SetScan();
control = new BluetoothConnectionControl(printer1);
control.SetScan();
