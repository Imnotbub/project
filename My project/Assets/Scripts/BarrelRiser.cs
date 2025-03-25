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
        Mathf.Clamp(Barrel.transform.rotation.x, -25, 45);
        
        if (Input.GetKey(riseKey))
        {
            Barrel.transform.Rotate(Vector3.forward * BarrelMoveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(lowerKey))
        {
            Barrel.transform.Rotate(Vector3.back * BarrelMoveSpeed * Time.deltaTime);
        }
    }
}
