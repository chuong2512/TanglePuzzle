using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RateGameBtn : MonoBehaviour
{
    
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnRateGameClick);
    }
    
    void OnRateGameClick()
    {
    #if UNITY_ANDROID
        Application.OpenURL("market://details?id=" + Application.identifier);
    #elif UNITY_IOS
        Application.OpenURL("itms-apps://itunes.apple.com/app/id" + Application.identifier);
    #endif
    }
}
