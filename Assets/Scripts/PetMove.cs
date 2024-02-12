using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetMove : MonoBehaviour
{ 
    int k = 0;
    public Transform player;
    private Vector3 offset;
    float speed = 0.4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
            if(transform.position.y >= 2.2){
                k = 1;
            }
            if(k == 1 && (transform.position.y < 2.2 || transform.position.y >= 2.2)){
                
                transform.Translate(Vector3.down * Time.deltaTime * speed);
                    //Debug.Log("I am here");
                if(transform.position.y <= 1.7){
                    k = 0;
                }
            }
            if(transform.position.y < 2.2 && k == 0){
                transform.Translate(Vector3.up * Time.deltaTime * speed);
                
            }
            
            
    }
}
