using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceController : MonoBehaviour
{
    private bool addTheForce;
    private Rigidbody ourRigidbody;
    [SerializeField]
    private Vector3 ourVector;
    [SerializeField]
    private ForceMode ourForceMode;
    [SerializeField]
    private float thrust;

    void Start()
    {
        ourRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            ReturnToCenter();
        }
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            addTheForce = true;
        }
    }
    void FixedUpdate()
    {
        if(addTheForce)
        {
            ourRigidbody.AddForce(ourVector * thrust, ourForceMode);
            addTheForce = false;
        }
    }

    private void ReturnToCenter()
    {
        ourRigidbody.position = ourRigidbody.velocity = Vector3.zero;
    }
}
