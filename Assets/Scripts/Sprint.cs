using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sprint : MonoBehaviour
{
    PlayerController basicMovement;
    public float speedBoost = 0.3f;
    void Start()
    {
        basicMovement = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
            basicMovement._moveSpeed += speedBoost;
        else if (Input.GetKeyUp(KeyCode.LeftShift))
            basicMovement._moveSpeed -= speedBoost;
    }
}
