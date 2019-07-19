using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acertou : MonoBehaviour {

    public GameObject estrela;

    
    // Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "presente")
        {
            Instantiate(estrela, new Vector3( this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
          
        }
    }
}
