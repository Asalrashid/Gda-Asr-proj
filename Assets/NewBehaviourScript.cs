using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float m_speed;
    [SerializeField] private float m_sprintSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float speed;
        if (Input.GetKey(KeyCode.LeftShift))
            speed = m_sprintSpeed;
        else
        {
            speed = m_speed;
        }

        if (Input.GetKey(KeyCode.UpArrow))
            transform.position += Vector3.forward* speed;
        if (Input.GetKey(KeyCode.DownArrow))
            transform.position += Vector3.back * speed;
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.position += Vector3.left * speed;
        if (Input.GetKey(KeyCode.RightArrow))
            transform.position += Vector3.right * speed;
        if (Input.GetKey(KeyCode.Space))
            transform.position += Vector3.up * speed;
        if (Input.GetKey(KeyCode.RightShift))
            transform.position += Vector3.down * speed;

    }

}
