// See https://aka.ms/new-console-template for more information
using FacadeDP.App.Concrete;


var gf = new GameFacade(new NvdiaDisplayCard(), new AirCooler());
var gameName = "Diablo II";
gf.StartGame(gameName);
gf.StopGame(gameName);
