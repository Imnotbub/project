using UnityEngine;
using vector3 = UnityEngine.Vector3;
using quaternion = UnityEngine.Quaternion;
using UnityEditor.Experimental.GraphView;

public class VerticalRotation : MonoBehaviour
{
    public Transform cam;
    public Transform HorizontalAxis;
    public Transform VerticalAxis;
    float smoothTime = 0.1f;
    float turnSmoothVelocityInternal;
    
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       vector3 direction = new vector3(Input.GetAxis("Mouse Y"), 0f, 0f).normalized;
       float targetAngle = Mathf.Atan2(direction.x, 0f) * Mathf.Rad2Deg + cam.eulerAngles.x;
       float smoothAngle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocityInternal, smoothTime);
       transform.rotation = Quaternion.Euler(smoothAngle, 0f, 0f);

        
      

      
      

    }
}