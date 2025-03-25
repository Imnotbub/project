using UnityEngine;
using vector3 = UnityEngine.Vector3;
using quaternion = UnityEngine.Quaternion;
using UnityEditor.Experimental.GraphView;

public class BarrelRotation : MonoBehaviour
{
    public Transform cam;
    public Transform HorizontalAxis;
    public Transform VerticalAxis;
    float turnSmoothTime = -0.1f;
    float turnSmoothVelocity;
    
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       vector3 direction = new vector3(Input.GetAxis("Mouse Y"), 0, 0).normalized;
       float targetAngle = Mathf.Atan2(0f, direction.y) * Mathf.Rad2Deg + cam.eulerAngles.y;
       float smoothAngle = Mathf.SmoothDampAngle(transform.eulerAngles.x, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
       transform.rotation = Quaternion.Euler(0f, smoothAngle, 0f);

        
      

      
      

    }
}