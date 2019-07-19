using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour {

    public float Vel;
    public float StartX;
    public float EndX;

    void Start()
    {
      
    }

    void Update()
    {
        transform.Translate(new Vector2(Vel, 0) * Time.deltaTime);
        if(transform.position.x > EndX)
        {
            transform.position = new Vector2(StartX, this.transform.position.y);
        }
        
    }
}
