using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneMenager : MonoBehaviour {

    public Text scoreFinal;

    private void Update()
    {
        if(Gift.scoreF < 9)
        {
            scoreFinal.text = "00" + Gift.scoreF.ToString();
        }
        else if (Gift.scoreF >=9 && Gift.scoreF < 100)
        {
            scoreFinal.text = "0" + Gift.scoreF.ToString();
        }
        else
        {
            scoreFinal.text = Gift.scoreF.ToString();
        }

    }

    public void loadMenu()
    {
        SceneManager.LoadScene("Cena1");
        Time.timeScale = 1;
    }

    public void loadPlayAgain()
    {
        Gift.pontos = 0;
        Gift.scoreF = 0;
        Gift.lifeCount = 0;
        MoveHouse.Speed = 5;
        SpawHouse.spaw = 5;
        SceneManager.LoadScene("Jogo");
        Time.timeScale = 1;
        Santa.jaViu = 0;
        Gift.morreu = false;
        Santa.contagemCronometro = 60;
    }

    

}
