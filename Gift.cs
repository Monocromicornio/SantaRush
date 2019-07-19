using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class Gift : MonoBehaviour
{

    public Text HS;

    public static float pontos;

    public static float scoreF;

    public static float highscore;

    public static Image life1;
    public static Image life2;
    public static Image life3;

    public static Image[] lifes = new Image[3];

    public static bool morreu = false;

    public static int lifeCount;

    public static float speed = 10;

    private Rigidbody2D rb;

    [SerializeField]
    bool Ok = false;
    [SerializeField]
    bool Ok2 = false;


    // Use this for initialization
    void Start()
    {
        

        for(int i=0; i<lifes.Length; i++)
        {
            lifes[i] = GameObject.Find("Life" + (i+1).ToString()).GetComponentInChildren<Image>();
            print(lifes[i].name);
        }
        
        HS = GameObject.Find("Score").GetComponentInChildren<Text>();             

        rb = GetComponent<Rigidbody2D>();

        rb.AddForce(new Vector2(0, 200));
        rb.AddForce(new Vector2(100, 0));

        

    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Rotate(0, 0, Random.Range(360, 0) * Time.deltaTime);

        Destroy(this.gameObject, 4);

        scoreF = pontos;
    }

    public void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.gameObject.tag == "casa" && !Ok2)
        {
            Ok2 = true;
            rb.gravityScale = 0;

            if (pontos < 9)
            {
                pontos += 1;
                HS.text = "00" + pontos.ToString();

            }
            else if (pontos >= 9 && pontos < 100)
            {
                pontos += 1;
                HS.text = "0" + pontos.ToString();
            }
            else
            {
                pontos += 1;
                HS.text = pontos.ToString();
            }

            Destroy(gameObject, 1);
        }



        if (hit.gameObject.tag == "casaFumaca" && !Ok || hit.gameObject.tag == "Errou" && !Ok)
        {
            Ok = true;
            rb.gravityScale = 1;

            lifes[lifeCount].color = new Color(255, 0, 0);
            lifeCount += 1;

            if (lifeCount == 3)
            {
                morreu = true;
                Time.timeScale = 0;
                Destroy(this.gameObject);
            }
           

            //print("perdeuVida1");

            /* if (lifeCount > 2)
             {
                 life2.color = new Color(255, 0, 0);
                 lifeCount += 1;                
             }
             if (lifeCount > 4)
             {
                 life3.color = new Color(255, 0, 0);                
                 morreu = true;
                 Time.timeScale = 0;
                 Destroy(this.gameObject);

             }*/
            Destroy(gameObject, 1); 
        }


    }

    

    private void OnTriggerStay2D(Collider2D hit)
    {
        if (hit.gameObject.tag == "casa")
        {
            Transform chamine = hit.transform.GetChild(0);
            transform.position = Vector3.MoveTowards(transform.position, chamine.position, speed * Time.deltaTime);
        }
        if (hit.gameObject.tag == "casaFumaca")
        {
            Transform chamine = hit.transform.GetChild(0);
            transform.position = Vector3.MoveTowards(transform.position, chamine.position, speed * Time.deltaTime);
        }
        if(hit.gameObject.tag == "chamine")
        {
            Destroy(gameObject);
        }
    }

}
