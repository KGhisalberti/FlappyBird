using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class moveLoading : MonoBehaviour{

    public GameObject loadText;
    
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        loadText.GetComponent<RectTransform>().anchoredPosition = new Vector2(0,Mathf.Lerp(0f,50f,Mathf.PingPong(Time.time, 1f)));
    }
}
