using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;


public class Santa : MonoBehaviour {

    public Animator jogar;
    public GameObject presente;
    public Transform sairDaqui;
    public Text cronometro;
    
    public Button verAd;
    public Button irMenu;

    public static float jaViu = 0;
    public static float contagemCronometro = 60;
	
	void Start () {
        jogar.SetBool("Jogando", false);
    }
	
	// Update is called once per frame
	void Update () {

       /* if(transform.position.x > -2.75f)
        {
            transform.Translate(new Vector2(-10 * Time.deltaTime, 0));
        }*/

        if(Input.mousePosition.x > 300)
        {
            if (Input.GetMouseButtonDown(0))
            {
                jogar.SetBool("Jogando", true);
                //StartCoroutine(jogarP());
            }
            else
            {
                jogar.SetBool("Jogando", false);
            }
        }        

        if(contagemCronometro > 0)
        {
            contagemCronometro -= Time.deltaTime / Time.timeScale ;
            cronometro.text = Mathf.FloorToInt (contagemCronometro).ToString();
        }

        if (contagemCronometro <=0 && jaViu <1)
        {
            verAd.gameObject.SetActive(true);
            irMenu.gameObject.SetActive(true);
            print("DEU ERRO NESSE KCT");
        }
        if(contagemCronometro <=0 && jaViu>=1)
        {
            SceneManager.LoadScene("gameOver");
        }
       
        if (Gift.morreu == true && jaViu <1)
            {
                verAd.gameObject.SetActive(true);
                irMenu.gameObject.SetActive(true);
            }
        else if(contagemCronometro >0)
            {
            verAd.gameObject.SetActive(false);
            irMenu.gameObject.SetActive(false);
        }

        if (Gift.morreu == true && jaViu >= 1)
        {
            SceneManager.LoadScene("gameOver");
            jaViu = 0;
        }

       
    }

    IEnumerator jogarP()
    {
        yield return new WaitForSeconds(0.5f);
    }

    public void JogaPresente()
    {
        GameObject Clone = Instantiate(presente, sairDaqui.transform.position, Quaternion.identity);
        Clone.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }

    //Velocidades
    #region
    public void Vel1()
    {
        if(Gift.morreu == false)
        Time.timeScale = 1;
    }

    public void Vel2()
    {
        if (Gift.morreu == false)
            Time.timeScale = 1.5f;
    }

    public void Vel3()
    {
        if (Gift.morreu == false)
            Time.timeScale = 2;
    }

    public void Vel4()
    {
        if (Gift.morreu == false)
            Time.timeScale = 2.5f;
    }

    public void Vel5()
    {
        if (Gift.morreu == false)
            Time.timeScale = 3;
    }

    public void Vel6()
    {
        if (Gift.morreu == false)
            Time.timeScale = 3.5f;
    }

    public void Vel7()
    {
        if (Gift.morreu == false)
            Time.timeScale = 4;
    }

    public void Vel8()
    {
        if (Gift.morreu == false)
            Time.timeScale = 4.5f;
    }

    public void Vel9()
    {
        if (Gift.morreu == false)
            Time.timeScale = 5;
    }

    public void Vel10()
    {
        if (Gift.morreu == false)
            Time.timeScale = 5.5f;
    }
#endregion
}