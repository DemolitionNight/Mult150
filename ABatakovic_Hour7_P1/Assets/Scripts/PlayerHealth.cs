using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float health = 1004f;
        float poisonDamange = 125.5f;

        Debug.Log(health);

        health -= poisonDamange;

        Debug.Log(health);

        health -= poisonDamange;

        Debug.Log(health);

        health -= poisonDamange;

        Debug.Log(health);

        health -= poisonDamange;

        Debug.Log(health);

        health -= poisonDamange;

        Debug.Log(health);

        health -= poisonDamange;

        Debug.Log(health);

        health -= poisonDamange;

        Debug.Log(health);

        health -= poisonDamange;

        Debug.Log(health);

        Debug.Log("Player has been unalived!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
