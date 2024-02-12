using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour
{ 
    int k = 0;
    public float speed = 3.0f;
    public float y1;
    public float y2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
            if(transform.position.y >= y1){ //10
                k = 1;
            }
            if(k == 1 && (transform.position.y < y1 || transform.position.y >= y1)){
                
                transform.Translate(Vector3.down * Time.deltaTime * speed);
                if(transform.position.y <= y2){
                    k = 0;
                }
            }
            if(transform.position.y < y1 && k == 0){
                transform.Translate(Vector3.up * Time.deltaTime * speed);
                
            }
            
            
    }
}
