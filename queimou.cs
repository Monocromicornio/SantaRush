using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class queimou : MonoBehaviour {

    public AudioClip queimar;
    private AudioSource burn;

    private Animator fogo;
    // Use this for initialization
    void Start () {
        fogo = GetComponent<Animator>();
        burn = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() {
      
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "presente")
        {
            fogo.SetBool("hitou", true);
            burn.PlayOneShot(queimar);
        }
       
    }
}