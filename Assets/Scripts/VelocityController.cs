using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityController : MonoBehaviour
{
    [SerializeField]
    private Vector3 ourVelocity;
    private Rigidbody ourRigidbody;
    void Start()
    {
        ourRigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            ReturnToCenter();
        }
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            MoveTheCube();
        }
    }

    private void MoveTheCube()
    {
        ourRigidbody.velocity = ourVelocity;
    }
    private void ReturnToCenter()
    {
        ourRigidbody.position = ourRigidbody.velocity = Vector3.zero;
    }

}
