using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class BarrelRiser : MonoBehaviour
{
    public KeyCode riseKey = KeyCode.R;
    public KeyCode lowerKey = KeyCode.F;
    public float BarrelMoveSpeed = 5f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(riseKey))
        {
            transform.rotation = Quaternion.Euler(BarrelMoveSpeed * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(lowerKey))
        {
            transform.rotation = Quaternion.Euler(-BarrelMoveSpeed * Time.deltaTime, 0f, 0f);
        }
    }
}
