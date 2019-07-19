using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHouse : MonoBehaviour {

    public static float Speed = 5.5f;
    private ParticleSystem particulas;

    public AudioClip efeito;
    private AudioSource estrelinha;

    void Start()
    {
        particulas = GetComponentInChildren<ParticleSystem>();
        estrelinha = GetComponent<AudioSource>();
    }

    void Update()
    {
        transform.Translate (new Vector2(Speed * Time.deltaTime ,0));
        Destroy(this.gameObject, 10);
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "presente")
        { 
            particulas.Play();
            estrelinha.PlayOneShot(efeito);
        }
    }
}
