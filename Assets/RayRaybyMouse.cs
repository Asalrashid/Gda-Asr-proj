using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayRaybyMouse : MonoBehaviour
{
    public LayerMask worldLayer;
    void FireLaser()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Click();
        
    }
    void Click()
    {
        if (Input.GetMouseButtonDown(0))
        { 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitData;
            if (Physics.Raycast(ray, out hitData))
            {
                Debug.Log("Hit Object " + hitData.collider);
            }
        }
    }
}
