using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform target;
    void OnTriggerEnter(Collider other)
    {
        Transform transformComp = other.GetComponent<Transform>();
        transformComp.position = target.position;
    }
    void OnTriggerExit(Collider other)
    { 

    }
}
