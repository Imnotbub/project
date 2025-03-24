using UnityEngine;
using vector3 = UnityEngine.Vector3;
using quaternion = UnityEngine.Quaternion;
using UnityEditor.Experimental.GraphView;

public class TurretRotation : MonoBehaviour
{
    public Transform cam;
    public Transform HorizontalAxis;
    public Transform VerticalAxis;
    float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       vector3 direction = new vector3(Input.GetAxis("Mouse X"), 0, 0).normalized;
       vector3 directionJoystick = new vector3(Input.GetAxis("HorizontalLook"), 0, 0).normalized;
       float targetAngle = Mathf.Atan2(direction.x, 0f) * Mathf.Rad2Deg + cam.eulerAngles.y;
       float smoothAngle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
       transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);

        
      

      
      

    }
}
