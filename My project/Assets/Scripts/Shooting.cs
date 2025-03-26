using System;
using System.Numerics;
using Unity.Mathematics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;
using Quaternion = UnityEngine.Quaternion;


public class Shooting : MonoBehaviour
{
    public float launchSpeed = 75.0f;

    public float FireDelay = 2f;
    public GameObject objectPrefab;
    bool alreadyShot;


    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetMouseButton(0)) {
        if(alreadyShot == false)
        {
          SpawnObject();
        }
        
      } 
    }

    void SpawnObject(){
        Vector3 spawnPosition = transform.position;
        Quaternion spawnRotation = Quaternion.identity;

        Vector3 localXDirection = transform.TransformDirection(Vector3.forward);
        Vector3 velocity = localXDirection * launchSpeed;

        GameObject newObject = Instantiate(objectPrefab, spawnPosition, spawnRotation);

        Rigidbody rb = newObject.GetComponent<Rigidbody>();
        rb.linearVelocity = velocity;
        alreadyShot = true;
         Invoke(nameof(ShotDelay), FireDelay);
    }

    void ShotDelay(){
      alreadyShot = false;
    }
    
}
