using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float rotationSpeed = 0.5f;
    public GameObject onCollectEffect;
    private int counter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,rotationSpeed,0);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Destroys collectible
         if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        //Instantiate particle effect
            Instantiate(onCollectEffect, transform.position, transform.rotation);
            counter++;
        } 
    }
}
