using UnityEngine;
using System;
using Sirenix.OdinInspector;

namespace BridgeDesignPattern
{
    public class MainController : MonoBehaviour
    {
        [Button]
        public void Test()
        {
            SonyRemoteControl sonyRemoteControl = new SonyRemoteControl(new SonyLedTv());
            sonyRemoteControl.SwitchOn();
            sonyRemoteControl.SetChannel(101);
            sonyRemoteControl.SwitchOff();

            SamsungRemoteControl samsungRemoteControl = new SamsungRemoteControl(new SamsungLedTv());
            samsungRemoteControl.SwitchOn();
            samsungRemoteControl.SetChannel(202);
            samsungRemoteControl.SwitchOff();
        }
    }
}