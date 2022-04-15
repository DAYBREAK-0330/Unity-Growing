using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loading : MonoBehaviour
{
    float time;
    public GameObject InGame;
    void Update()
    {

        GetComponent<Image>().color = new Color(0, 0, 0, 1 - time);


        if (time > 1f)
        {
            InGame.SetActive(false);
        }

        time += Time.deltaTime;

    }
}
