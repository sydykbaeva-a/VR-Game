using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float repeatRate = 5.0f;
    private float delayTime = 0.5f;
    public GameObject[] cars;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnManagerCar", delayTime, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnManagerCar(){

        float randCar = Random.Range(0, 10);
        float randCar2 = Random.Range(0, 10);

        if(randCar >= 5){
            Instantiate(cars[0], cars[1].transform.position, cars[1].transform.rotation);
        }else{
            Instantiate(cars[1], cars[1].transform.position, cars[1].transform.rotation);
        }

        if(randCar2 >= 5){
            Instantiate(cars[0], cars[0].transform.position, cars[0].transform.rotation);
        }else{
            Instantiate(cars[1], cars[0].transform.position, cars[0].transform.rotation);
        }
    }
}
