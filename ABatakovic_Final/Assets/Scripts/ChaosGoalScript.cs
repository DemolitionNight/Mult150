using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaosGoalScript : MonoBehaviour
{
    //Acess Chaos Balls for the script
    public GameObject one, two, three, four, five;

    public bool isSolved = false;
    void OnTriggerEnter(Collider collider)
    {
        GameObject collidedWith = collider.gameObject;
        if (collidedWith.tag == gameObject.tag)
        {
            Destroy(collidedWith);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If all choas balls are destroyed the chaos script is solved
        if (one==null && two==null && three==null && four==null && five==null)
        {
            isSolved = true;
            GetComponent<Light>().enabled = false;
        }
    }
}
