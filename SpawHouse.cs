using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawHouse : MonoBehaviour {

    public float timer;
    public GameObject[] casa;
    public float Speed;
    public static float spaw = 5;    
    void Start()
    {

    }

    void Update()
    {
        int rnd = Random.Range(0, casa.Length);
        if (rnd == casa.Length)
        {
            rnd = 0;
        }
        timer += Speed * Time.deltaTime;
        if (timer > spaw)
        {
            timer = 0;
            GameObject clone;
            clone = Instantiate(casa[rnd], casa[rnd].transform.position, casa[rnd].transform.rotation);
            
        }
    }
}
