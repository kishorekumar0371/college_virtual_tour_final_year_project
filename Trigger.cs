using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{   
    AudioSource audiosource;
    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name + "has entered the cube");
        audiosource.Play();
    }
    private void OnTriggerStay(Collider other)
    {
        print(other.gameObject.name + "has still in the cube");
    }
    private void OnTriggerExit(Collider other)
    {
        print(other.gameObject.name + "has exit the cube");
        audiosource.Stop();
    }
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
