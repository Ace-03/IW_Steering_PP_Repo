using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ShipAI;

    //public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject AICube = GameObject.Instantiate(ShipAI);
            AICube.transform.position = transform.position;
        }
    }
    
}
