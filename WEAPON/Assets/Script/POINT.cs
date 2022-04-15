 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class POINT : MonoBehaviour
{
    int moneypoint;
    int ppoint;
    //포인트 오브젝트
    public GameObject Money;
    public GameObject Point;

    // Start is called before the first frame update
    void Start()
    { 
        if (!PlayerPrefs.HasKey("money"))
            PlayerPrefs.SetInt("money", 0);

        if (!PlayerPrefs.HasKey("point"))
            PlayerPrefs.SetInt("point", 0);

        Moneyset();
        Pointset();
        Money.GetComponent<Text>().text = moneyformat(moneypoint);
        Point.GetComponent<Text>().text = moneyformat(ppoint);

    }

    void Moneyset()
    {
        moneypoint = PlayerPrefs.GetInt("money");
    }
    void Pointset()
    {
        ppoint = PlayerPrefs.GetInt("point");
    }
    string moneyformat(int m)
    {
        string ms = m.ToString("#,##0");

        return ms;

    }
}
