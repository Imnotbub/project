using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class BarrelRiser : MonoBehaviour
{
    public KeyCode riseKey = KeyCode.R;
    public KeyCode lowerKey = KeyCode.F;
    public float BarrelMoveSpeed = 25f;
    public Transform Barrel;

   

    
    
    
    // Update is called once per frame
    void Update()
    {
        
        
       
        
        if (Input.GetKey(riseKey))
        {
            
            Barrel.transform.Rotate(Vector3.left * BarrelMoveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(lowerKey))
        {
            Barrel.transform.Rotate(Vector3.right * BarrelMoveSpeed * Time.deltaTime);
            
        }


    }
}
