using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    static Text text;
    void Start()
    {
        text = GetComponent<Text>();
    }

    public static void Update_UI(string passed_message)
    {
        text.text = passed_message;
    }
}
