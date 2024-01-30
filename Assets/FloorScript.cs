using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public GameObject floor;

public class FloorScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        makeFloor();
    }
    void makeFloor(){
        Instantiate(floor, transform.position, transform.rotation);
    }
}
