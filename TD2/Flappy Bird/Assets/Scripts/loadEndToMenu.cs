using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadEndToMenu : MonoBehaviour{

    public GameState gameState;
    

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        if(Input.touchCount > 0){
            if(Input.touches[0].tapCount==2){
                GameState.resetScore();
                SceneManager.LoadScene("scene1-Loading");
            }
        }
        
    }
}
