using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchAction : MonoBehaviour {

    private Rigidbody2D rb;
	private Vector3 rightTopCameraBorder;
	private Vector3 leftTopCameraBorder;
	private Vector3 rightBottomCameraBorder;
	private Vector3 leftBottomCameraBorder;
    private AudioSource source;

    private Vector3 siz;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        source = GetComponent<AudioSource>();
        rightTopCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(1,1,0));
		leftTopCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(0,1,0));
		rightBottomCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(1,0,0));
		leftBottomCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(0,0,0));
        siz.x = GetComponent<SpriteRenderer>().bounds.size.x;
        siz.y = GetComponent<SpriteRenderer>().bounds.size.y;
    }

    // Update is called once per frame
    void Update() {
        float inputY = Input.GetAxis("Vertical");
        float inputX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(0,0);

        if(Input.touchCount == 0){ // si le jouer ne touche pas l'écran
            if(rb.gravityScale < 20) //augmentation de la gravité plus forte qu'on appuie pas sur l'écran
                rb.gravityScale = rb.gravityScale + 0.5f;

        } else if(Input.touchCount > 0){ //si le joueur touche l'écran
            Touch touch = Input.GetTouch(0);
            Vector3 touch_Pos = Camera.main.ScreenToWorldPoint(touch.position);

            rb.velocity = new Vector2(0,8f); //force du jump
            source.Play();
            rb.gravityScale = 1; //réinitialisation de la gravité à 1

            if(touch_Pos.x < 0){   /*move right*/
                rb.velocity = new Vector2(-5,rb.velocity.y);
            }

            if(touch_Pos.x > 0){  /*move left*/
                rb.velocity = new Vector2(5,rb.velocity.y);
            }
        }

        /*vérification de la bordure supérieur*/
		if(transform.position.y > leftTopCameraBorder.y-(siz.y/2))
			gameObject.transform.position = new Vector3(transform.position.x,leftTopCameraBorder.y-(siz.y/2),transform.position.z);

        if(transform.position.x > rightBottomCameraBorder.x-(siz.x/2))
			gameObject.transform.position = new Vector3(rightBottomCameraBorder.x-(siz.x/2),transform.position.y,transform.position.z);
		
		if(transform.position.x < leftBottomCameraBorder.x+(siz.x/2))
			gameObject.transform.position = new Vector3(leftBottomCameraBorder.x+(siz.x/2),transform.position.y,transform.position.z);
    }
}
