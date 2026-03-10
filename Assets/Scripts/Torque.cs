using UnityEngine;
using UnityEngine.InputSystem;

public class Torque : MonoBehaviour
{
    Rigidbody rb;
    public float TorqueStrength;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.aKey.isPressed)
        {
            rb.AddTorque(TorqueStrength * Time.deltaTime * Vector3.up);
        }
        if (Keyboard.current.dKey.isPressed)
        {
            rb.AddTorque(TorqueStrength * Time.deltaTime * Vector3.forward);
        }
    }
}
