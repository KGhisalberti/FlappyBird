using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class moveBk : MonoBehaviour{

    public GameObject backGround1;
    public GameObject backGround2;
    public GameObject backGround3;

    private Vector2 movement;

    private Vector3 siz;
    private Vector3 rightTopCameraBorder;
	private Vector3 leftTopCameraBorder;
	private Vector3 rightBottomCameraBorder;
	private Vector3 leftBottomCameraBorder;
    private float positionRestartX;

    void Start(){
        rightTopCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(1,1,0));
		leftTopCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(0,1,0));
		rightBottomCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(1,0,0));
		leftBottomCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(0,0,0));
        positionRestartX = -6f; //sauvegarde la position X du backGround3 (sauf que marche pas du tout si je mets la position de bk 3 ???)
    }

    void Update(){
        siz.x = backGround1.GetComponent<SpriteRenderer>().bounds.size.x;
        siz.y = backGround1.GetComponent<SpriteRenderer>().bounds.size.y;
        movement = new Vector2(3,0);
        backGround1.GetComponent<Rigidbody2D>().velocity = movement;
        backGround2.GetComponent<Rigidbody2D>().velocity = movement;
        backGround3.GetComponent<Rigidbody2D>().velocity = movement;

        if (backGround1.GetComponent<Transform>().position.x > leftBottomCameraBorder.x + (siz.x*2))
            backGround1.GetComponent<Transform>().position = new Vector3(positionRestartX,backGround1.GetComponent<Transform>().position.y,backGround1.GetComponent<Transform>().position.z);
        if (backGround2.GetComponent<Transform>().position.x > leftBottomCameraBorder.x + (siz.x*2))
            backGround2.GetComponent<Transform>().position = new Vector3(positionRestartX,backGround1.GetComponent<Transform>().position.y,backGround1.GetComponent<Transform>().position.z);
        if (backGround3.GetComponent<Transform>().position.x > leftBottomCameraBorder.x + (siz.x*2))
            backGround3.GetComponent<Transform>().position = new Vector3(positionRestartX,backGround1.GetComponent<Transform>().position.y,backGround1.GetComponent<Transform>().position.z);
    }
}

/*public class moveBk : MonoBehaviour{
    // Start is called before the first frame update
    private Vector2 movement;
    private Vector3 siz;
    private Vector3 rightTopCameraBorder;
	private Vector3 leftTopCameraBorder;
	private Vector3 rightBottomCameraBorder;
	private Vector3 leftBottomCameraBorder;
    public float positionRestartX;

    void Start(){
        rightTopCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(1,1,0));
		leftTopCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(0,1,0));
		rightBottomCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(1,0,0));
		leftBottomCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(0,0,0));
    }

    // Update is called once per frame
    void Update(){ 
        movement = new Vector2(3,0);

        positionRestartX = -11.5f;

        GetComponent<Rigidbody2D>().velocity = movement;
        siz.x = gameObject.GetComponent<SpriteRenderer> ().bounds.size.x;
        siz.y = gameObject.GetComponent<SpriteRenderer> ().bounds.size.y;
        // If the backgound exits the screen 
        // Set the X position with the original backGround3 X position
        Debug.Log("Taille : " + siz.x);
        if (transform.position.x > leftBottomCameraBorder.x + (siz.x * 2))
             transform.position = new Vector3(positionRestartX,transform.position.y,transform.position.z);
        
    } 
}*/
