using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private GameObject m_sphere;
    [SerializeField] private float m_speed;
    [SerializeField] private float m_sprintSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float speed;
        if (Input.GetKey(KeyCode.LeftShift))
            speed = m_sprintSpeed;
        else
        {
            speed = m_speed;
        }

        if (Input.GetKey(KeyCode.UpArrow))
            transform.position += Vector3.forward * Time.deltaTime * speed;
        if (Input.GetKey(KeyCode.DownArrow))
            transform.position += Vector3.back * Time.deltaTime * speed;
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.position += Vector3.left * Time.deltaTime * speed;
        if (Input.GetKey(KeyCode.RightArrow))
            transform.position += Vector3.right * Time.deltaTime * speed;
        if (Input.GetKey(KeyCode.Space))
            transform.position += Vector3.up * Time.deltaTime * speed;
        if (Input.GetKey(KeyCode.RightShift))
            transform.position += Vector3.down * Time.deltaTime * speed;



        if (Input.GetKeyDown(KeyCode.H)) 
        {
            InvokeRepeating("ShootMethod", 0.0f, 1f); 
        }
        if (Input.GetKeyUp(KeyCode.H))
        {
            CancelInvoke();
        }

    }


    void ShootMethod() 
    {
        var g = Instantiate(m_sphere);
        g.transform.position = transform.position;
    }

}
