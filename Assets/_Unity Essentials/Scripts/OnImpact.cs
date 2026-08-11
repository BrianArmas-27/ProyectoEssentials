using UnityEngine;

public class Table : MonoBehaviour
{
    public float force = 15f;
    public GameObject onCollectEffect;

    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            rb.AddForce(force, force, 0, ForceMode.Impulse);
            Instantiate(onCollectEffect, transform.position, transform.rotation);
        }
    }
}