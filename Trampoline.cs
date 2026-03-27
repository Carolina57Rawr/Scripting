using UnityEngine;

public class Trampoline : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
       Jump jumpComp = other.GetComponent<Jump>();
        jumpComp.jumpStrength = 10;
    }
    void OnTriggerExit(Collider other)
    {
        Jump jumpComp = other.GetComponent<Jump>();
        jumpComp.jumpStrength = 2;
    }
}
