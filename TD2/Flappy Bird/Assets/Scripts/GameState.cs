using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour {
    // Start is called before the first frame update

    private static int score = 0;
    private int vie = 5; // vie du joueur
    private AudioSource source;
    
    void Start(){
        source = GetComponent<AudioSource>();
        source.loop = true;
        source.Play();
    }

    // Update is called once per frame
    void Update(){
            GameObject.FindWithTag("scoreLabel").GetComponent<Text>().text = "" + score;
        if(SceneManager.GetActiveScene().name == "scene3-Game")
            GameObject.FindWithTag("lifeLabel").GetComponent<Text>().text = "" + vie;
    }

    public void addScore(){ //incrémente le score
        score++;
    }

    public int getScore(){ //obtenir le score 
        return score;
    }

    public static void resetScore(){ //remet le score à 0
        score = 0;
    }

    public void loseLife(){ //fait perdre un point de vie
        vie--;
        if(vie == 0)
            SceneManager.LoadScene("scene4-EndGame");
    }

    public void death(){ //pour instakill le joueur
        SceneManager.LoadScene("scene4-EndGame");
    }
}
