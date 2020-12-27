using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour{
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        Invoke("goScene2",3.0f);

    }

    void goScene2(){
        SceneManager.LoadScene("Scene2-Menu");
    }
}
