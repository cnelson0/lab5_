using UnityEditor;
using UnityEngine;

public class BoxExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float forceAmount = 5.0f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("Rigidbody found");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(Vector3.forward * forceAmount);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision with: " + collision.gameObject.name);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered trigger: " + other.gameObject.name);
    }
}
