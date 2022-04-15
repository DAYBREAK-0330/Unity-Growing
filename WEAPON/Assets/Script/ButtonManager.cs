using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    int ObjectSetA;
    int ObjectSetB;
    int ObjectSetC;
    int ObjectSetD;
    int ObjectSetE;
    int ObjectSetF;

    public GameObject BuiPanel;
    void Start()
    {
        ObjectSetA = PlayerPrefs.GetInt("ObjectA");
        ObjectSetB = PlayerPrefs.GetInt("ObjectB");
        ObjectSetC = PlayerPrefs.GetInt("ObjectC");
        ObjectSetD = PlayerPrefs.GetInt("ObjectD");
        ObjectSetE = PlayerPrefs.GetInt("ObjectE");
        ObjectSetF = PlayerPrefs.GetInt("ObjectF");
    }
    // Start is called before the first frame update
    public void MenuTABAClick()
    {
        Animator animator = GetComponent<Animator>();

        bool isOpen = animator.GetBool("On");

        animator.SetBool("On", !isOpen);
       
    }

    public void ObjectClick()
    {
        BuiPanel.SetActive(true);
    }
    
}
