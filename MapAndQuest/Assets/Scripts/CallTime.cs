using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CallTime : MonoBehaviour
{
    public Text text_date;
    public Text text_time;
    public Text text_get;
    public Button button_get;

    private void Start() // init Time UI
    {
        Init_UI();
        Init_Time();
        Invoke("Get_Time", 0.5f);
    }

    private void Init_Time()
    {
        if (IsInvoking("Update_Time")) // To Guard
        {
            CancelInvoke("Update_Time");
        }
        InvokeRepeating("Update_Time", 0, 0.2f); // Time Update
    }
    private void Init_UI() // init UI
    {
        button_get.onClick.RemoveAllListeners();
        button_get.onClick.AddListener(Get_Time);
    }
    private void Update_Time() // Time Update
    {
        string date = DateTime.Now.ToString("yyyy.MM.dd ") + DateTime.Now.DayOfWeek.ToString().ToUpper().Substring(0, 3);
        //or date = DateTime.Now.ToString("yyyy. MM. dd. ddd");
        string time = DateTime.Now.ToString("HH:mm:ss");
        text_date.text = date;
        text_time.text = time;

        

    }
    private void Get_Time() // Time Watch to memo your time
    {
        text_get.text = text_date.text + "\n" + text_time.text;
        
    }
}
