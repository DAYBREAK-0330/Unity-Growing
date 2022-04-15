using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanData : MonoBehaviour
{
    //1. 식물 이름
    //2. 식물 레벨
    //3. 식물 경험치
    //4. 식물 체력
    //5. 식물 수분량

    public string code;
    public int num;
    public string Name;
    public int Level;
    public int maxexp;
    public int exp;
    public int health;
    public int water;
    public int time;

    void Start()
    {
        if(PlayerPrefs.HasKey("Object" + code)){
            if(PlayerPrefs.GetInt("Object" + code) == 1){
                setexp();
                num = PlayerPrefs.GetInt("Object" + code + "num");
                Level = PlayerPrefs.GetInt("Object" + code + "Level");
                exp = PlayerPrefs.GetInt("Object" + code + "exp");
                health = PlayerPrefs.GetInt("Object" + code + "health");
                water = PlayerPrefs.GetInt("Object" + code + "water");
                time = PlayerPrefs.GetInt("Object" + code + "time");
            }
        }

    }

    public void setdata(int nu, string n, int l, int e, int h, int w, int t){
        num = nu;
        Name = n;
        Level = l;
        exp = e;
        health = h;
        water = w;
        time = t;
    }
    
    public void getlevel(string code)
    {
        Level = PlayerPrefs.GetInt("Object"+code+"Level");
    }
    public void setexp()
    {
        maxexp = ((Level * 2) + 5) * 9;
    }
}
