using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class ADMenager : MonoBehaviour {

    public void Start()
    {
        //Advertisement.Initialize("27918129-faf6-4d6a-878b-fc33927c5679");
    }

   /* public void ShowRewardedVideo()
    {
        ShowOptions options = new ShowOptions();
        options.resultCallback = HandleShowResult;

        Advertisement.Show("rewardedVideo", options);
    }

    void HandleShowResult(ShowResult result)
    {
        if (result == ShowResult.Finished)
        {
            Debug.Log("Video completed - Offer a reward to the player");
            Santa.contagemCronometro = 60;
            Santa.jaViu++;
            Reset();
        }
        else if (result == ShowResult.Skipped)
        {
            Debug.LogWarning("Video was skipped - Do NOT reward the player");
        }
        else if (result == ShowResult.Failed)
        {
            Debug.LogError("Video failed to show");
        }
    }
    */
    public void SairMenu()
    {
        SceneManager.LoadScene("gameOver");
    }

    private void Reset()
    {
        Gift.lifeCount = 0;       
        Time.timeScale = 1;
        Gift.morreu = false;

        for (int i = 0; i < Gift.lifes.Length; i++)
        {
            Gift.lifes[i].color = new Color(255, 255, 255);
            
        }

    }
}
