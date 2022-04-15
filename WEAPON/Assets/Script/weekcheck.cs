using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;
using System;

public class weekcheck : MonoBehaviour
{

    bool Weekdaycheck;
    public Color checkcolor;

    public GameObject mon;
    public GameObject tue;
    public GameObject wed;
    public GameObject thu;
    public GameObject fri;
    public GameObject sat;
    public GameObject sun;

    int moncheck;
    int tuecheck;
    int wedcheck;
    int thucheck;
    int fricheck;
    int satcheck;
    int suncheck;

    void Start()
    {
        Weekdaycheck = PlayerPrefs.HasKey("FirstJoin");
        //ó�� ���� ����   
        if (!Weekdaycheck)
        {
            Debug.Log("FirstJoin");
            PlayerPrefs.SetInt("FirstJoin", 1);
            PlayerPrefs.SetInt("Monday", 0);
            PlayerPrefs.SetInt("Tuesday", 0);
            PlayerPrefs.SetInt("Wednesday", 0);
            PlayerPrefs.SetInt("Thursday", 0);
            PlayerPrefs.SetInt("Friday", 0);
            PlayerPrefs.SetInt("Saturday", 0);
            PlayerPrefs.SetInt("Sunday", 0);

        }
        else
        {
            moncheck = PlayerPrefs.GetInt("Monday");
            tuecheck = PlayerPrefs.GetInt("Tuesday");
            wedcheck = PlayerPrefs.GetInt("Wednesday");
            thucheck = PlayerPrefs.GetInt("Thursday");
            fricheck = PlayerPrefs.GetInt("Friday");
            satcheck = PlayerPrefs.GetInt("Saturday");
            suncheck = PlayerPrefs.GetInt("Sunday");
        }

        CheckWeek();

    }
    
    void Check()
    {
        Debug.Log("������ ���� ��: "+moncheck + " ȭ: " + tuecheck + " ��: " + wedcheck + " ��: " + thucheck + " ��: " + fricheck + " ��: " + satcheck + " ��: " + suncheck);
        if (moncheck == 1)
            mon.SetActive(true);

        if (tuecheck == 1)
            tue.SetActive(true);

        if (wedcheck == 1)
            wed.SetActive(true);

        if (thucheck == 1)
            thu.SetActive(true);

        if (fricheck == 1)
            fri.SetActive(true);

        if (satcheck == 1)
            sat.SetActive(true);

        if (suncheck == 1)
            sun.SetActive(true);
    }
    void CheckWeek()
    {
        Check();
    }

    
}
