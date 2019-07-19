using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour {

    [SerializeField]
    Button play;
    [SerializeField]
    Button exit;
    [SerializeField]
    Button credits;
    [SerializeField]
    Button howToPlay;
    [SerializeField]
    Button intro;
    [SerializeField]
    Button highScore;
    [SerializeField]
    Animator introAnim;
    [SerializeField]
    Animator santaAnim;    
    [SerializeField]
    Image Logo;
    [SerializeField]
    Image Creditos;
    [SerializeField]
    Button VoltarCreditos;
    [SerializeField]
    Image howtoPlay;
    [SerializeField]
    Button SairHTP;
    [SerializeField]
    Animator introPV;

    public GameObject som1;

    public static bool podeSair;

    private void Start()
    {
        introAnim.GetComponent<Animation>();
        santaAnim.GetComponent<Animation>();
    }

    public void Update()
    {
        if(podeSair == true)
        {
            StartCoroutine(coroutineC());
        }
    }

    public void Intro()
    {
        play.gameObject.SetActive(false);
        credits.gameObject.SetActive(false);
        howToPlay.gameObject.SetActive(false);
        intro.gameObject.SetActive(false);
        highScore.gameObject.SetActive(false);
        exit.gameObject.SetActive(false);        
        Logo.gameObject.SetActive(false);
        santaAnim.gameObject.SetActive(false);
        introAnim.gameObject.SetActive(true);
    }

    public void HowToPlay()
    {
        play.gameObject.SetActive(false);
        credits.gameObject.SetActive(false);
        howToPlay.gameObject.SetActive(false);
        intro.gameObject.SetActive(false);
        highScore.gameObject.SetActive(false);
        exit.gameObject.SetActive(false);
        Logo.gameObject.SetActive(false);
        santaAnim.gameObject.SetActive(false);
        howtoPlay.gameObject.SetActive(true);
        SairHTP.gameObject.SetActive(true);
    }

    public void SairDoHTP()
    {
        play.gameObject.SetActive(true);
        credits.gameObject.SetActive(true);
        howToPlay.gameObject.SetActive(true);
        intro.gameObject.SetActive(true);
        highScore.gameObject.SetActive(true);
        exit.gameObject.SetActive(true);
        Logo.gameObject.SetActive(true);
        santaAnim.gameObject.SetActive(true);
        howtoPlay.gameObject.SetActive(false);
        SairHTP.gameObject.SetActive(false);
    }

    public void creditos()
    {
        play.gameObject.SetActive(false);
        credits.gameObject.SetActive(false);
        howToPlay.gameObject.SetActive(false);
        intro.gameObject.SetActive(false);
        highScore.gameObject.SetActive(false);
        exit.gameObject.SetActive(false);
        Logo.gameObject.SetActive(false);
        santaAnim.gameObject.SetActive(false);
        Creditos.gameObject.SetActive(true);
        VoltarCreditos.gameObject.SetActive(true);
    }

    public void sairCreditos()
    {
        play.gameObject.SetActive(true);
        credits.gameObject.SetActive(true);
        howToPlay.gameObject.SetActive(true);
        intro.gameObject.SetActive(true);
        highScore.gameObject.SetActive(true);
        exit.gameObject.SetActive(true);
        Logo.gameObject.SetActive(true);
        santaAnim.gameObject.SetActive(true);
        Creditos.gameObject.SetActive(false);
        VoltarCreditos.gameObject.SetActive(false);
    }

    public void Play()
    {
        Gift.pontos = 0;
        Gift.scoreF = 0;
        Gift.lifeCount = 0;
        MoveHouse.Speed = 5;
        SpawHouse.spaw = 5;
        // StartCoroutine(coroutineB());
        Santa.jaViu = 0;
        Gift.morreu = false;
        Time.timeScale = 1;
        Santa.contagemCronometro = 60;

        som1.gameObject.SetActive(false);
        play.gameObject.SetActive(false);
        credits.gameObject.SetActive(false);
        howToPlay.gameObject.SetActive(false);
        intro.gameObject.SetActive(false);
        highScore.gameObject.SetActive(false);
        exit.gameObject.SetActive(false);
        Logo.gameObject.SetActive(false);

        podeSair = true;

        if (SavePlayerPrefs.IntroJa < 1)
        {
            introPV.gameObject.SetActive(true);
            StartCoroutine(coroutineA());
            SavePlayerPrefs.IntroJa+= 1;
        }
        else if(SavePlayerPrefs.IntroJa >=1)
        {
            StartCoroutine(coroutineB());
        }
    }

    public void Sair()
    {
        Application.Quit();
    }

    public void LoadHS()
    {
        SceneManager.LoadScene("HighScore");
    }

    public void Voltar()
    {
        SceneManager.LoadScene("Cena1");
    }

    IEnumerator coroutineB()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Jogo");

       
    }

    IEnumerator coroutineA()
    {
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene("Jogo");

    }

    IEnumerator coroutineC()
    {
        yield return new WaitForSeconds(10);
        podeSair = false;

    }
}
