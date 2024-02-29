using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    Transform playerTransform;
    float initialCameraOffset;
    Vector3 cameraRotation;
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        initialCameraOffset = Vector3.Distance( transform.position , playerTransform.position );
        cameraRotation = transform.rotation.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
      

        float mouseX = Input.GetAxis("Mouse X");
     

        if (mouseX != 0)
        {
            cameraRotation.y += mouseX; 
        }
        transform.eulerAngles = cameraRotation;
        Vector3 cameraLookDirection = Quaternion.Euler(cameraRotation) * Vector3.forward;
        transform.position = -cameraLookDirection * initialCameraOffset + playerTransform.position;
      
        //rotate player
        
        //Vector3 playerRotation = playerTransform.eulerAngles;
        //playerRotation.y = transform.rotation.eulerAngles.y;
        //playerTransform.eulerAngles = playerRotation;
    }
   private void OnEnable()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void OnDisable()
    {
        Cursor.lockState = CursorLockMode.None;
    }
  
}
