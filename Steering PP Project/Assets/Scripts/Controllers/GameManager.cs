using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject SeekerAI;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            GameObject AICube = (GameObject)Instantiate(SeekerAI, transform.position, transform.rotation);
            Seek SeekScript = AICube.GetComponent<Seek>();
            SeekScript.target = target;
        }
    }
}
