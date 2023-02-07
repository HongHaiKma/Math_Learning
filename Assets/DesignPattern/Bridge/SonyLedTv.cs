using UnityEngine;

namespace BridgeDesignPattern
{
    public class SonyLedTv : LEDTV
    {
        public void SwitchOn()
        {
            Debug.Log("Turning ON : Sony TV");
        }
        public void SwitchOff()
        {
            Debug.Log("Turning OFF : Sony TV");
        }

        public void SetChannel(int channelNumber)
        {
            Debug.Log("Setting channel Number " + channelNumber + " on Sony TV");
        }
    }
}