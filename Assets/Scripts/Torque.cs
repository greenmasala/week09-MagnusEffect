using UnityEngine;

public class Torque : MonoBehaviour
{
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(10 * Time.deltaTime * Vector3.up);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddTorque(10 * Time.deltaTime * Vector3.forward);
        }
    }
}
