using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionRotation : MonoBehaviour
{

    [SerializeField] private GameObject rotationMimc;
    [SerializeField] private bool isMimicRotation;
    [SerializeField] private bool isRandomRotation;
    [SerializeField] private Quaternion thatRotation;

    private int timePassed = 2;

    void Update()
    {
        if(isMimicRotation)
        {
            MimicRotation();
        }
        else if (isRandomRotation)
        {
            RandomRotation();
        }
        else 
        {
            transform.rotation = thatRotation;
        }
    }

    private void MimicRotation()
    {
        transform.rotation = Quaternion.RotateTowards(transform.rotation,rotationMimc.transform.rotation, 1f);
    }

    private void RandomRotation()
    {
        if(Time.time>=timePassed){
            transform.rotation = Random.rotation;
            timePassed += 2;
        }
    }
}