using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using Vector3 = UnityEngine.Vector3;

public class Switcher : MonoBehaviour
{
    public GameObject Camera_2;
    public GameObject Camera_1;

    public GameObject RotationRod;
    
    
    

    void Start()
    {
        Camera_1.SetActive(true);
        Camera_2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float MouseX = Input.GetAxis("Mouse X");

        if (Camera_2.activeSelf){
            Camera_1.transform.position = new Vector3(Camera_2.transform.position.x, Camera_2.transform.position.y, Camera_2.transform.position.z);
            Camera_1.transform.Rotate(0, MouseX, 0);
        }

        
        
        
        if(Input.GetMouseButtonDown(1)){
            Cam_2();
        }
        if(Input.GetMouseButtonUp(1)){
           Cam_1();
        }   
        void Cam_1(){
        Camera_1.SetActive(true);
        Camera_2.SetActive(false);
    }
       void Cam_2()
       {
        Camera_1.SetActive(false);
        Camera_2.SetActive(true);
       }
         
    }

     
}
