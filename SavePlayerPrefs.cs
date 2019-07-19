using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SavePlayerPrefs : MonoBehaviour {

    public static Text HS;
    public static float IntroJa = 0;

	void Start () {
        HS = GetComponent<Text>();
        print(Gift.highscore);
        ShowHS();
    }	
	
	void Update () {
        if(Gift.highscore < 9)
        {
            HS.text = "00" + Gift.highscore.ToString();
        }else if(Gift.highscore >=9 && Gift.highscore < 100)
        {
            HS.text = "0" + Gift.highscore.ToString();
        }
        else
        {
            HS.text = Gift.highscore.ToString();
        }

        PlayerPrefs.SetFloat("PodeIntro", IntroJa);
        PlayerPrefs.Save();
    }

    public static void ShowHS()
    {
        if (PlayerPrefs.HasKey("HighScore")) Gift.highscore = PlayerPrefs.GetFloat("HighScore");

        if(Gift.scoreF > Gift.highscore || Gift.highscore == 0)
        {
            Gift.highscore = Gift.scoreF;
        }
        
        PlayerPrefs.SetFloat("HighScore", Gift.highscore);
        PlayerPrefs.Save();

        print("QualquerBosta");
    }

}
