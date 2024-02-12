using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public ParticleSystem starParticle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.tag == "Coin"){
            transform.Rotate(0, 0, 20 * Time.deltaTime);
        }else{
            //transform.Rotate(0, 15 * Time.deltaTime, 0);
        }
        
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            starParticle.transform.position = gameObject.transform.position;
            starParticle.Play();
            Destroy(gameObject);
        }
    }
}
