using UnityEngine;

namespace BridgeDesignPattern
{
    public class SamsungLedTv : LEDTV
    {
        public void SwitchOn()
        {
            Debug.Log("Turning ON : Samsung TV");
        }
        public void SwitchOff()
        {
            Debug.Log("Turning OFF : Samsung TV");
        }
        public void SetChannel(int channelNumber)
        {
            Debug.Log("Setting channel Number " + channelNumber + " on Samsung TV");
        }
    }
}