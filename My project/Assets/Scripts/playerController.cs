using UnityEngine;

public class playerController : MonoBehaviour
{
    
    public CharacterController CharacterController;
   public float speed = 6f;

   public float turnSmoothTime = 0.01f;
   float turnSmoothVelocity;
   
   void Start()
    {
        
    }
   
   
    // Update is called once per frame
    void Update()
    {
      float horizontal = Input.GetAxisRaw("Horizontal");
      float vertical = Input.GetAxisRaw("Vertical");  
      Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

     if (direction.magnitude >= 0.1f){

      float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
      float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
      transform.rotation = Quaternion.Euler(0f, angle, 0f);

      CharacterController.Move(direction * speed * Time.deltaTime);

     }

      if (Input.GetKeyDown(KeyCode.LeftShift))
      {
          speed = 12f;
          
      }
      else if (Input.GetKeyUp(KeyCode.LeftShift))
      {
          speed = 6f;
      }
    }
}
