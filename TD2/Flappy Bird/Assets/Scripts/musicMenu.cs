using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicMenu : MonoBehaviour{
    // Start is called before the first frame update

    private AudioSource source;

    void Start(){
        source = GetComponent<AudioSource>();
        source.loop = true;
        source.Play();
    }

    // Update is called once per frame
    void Update(){
        
    }
}
