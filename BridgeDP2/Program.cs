// See https://aka.ms/new-console-template for more information

using BridgeDP2.Concrete;
using BridgeDP2.Concrete.Battery;
using BridgeDP2.Concrete.Process;

var iphone = new iPhone12Pro(new DejiBattery(),new AppleA14Processor());
var mi11=new Mi11(new TtecBattery(),new SnapDragon888Processor());
var oneplus9 = new OnePlus9(new DejiBattery(),new SnapDragon888Processor());
iphone.StartPhone();
Dash();
mi11.StartPhone();
Dash();
oneplus9.StartPhone();
 void Dash()
{
    Console.WriteLine("---------------------");
}