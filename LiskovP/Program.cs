// See https://aka.ms/new-console-template for more information
using LiskovP.Abstract;
using LiskovP.Concrete;

BaseCamera camera = new SecurityCamera();
camera.StartCapture();
camera.StopCapture();

BaseCamera webcam = new WebCamera();
webcam.StartCapture();
webcam.StopCapture();
IMicrophone webcamMicrophone = new WebCamera();
webcamMicrophone.StartMicrophone();
webcamMicrophone.StopMicrophone();
