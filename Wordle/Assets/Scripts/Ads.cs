using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Ads : MonoBehaviour
{
    [DllImport("__Internal")]
    public extern static void ShowAdv();
    [DllImport("__Internal")]
    public extern static void ShowRewardedForMoney();
    [DllImport("__Internal")]
    public extern static void ShowRewardedForUnlock();


}
