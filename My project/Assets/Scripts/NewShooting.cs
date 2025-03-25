using UnityEditor;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class NewShooting : MonoBehaviour
{
    public Transform ShotPoint;
    public GameObject Fire;

    public GameObject Hitpoint;

    public GameObject crosshair;


    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButtonDown(0))
       {
           Shoot();
       }
       
        
            
        

        

    }

    public void Shoot()
    {
        RaycastHit hit;
        
       if(Physics.Raycast(ShotPoint.position, transform.TransformDirection(Vector3.forward), out hit, 100f))
       {
            
            Debug.DrawRay(ShotPoint.position, transform.TransformDirection(Vector3.forward) * hit.distance , Color.yellow);

            GameObject a = Instantiate(Fire, ShotPoint.position, Quaternion.identity);
            GameObject b =Instantiate(Hitpoint, hit.point, Quaternion.identity);

            Destroy(a, 5f);
            Destroy(b, 5f);

       }
    }
    
   

}
