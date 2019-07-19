using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSantaAnim : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Menu.podeSair == true)
        {
            transform.Translate (new Vector2(-10 * Time.deltaTime, 0));
        }
	}
}
