using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getName : MonoBehaviour
{
    public static string playerNameStr;

    public Text playerNameTxt;

    private void Start()
    {
        PlayerPrefs.GetString(name);
    }
}
