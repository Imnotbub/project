using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;
using Quaternion = UnityEngine.Quaternion;
using UnityEditor.Callbacks;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEditor.ShaderGraph;
using Unity.Mathematics;
using JetBrains.Annotations;
using UnityEngine.SocialPlatforms;

public class playerController : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;
    public float speed = 3f;
    public float turnSmoothTime = 0.1f;
   float turnSmoothVelocity;
   
   public float MouseSensitivity = 50f;
    

    
    

    
   
   void Start()
    {
       Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false; 
        
        
    }
   
   
    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxisRaw("Horizontal");
        float Vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(Horizontal, 0, Vertical).normalized;
        
        if(direction.magnitude >= 0.1f){
            //targetAngle is responisble for rotating the player one an x,y plane from a birds eye view
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            //smooths angle of rotation
            float smoothAngle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            //rotates player
            transform.rotation = Quaternion.Euler(0f, smoothAngle, 0.1f);
           Vector3 moveDir = Quaternion.Euler(0f, smoothAngle, 0f) * Vector3.forward;
            
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift)){
            speed = 7f;

        }
        else if (Input.GetKeyUp(KeyCode.LeftShift)){
            speed = 3f;
        }
    }
}
