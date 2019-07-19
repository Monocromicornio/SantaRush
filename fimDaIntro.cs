using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class fimDaIntro : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Time.timeScale = 0.8f;
	}

    public void FimIntro()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Cena1");
    }

    public void Intro()
    {
        Time.timeScale = 1;
    }

}
