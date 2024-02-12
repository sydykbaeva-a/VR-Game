using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideToSide : MonoBehaviour
{ 
    int k = 0;
    public float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
            if(transform.position.x >= 4){
                k = 1;
            }
            if(k == 1 && (transform.position.x < 4 || transform.position.x >= 4)){
                
                transform.Translate(Vector3.left * Time.deltaTime * speed);
                if(transform.position.x <= -4){
                    k = 0;
                }
            }
            if(transform.position.x < 4 && k == 0){
                transform.Translate(Vector3.right * Time.deltaTime * speed);
                
            }
            
            
    }
}
