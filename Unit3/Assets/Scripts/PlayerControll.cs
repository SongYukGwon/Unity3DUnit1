using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{

    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;

    public bool isOnGraound = true;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGraound)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGraound = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGraound = true;
    }
}
