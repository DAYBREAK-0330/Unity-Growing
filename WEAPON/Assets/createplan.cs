using UnityEngine;
using UnityEngine.UI;

public class createplan : MonoBehaviour
{
    public string code;
    
    int num;
    string Name;
    int Level;
    int maxexp;
    int exp;
    int health;
    int water;
    int time;
    // 랜덤 최대 값
    int maxvalue = 1;

    //식물 생성
    public void Create()
    {
         PlayerPrefs.SetInt("Object" + code, 1);
        int value = Random.Range(1, maxvalue + 1);
        GameObject Plan = GameObject.Find("PlanObject/" + value);
        num = value;
        Name =  GameObject.Find("PlanObject/"+value).GetComponent<PlanData>().Name;
        Level = GameObject.Find("PlanObject/"+value).GetComponent<PlanData>().Level;
        maxexp = GameObject.Find("PlanObject/"+value).GetComponent<PlanData>().maxexp;
        exp = GameObject.Find("PlanObject/"+value).GetComponent<PlanData>().exp;
        health = GameObject.Find("PlanObject/"+value).GetComponent<PlanData>().health;
        water = GameObject.Find("PlanObject/"+value).GetComponent<PlanData>().water;
        time = GameObject.Find("PlanObject/"+value).GetComponent<PlanData>().time;

        PlayerPrefs.SetString("Object" + code + "name", Name);
        PlayerPrefs.SetInt("Object" + code + "num", num);
        PlayerPrefs.SetInt("Object" + code + "Level", Level);
        PlayerPrefs.SetInt("Object" + code + "maxexp", maxexp);
        PlayerPrefs.SetInt("Object" + code + "exp", exp);
        PlayerPrefs.SetInt("Object" + code + "health", health);
        PlayerPrefs.SetInt("Object" + code + "water", water);
        PlayerPrefs.SetInt("Object" + code + "time", time);
        GameObject OA = GameObject.Find("==UI==/-Ingame/MainLong/"+code+"/Button/Text");
        OA.GetComponent<Text>().text = "상태확인";
        updateplan(Plan);
    }


    //식물 삭제    
    public void delete(){
        PlayerPrefs.SetInt("Object" + code, 0);
        PlayerPrefs.DeleteKey("Object" + code + "name");
        PlayerPrefs.DeleteKey("Object" + code + "Level");
        PlayerPrefs.DeleteKey("Object" + code + "maxexp");
        PlayerPrefs.DeleteKey("Object" + code + "exp");
        PlayerPrefs.DeleteKey("Object" + code + "health");
        PlayerPrefs.DeleteKey("Object" + code + "water");
        PlayerPrefs.DeleteKey("Object" + code + "time");
        GameObject OA = GameObject.Find("==UI==/-Ingame/MainLong/"+code+"/Button/Text");
        OA.GetComponent<Text>().text = "씨앗심기";
        GameObject Plan = GameObject.Find("PlanObject/Default");
        updateplan(Plan);
    }

    //식물 업데이트
    public void updateplan(GameObject go){
        GameObject.Find("==UI==/==OBJECT"  +code + "==/Plan").GetComponent<MeshFilter>().mesh = go.GetComponent<MeshFilter>().mesh;
        GameObject.Find("==UI==/==OBJECT" + code + "==/Plan").GetComponent<MeshRenderer>().material = go.GetComponent<MeshRenderer>().material;
    }    

    //Gui Open
    public void OpenGui(){
        if(PlayerPrefs.GetInt("Object" + code)==1){
            GameObject BACKUI =  GameObject.Find("==UI==/-Ingame/MainLong/BUI");
            BACKUI.SetActive(true);
            GUISET();
        }else{
            Create();
        }
    }

    //GUI EDITOR
    public void GUISET(){
        if(PlayerPrefs.GetInt("Object" + code + "Level")==3)
        {
            GameObject BTN = GameObject.Find("==UI==/-Ingame/MainLong/BUI/button_hover_b");
            BTN.SetActive(true);
        }else
        {
            GameObject BTN = GameObject.Find("==UI==/-Ingame/MainLong/BUI/button_hover_b");
            GameObject BTN2 = GameObject.Find("==UI==/-Ingame/MainLong/BUI/button_hover_b (1)");
            BTN.SetActive(false);
        }
        GameObject Model = GameObject.Find("==UI==/-Ingame/MainLong/BUI/BackGround/Image/GameObject");
        Model.GetComponent<RawImage>().texture = Resources.Load<Texture>("Model-"+ code);
        GameObject PLANNAME =  GameObject.Find("==UI==/-Ingame/MainLong/BUI/Plan_Name");
        GameObject ExpText = GameObject.Find("==UI==/-Ingame/MainLong/BUI/Bar/EXPText");
        GameObject ExpBar = GameObject.Find("==UI==/-Ingame/MainLong/BUI/Bar/expslider");
        GameObject WaterText = GameObject.Find("==UI==/-Ingame/MainLong/BUI/Bar/WATERText");
        GameObject WaterBar = GameObject.Find("==UI==/-Ingame/MainLong/BUI/Bar/waterslider");
   
 

        PLANNAME.GetComponent<Text>().text = PlayerPrefs.GetString("Object" + code + "name");
        int exptext = PlayerPrefs.GetInt("Object" + code + "exp");
        int maxexptext = PlayerPrefs.GetInt("Object" + code + "maxexp");
        int watertext = PlayerPrefs.GetInt("Object" + code + "water");

        ExpBar.GetComponent<Slider>().maxValue = maxexptext;
        ExpBar.GetComponent<Slider>().value = exptext;
        WaterBar.GetComponent<Slider>().value = watertext;

        ExpText.GetComponent<Text>().text = "경험치 ("+ exptext +" / "+ maxexptext+")";
        WaterText.GetComponent<Text>().text = "수분량 ("+watertext+")";
    }
}
