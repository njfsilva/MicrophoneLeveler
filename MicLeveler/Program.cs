using CoreAudioApi;
using System.Threading;

namespace MicLeveler
{
    class Program
    {
        static void Main(string[] args)
        {

            MMDeviceEnumerator DevEnum = new MMDeviceEnumerator();

            var device = DevEnum.GetDefaultAudioEndpoint(EDataFlow.eCapture, ERole.eMultimedia);

            while (true) 
            {
                if (device.AudioEndpointVolume.MasterVolumeLevel != 0)
                {
                    device.AudioEndpointVolume.MasterVolumeLevel = 0;
                }

                Thread.Sleep(1000);
            }
        }
    }
}
