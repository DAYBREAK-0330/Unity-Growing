using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;
using System;
using UnityEngine.UI;

public class DAY : MonoBehaviour
{
    public GameObject Text_Day;
    public GameObject Text_Time;
    public Sprite night;
    public Sprite day;
    public Sprite nightday;

    // Start is called before the first frame update
    void Start()
    {
        CultureInfo cultures = CultureInfo.CreateSpecificCulture("ko-KR");
        string date = DateTime.Now.ToString(string.Format("yyyy년 MM월 dd일", cultures));
       
        DayOfWeek week = DateTime.Now.DayOfWeek;
        Text_Day.GetComponent<Text>().text = date;

        //월1,화2,수3,목4,금5,토6,일0
        GameObject CT = GameObject.Find("==UI==/-Ingame/MainSlot/WEEK/"+week);
        CT.GetComponent<Text>().color = new Color(1, 1, 1, 1);

                if(week == DayOfWeek.Monday){
                        PlayerPrefs.SetInt("Monday", 1);
                        PlayerPrefs.SetInt("Tuesday", 0);
                        PlayerPrefs.SetInt("Wednesday", 0);
                        PlayerPrefs.SetInt("Thursday", 0);
                        PlayerPrefs.SetInt("Friday", 0);
                        PlayerPrefs.SetInt("Saturday", 0);
                        PlayerPrefs.SetInt("Sunday", 0);
                }
                else if(week == DayOfWeek.Tuesday){
                         PlayerPrefs.SetInt("Tuesday", 1);
                }
                else if(week == DayOfWeek.Wednesday){
                        PlayerPrefs.SetInt("Wednesday", 1);
                }
                else if(week == DayOfWeek.Thursday){
                        PlayerPrefs.SetInt("Thursday", 1);
                }
                else if(week == DayOfWeek.Friday){
                        PlayerPrefs.SetInt("Friday", 1);
                }
                else if(week == DayOfWeek.Saturday){
                        PlayerPrefs.SetInt("Saturday", 1);
                }
                else if(week == DayOfWeek.Sunday){
                        PlayerPrefs.SetInt("Sunday", 1);
                }
           
            
            



        
    }

    // Update is called once per frame
    void Update()
    {
        CultureInfo cultures = CultureInfo.CreateSpecificCulture("ko-KR");
        string date = DateTime.Now.ToString(string.Format("hh시 mm분 ss초", cultures));
        Text_Time.GetComponent<Text>().text = date;

        int time_H = DateTime.Now.Hour;
        GameObject TIMAGE = GameObject.Find("==UI==/-Ingame/MainSlot/DAY");

        if (time_H == 19 || time_H == 20 || time_H == 21 || time_H == 22 || time_H == 23 || time_H == 0 || time_H == 1)
        {
            TIMAGE.GetComponent<SpriteRenderer>().sprite = night;
        }
        if (time_H == 2 || time_H == 3 || time_H == 4 || time_H == 5)
        {
            TIMAGE.GetComponent<SpriteRenderer>().sprite = nightday;
        }
        if (time_H == 6 || time_H == 7 || time_H == 8 || time_H == 9 || time_H == 10 || time_H == 11 || time_H ==  12 || time_H == 13 || time_H == 14 || time_H == 15)
        {
            TIMAGE.GetComponent<SpriteRenderer>().sprite = day;
        }
        if (time_H == 16 || time_H == 17 || time_H == 18)
        {
            TIMAGE.GetComponent<SpriteRenderer>().sprite = nightday;
        }
    }
}
