using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collideManagementBird : MonoBehaviour {

    public GameState gameState;
    
    private Vector3 rightTopCameraBorder;
	  private Vector3 leftTopCameraBorder;
	  private Vector3 rightBottomCameraBorder;
	  private Vector3 leftBottomCameraBorder;

    private Transform bird;
    private Vector3 siz;

    // Start is called before the first frame update
    void Start() {
      rightTopCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(1,1,0));
		  leftTopCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(0,1,0));
		  rightBottomCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(1,0,0));
		  leftBottomCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(0,0,0));
      bird = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update() {
      siz.x = GetComponent<SpriteRenderer>().bounds.size.x; //Récupération de la taille de l'oiseau
      siz.y = GetComponent<SpriteRenderer>().bounds.size.y;
      if(bird.position.y < leftBottomCameraBorder.y - (siz.y / 2))
        gameState.death();
    }

    void OnTriggerEnter2D(Collider2D collider){
		if (collider.name == "Pipe1Up" || collider.name == "Pipe2Up" || collider.name == "Pipe1Bot" || collider.name == "Pipe2Bot"){ // Si le joueur touche un tuyau il perd une vie
			gameState.loseLife();
		}
		if (collider.name == "Box1" || collider.name == "Box2"){ //Si le joueur touche la zone de point il marque un point
			gameState.addScore();
		}

	}
}
