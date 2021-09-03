using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Tiles : MonoBehaviour
{

    public GameManager gameManager;
    public AudioClip hit;
    AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
      source = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider enter){
      gameManager.AddPoint();
      source.PlayOneShot (hit);
    }
}
