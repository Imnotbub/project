using System;
using Unity.VisualScripting;
using UnityEngine;

public class Switcher : MonoBehaviour
{
    public GameObject Scope;
    public GameObject MainCamera;
    Vector3 CameraPosition;
    Vector3 ScopePosition;
    
    

    void Start()
    {
        Scope.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxisRaw("mouseX");

        if (Input.GetButtonDown("MouseButton1"))
        {
            Scope.SetActive(true);
            MainCamera.transform.position = Scope.transform.position;
            MainCamera.transform.rotation = Scope.transform.rotation;
            Debug.Log("Scope is active");
        }
        else if (Input.GetButtonUp("MouseButton1"))
        {
            Scope.SetActive(false);
            MainCamera.transform.position = Scope.transform.position;
            MainCamera.transform.rotation = Scope.transform.rotation;
            Debug.Log("Scope is Inactive");
        }
         
        

       
            

        
    
    }


}
