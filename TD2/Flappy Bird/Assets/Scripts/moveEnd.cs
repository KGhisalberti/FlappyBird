using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveEnd : MonoBehaviour{
    // Start is called before the first frame update
    public GameObject tapLeft;
    public GameObject tapRight;
    public GameObject doigT;
    public GameObject gameOver;

    void Start(){
    }

    // Update is called once per frame
    void Update(){
        gameOver.GetComponent<Transform>().position= new Vector3(0,Mathf.Lerp(1f,2f,Mathf.PingPong(Time.time, 1)),0);
        tapLeft.GetComponent<Transform>().position= new Vector3(Mathf.Lerp(-1.5f,-0.5f,Mathf.PingPong(Time.time, 1)),tapLeft.GetComponent<Transform>().position.y,0);
        tapRight.GetComponent<Transform>().position= new Vector3(Mathf.Lerp(1.5f,0.5f,Mathf.PingPong(Time.time, 1)),tapLeft.GetComponent<Transform>().position.y,0);
        doigT.GetComponent<Transform>().position= new Vector3(0,Mathf.Lerp(-1.5f,-0.5f,Mathf.PingPong(Time.time, 1)),0);
    }
}
