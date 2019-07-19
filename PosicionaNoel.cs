using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicionaNoel : MonoBehaviour {

    public float posmax; 

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x > posmax)
        {
            transform.Translate(new Vector2(-10 * Time.deltaTime, 0));
        }
    }
}
