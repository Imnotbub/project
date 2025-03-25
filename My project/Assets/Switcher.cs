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
        float MouseX = Input.GetAxis("Mouse X");
        
        
        CameraPosition = new Vector3(MainCamera.transform.position.x, MainCamera.transform.position.y, MainCamera.transform.position.z);
        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            Scope.SetActive(true);
            MainCamera.SetActive(false);
            Debug.Log("Scope Active");
        }
        if(Input.GetKeyUp(KeyCode.Mouse1))
        {
            Scope.SetActive(false);
            MainCamera.SetActive(true);
            Debug.Log("Scope Inactive");
        }
        if(Scope.activeSelf)
        {
            MainCamera.transform.position = new Vector3(Scope.transform.position.x, Scope.transform.position.y, Scope.transform.position.z);
            MainCamera.transform.Rotate(0, MouseX, 0);
        }
            

        
    
    }


}
