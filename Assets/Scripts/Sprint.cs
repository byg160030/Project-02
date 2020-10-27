using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sprint : MonoBehaviour
{
    PlayerMovement basicMovement;
    public float speedBoost = 1f;
    void Start()
    {
        basicMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
            basicMovement.speed += speedBoost;
        else if (Input.GetKeyUp(KeyCode.LeftShift))
            basicMovement.speed -= speedBoost;
    }
}
