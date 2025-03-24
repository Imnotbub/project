using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;
using Quaternion = UnityEngine.Quaternion;

public class playerController : MonoBehaviour
{
    
    public CharacterController CharacterController;
    public Transform cam;
   public float speed = 3f;

   public float turnSmoothTime = 0.01f;
   float turnSmoothVelocity;
   
   void Start()
    {
       Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false; 
    }
   
   
    // Update is called once per frame
    void Update()
    {
      float horizontal = Input.GetAxisRaw("Horizontal");
      float vertical = Input.GetAxisRaw("Vertical");  
      Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

     if (direction.magnitude >= 0.1f){

      float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
      float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
      transform.rotation = Quaternion.Euler(0f, angle, 0f);

      Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
      CharacterController.Move(moveDir.normalized * speed * Time.deltaTime);

     }

      if (Input.GetKeyDown(KeyCode.LeftShift))
      {
          speed = 5f;
          
      }
      else if (Input.GetKeyUp(KeyCode.LeftShift))
      {
          speed = 3f;
      }

        Vector3 TurretDirection = new Vector3(Input.GetAxis("Mouse X"), 0f, Input.GetAxis("Mouse Y"));
        transform.Rotate(Vector3.up * TurretDirection.x * 100 * Time.deltaTime);

    }
}
