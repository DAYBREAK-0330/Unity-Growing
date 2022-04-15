using UnityEngine;
using UnityEngine.UI;
public class PanelManager : MonoBehaviour
{
    void Start()
    {
        if (PlayerPrefs.HasKey("ObjectA"))
        {   
            if(PlayerPrefs.GetInt("ObjectA")==1){
                GameObject OA = GameObject.Find("==UI==/-Ingame/MainLong/A/Button/Text");
                OA.GetComponent<Text>().text = "상태확인";
                GameObject Plan = GameObject.Find("PlanObject/" + PlayerPrefs.GetInt("ObjectAnum"));
                GameObject.Find("==UI==/==OBJECTA==/Plan").GetComponent<MeshFilter>().mesh = Plan.GetComponent<MeshFilter>().mesh;
                GameObject.Find("==UI==/==OBJECTA==/Plan").GetComponent<MeshRenderer>().material = Plan.GetComponent<MeshRenderer>().material;
            }
            else{
                PlayerPrefs.SetInt("ObjectA",0);
            }
        }

        if (PlayerPrefs.HasKey("ObjectB"))
        {   
            if(PlayerPrefs.GetInt("ObjectB")==1){
                GameObject OA = GameObject.Find("==UI==/-Ingame/MainLong/B/Button/Text");
                OA.GetComponent<Text>().text = "상태확인";
                GameObject Plan = GameObject.Find("PlanObject/" + PlayerPrefs.GetInt("ObjectBnum"));
                GameObject.Find("==UI==/==OBJECTB==/Plan").GetComponent<MeshFilter>().mesh = Plan.GetComponent<MeshFilter>().mesh;
                GameObject.Find("==UI==/==OBJECTB==/Plan").GetComponent<MeshRenderer>().material = Plan.GetComponent<MeshRenderer>().material;
            }
            else{
                PlayerPrefs.SetInt("ObjectB",0);
            }
        }

        if (PlayerPrefs.HasKey("ObjectC"))
        {   
            if(PlayerPrefs.GetInt("ObjectC")==1){
                GameObject OA = GameObject.Find("==UI==/-Ingame/MainLong/C/Button/Text");
                OA.GetComponent<Text>().text = "상태확인";
                GameObject Plan = GameObject.Find("PlanObject/" + PlayerPrefs.GetInt("ObjectCnum"));
                GameObject.Find("==UI==/==OBJECTC==/Plan").GetComponent<MeshFilter>().mesh = Plan.GetComponent<MeshFilter>().mesh;
                GameObject.Find("==UI==/==OBJECTC==/Plan").GetComponent<MeshRenderer>().material = Plan.GetComponent<MeshRenderer>().material;
            }
            else{
                PlayerPrefs.SetInt("ObjectC",0);
            }
        }

        if (PlayerPrefs.HasKey("ObjectD"))
        {   
            if(PlayerPrefs.GetInt("ObjectD")==1){
                GameObject OA = GameObject.Find("==UI==/-Ingame/MainLong/D/Button/Text");
                OA.GetComponent<Text>().text = "상태확인";
                GameObject Plan = GameObject.Find("PlanObject/" + PlayerPrefs.GetInt("ObjectDnum"));
                GameObject.Find("==UI==/==OBJECTD==/Plan").GetComponent<MeshFilter>().mesh = Plan.GetComponent<MeshFilter>().mesh;
                GameObject.Find("==UI==/==OBJECTD==/Plan").GetComponent<MeshRenderer>().material = Plan.GetComponent<MeshRenderer>().material;
            }
            else{
                PlayerPrefs.SetInt("ObjectD",0);
            }
        }

        if (PlayerPrefs.HasKey("ObjectE"))
        {   
            if(PlayerPrefs.GetInt("ObjectE")==1){
                GameObject OA = GameObject.Find("==UI==/-Ingame/MainLong/E/Button/Text");
                OA.GetComponent<Text>().text = "상태확인";
                GameObject Plan = GameObject.Find("PlanObject/" + PlayerPrefs.GetInt("ObjectEnum"));
                GameObject.Find("==UI==/==OBJECTE==/Plan").GetComponent<MeshFilter>().mesh = Plan.GetComponent<MeshFilter>().mesh;
                GameObject.Find("==UI==/==OBJECTE==/Plan").GetComponent<MeshRenderer>().material = Plan.GetComponent<MeshRenderer>().material;
            }
            else{
                PlayerPrefs.SetInt("ObjectE",0);
            }
        }

        if (PlayerPrefs.HasKey("ObjectF"))
        {   
            if(PlayerPrefs.GetInt("ObjectF")==1){
                GameObject OA = GameObject.Find("==UI==/-Ingame/MainLong/F/Button/Text");
                OA.GetComponent<Text>().text = "상태확인";
                GameObject Plan = GameObject.Find("PlanObject/" + PlayerPrefs.GetInt("ObjectFnum"));
                GameObject.Find("==UI==/==OBJECTF==/Plan").GetComponent<MeshFilter>().mesh = Plan.GetComponent<MeshFilter>().mesh;
                GameObject.Find("==UI==/==OBJECTF==/Plan").GetComponent<MeshRenderer>().material = Plan.GetComponent<MeshRenderer>().material;
            }
            else{
                PlayerPrefs.SetInt("ObjectF",0);
            }
        }


    }

}
