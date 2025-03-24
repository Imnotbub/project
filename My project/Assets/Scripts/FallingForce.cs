using UnityEngine;
using vector3 = UnityEngine.Vector3;
using quaternion = UnityEngine.Quaternion;

public class FallingForce : MonoBehaviour
{

   public Collider PlayerCollider;
   public CharacterController CharacterController;
   public Transform Controller;
   public float JumpForce = 10f;
   public float Gravity = 9.8f;
   public bool isGrounded;
   
   
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Detects if player is touching the ground
    void OnCollisionEnter(Collision collision)
    {
       
    }
    void OnCollisionExit(Collision collision)
    {
        
    }
    
    
    
    // Update is called once per frame
    void Update()
    {
        
        
        
        if (CharacterController.isGrounded == false)
        {
            Vector3 gravity = new(0, -Gravity, 0);
            CharacterController.Move(gravity * Time.deltaTime);


        }
    }
}  

