using UnityEngine;
using UnityEngine.InputSystem;

public class MagnusSoccerKick : MonoBehaviour
{
    public float KickForce;
    public float SpinAmount;
    public float MagnusStrength;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MagnusStrength = KickForce * SpinAmount;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.isPressed)
        {
            Vector3 test = Vector3.Cross(transform.up * -1, transform.right);
            Debug.Log(test);
            rb.AddForce(test * MagnusStrength, ForceMode.Force);
        }
    }
}
