using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMove : MonoBehaviour
{ 
    int k = 0;
    float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
            if(transform.position.y >= 25){
                k = 1;
            }
            if(k == 1 && (transform.position.y < 25 || transform.position.y >= 25)){
                
                transform.Translate(Vector3.down * Time.deltaTime * speed);
                    //Debug.Log("I am here");
                if(transform.position.y <= 7){
                    k = 0;
                }
            }
            if(transform.position.y < 25 && k == 0){
                transform.Translate(Vector3.up * Time.deltaTime * speed);
                
            }
            
            
    }
}
