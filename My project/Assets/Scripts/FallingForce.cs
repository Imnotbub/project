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
   
   
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if()

        
        if (CharacterController.isGrounded == false)
        {
            Vector3 gravity = new(0, -Gravity, 0);
            CharacterController.Move(gravity * Time.deltaTime);


        }
    }
}  

