using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveMenu : MonoBehaviour{
    // Start is called before the first frame update
    private Transform title;
    void Start(){
        title = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update(){
        title.position= new Vector3(0,Mathf.Lerp(1f,2f,Mathf.PingPong(Time.time, 1)),0);
    }
}
