using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AndroidWrapper : MonoBehaviour
{
    const string CLASS_NAME = "com.example.androidplugin.PluginClass";
    const string ACTIVITY = "com.unity3d.player.UnityPlayerNativeActivity";
    static AndroidJavaClass plugin = new AndroidJavaClass(CLASS_NAME);

    public  InputField firstNum; 
    public  InputField secondNum;

 
    public void Push()
    {
     AndroidJavaClass plugin = new AndroidJavaClass(CLASS_NAME);
        if (plugin != null)
        {
#if UNITY_ANDROID
            plugin.CallStatic("getToast", int.Parse(firstNum.text) + int.Parse(secondNum.text));
#endif
        }
    
    }
}
