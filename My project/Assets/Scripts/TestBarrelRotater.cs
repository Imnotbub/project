using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestBarrelRotater : MonoBehaviour
{
    public KeyCode riseKey = KeyCode.R;
    public KeyCode lowerKey = KeyCode.F;
    public float BarrelMoveSpeed = 25f;
    public Transform Barrel;
    float turnSmoothTime = -0.1f;
    float turnSmoothVelocity;
    public Transform cam;

    // Update is called once per frame
    void Update()
    {
      float Vertical = cam.eulerAngles.x;
      float targetAngle = Mathf.Atan2(Vertical, 0f) * Mathf.Rad2Deg + cam.eulerAngles.x;
        
        transform.rotation = Quaternion.Euler(targetAngle, 0f, 0f);
        

        
    }
 
}
