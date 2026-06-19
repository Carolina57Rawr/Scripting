using UnityEngine;

public class Plataforma : MonoBehaviour
{
    public int speed = 100;
    public Vector3 direccion = Vector3.zero;
    public bool isActive = false;
    
    void Update()
    {
        if(isActive)
        {
            transform.position +=
                direccion * speed * Time.deltaTime;
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Enemytstopt")
        {
            direccion *= -1;
        }
        if (other.tag=="Player")
        { isActive = true; 
        print ("Bless");
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        { isActive = false; }
    }
}
