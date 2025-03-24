using UnityEngine;
using vector3 = UnityEngine.Vector3;
using quaternion = UnityEngine.Quaternion;

public class TurretRotation : MonoBehaviour
{
    public CharacterController CharacterController;

    public Transform cam;
    public float turnSmoothTime = 0.01f;
    float turnSmoothVelocity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Turns turret to face the direction the camera is facing on the z axis
        transform.rotation = Quaternion.Euler(0f, cam.eulerAngles.y * turnSmoothTime, 0f) * Quaternion.Euler(0f, 0f, 0f);
        
    }
}
