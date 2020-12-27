using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePipe : MonoBehaviour {

    private Vector2 movement;
    
    public GameObject pipeUp1;
    public GameObject pipeBot1;

    public GameObject pipeUp2;
    public GameObject pipeBot2;

    public GameObject boxScore1;
    public GameObject boxScore2;

    private float pipeUpOrigin1 = 6;
    private float pipeBotOrigin1 = -6.5f;

    private float pipeUpOrigin2 = 6.5f;
    private float pipeBotOrigin2 = -6;

    private Vector3 rightTopCameraBorder;
	private Vector3 leftTopCameraBorder;
	private Vector3 rightBottomCameraBorder;
	private Vector3 leftBottomCameraBorder;

    private Vector3 siz;
    

    // Start is called before the first frame update
    void Start() {
        rightTopCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(1,1,0));
		leftTopCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(0,1,0));
		rightBottomCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(1,0,0));
		leftBottomCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(0,0,0));
        boxScore1.GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f,0f);
        boxScore2.GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f,0f);

    }

    // Update is called once per frame
    void Update() {
        movement = new Vector2(-3,0);
        pipeUp1.GetComponent<Rigidbody2D>().velocity = movement; //Déplacement du pipe haut de la paire 1
        pipeBot1.GetComponent<Rigidbody2D>().velocity = movement; //Déplacement du pipe bas de la paire 1
        boxScore1.GetComponent<Rigidbody2D>().velocity = movement; //Déplacement de la boite de scoring de la paire 1

        pipeUp2.GetComponent<Rigidbody2D>().velocity = movement; //Déplacement du pipe haut de la paire 2
        pipeBot2.GetComponent<Rigidbody2D>().velocity = movement; //Déplacement du pipe bas de la paire 2
        boxScore2.GetComponent<Rigidbody2D>().velocity = movement; //Déplacement de la boite de scoring de la paire 2

        siz.x = pipeUp1.GetComponent<SpriteRenderer>().bounds.size.x; //Récupération de la taille d'un pipe
        siz.y = pipeBot1.GetComponent<SpriteRenderer>().bounds.size.y; //Suffisant car ils ont la même taille
        
        //Le pipe est sorti de l'écran ? Si oui appel de la méthode moveToRightPipe
        if(pipeUp1.transform.position.x < leftBottomCameraBorder.x - (siz.x / 2))
            moveToRightPipe(pipeUp1,pipeBot1,boxScore1,pipeUpOrigin1,pipeBotOrigin1);
        if(pipeUp2.transform.position.x < leftBottomCameraBorder.x - (siz.x / 2))
            moveToRightPipe(pipeUp2,pipeBot2,boxScore2,pipeUpOrigin2,pipeBotOrigin2);
        
    }

    void moveToRightPipe(GameObject pipeUp,GameObject pipeBot,GameObject boxScore,float pipeUpOrigin,float pipeBotOrigin){
        float randomY = Random.Range(1,4)-2; //tirage aléatoire d'un décalage en Y
        float posX = rightBottomCameraBorder.x + (siz.x / 2); //Calcul du X du bord droite de l'écran
        
        //Calcul du nouvel y en reprenant la position y d'origine du pipe, ici le bottomPipe1
        float posY = pipeUpOrigin + randomY;
        Vector3 tmp = new Vector3(posX,posY,pipeUp.transform.position.z);

        //Affectation de cette nouvelle position au transform du gameObject
        pipeUp.transform.position = tmp;

        //Affectation d'une position X identique à la nouvelle position X du pipe à la boite de scoring
        boxScore.transform.position =  new Vector3(posX,0,boxScore.transform.position.z);

        //idem pour le second pipe
        posY = pipeBotOrigin + randomY;
        tmp = new Vector3(posX,posY,pipeBot.transform.position.z);
        pipeBot.transform.position = new Vector3(posX,posY,pipeBot.transform.position.z);

    }
}
