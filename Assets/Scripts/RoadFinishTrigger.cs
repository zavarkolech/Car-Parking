using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadFinishTrigger : MonoBehaviour
{
    public Vector3 FinalPosition;
    void OnTriggerEnter(Collider car)
    {
        if(car.CompareTag("Car"))
        car.GetComponent<CarController>().FinalPosition = FinalPosition;
    }
}
