using UnityEngine;
using UnityEngine.InputSystem;

public class MagnusSoccerKick : MonoBehaviour
{
    public float KickForce;
    public float SpinAmount;
    public float MagnusStrength = 0.5f;

    Rigidbody rb;
    bool isShot = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.isPressed && !isShot)
        {
            rb.AddForce(Vector3.forward * KickForce, ForceMode.Impulse);
            rb.AddTorque(Vector3.up * SpinAmount);
            isShot = true;
        }
    }

    void FixedUpdate()
    {
        if (!isShot) return;

        Vector3 velocity = rb.linearVelocity;
        Vector3 spin = rb.angularVelocity;

        Vector3 magnusForce = MagnusStrength * Vector3.Cross(spin, velocity); //spin = angular, velocity = linear
        rb.AddForce(magnusForce);
    }
}
