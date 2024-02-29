using System.Collections;
using System.Collections.Generic;
using TMPro;
using Tripolygon.UModeler.UI.Controls;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Animator m_animator;
    [SerializeField] private Transform m_shootingPoint;
    [SerializeField] private GameObject m_sphere;
    [SerializeField] private float m_speed;
    [SerializeField] private float m_sprintSpeed;
    private Rigidbody m_rigidbody;
    private static Vector3 m_PlayerPos;
    public static NewBehaviourScript Instance;
    
    // Start is called before the first frame update
    void Awake()
    {
        m_rigidbody = GetComponent<Rigidbody>();
        
        
    }
   
    public void Follow()
    {
        m_PlayerPos = transform.position;
    }
    public void AnimatorMove()
    {
        var animator = GetComponent<Animator>();
        

        if (Input.GetKeyDown(KeyCode.W))
            animator.SetBool("Forward", true);
        if (Input.GetKeyUp(KeyCode.W))
            animator.SetBool("Forward", false);
        if (Input.GetKeyDown(KeyCode.S))
            animator.SetBool("Back", true);
        if (Input.GetKeyUp(KeyCode.S))
            animator.SetBool("Back", false);
        if (Input.GetKeyDown(KeyCode.A))
            animator.SetBool("Left", true);
        if (Input.GetKeyUp(KeyCode.A))
            animator.SetBool("Left", false);
        if (Input.GetKeyDown(KeyCode.D))
            animator.SetBool("Right", true);
        if (Input.GetKeyUp(KeyCode.D))
            animator.SetBool("Right", false);

    }
    // Update is called once per frame
    void Update()
    {
        /* if (Input.GetKey(KeyCode.DownArrow))
             transform.position += Vector3.back * Time.deltaTime * speed;
         if (Input.GetKey(KeyCode.LeftArrow))
             transform.position += Vector3.left * Time.deltaTime * speed;
         if (Input.GetKey(KeyCode.RightArrow))
             transform.position += Vector3.right * Time.deltaTime * speed;
         if (Input.GetKey(KeyCode.Space))
             transform.position += Vector3.up * Time.deltaTime * speed;
         if (Input.GetKey(KeyCode.RightShift))
             transform.position += Vector3.down * Time.deltaTime * speed;*/
       
        AnimatorMove();
        
        if (Time.timeScale > 0)
        {
            if (Input.GetKeyDown(KeyCode.H))
            {
                m_animator.SetTrigger("Shoot");
               //  InvokeRepeating("ShootMethod", 0.0f, 1f);
            }
           /* if (Input.GetKeyUp(KeyCode.H))
            {
                CancelInvoke();
            }*/
        }
    }
    private void FixedUpdate()
    {
        bool move = false;

        float speed;
        if (Input.GetKey(KeyCode.LeftShift))
            speed = m_sprintSpeed;
        else
        {
            speed = m_speed;
        }

        if (Input.GetKey(KeyCode.W))
        {
            m_rigidbody.velocity = Vector3.forward * speed;
            move = true;
        }

        if (Input.GetKey(KeyCode.S))
        {
            m_rigidbody.velocity = Vector3.back * speed;
            move = true;

        }

        if (Input.GetKey(KeyCode.A))
        {
            m_rigidbody.velocity = Vector3.left * speed;
            move = true;

        }

        if (Input.GetKey(KeyCode.D))
        {
            m_rigidbody.velocity = Vector3.right * speed;
            move = true;

        }

        if (Input.GetKey(KeyCode.Space))
        {
            m_rigidbody.velocity = Vector3.up * speed;
            move = true;
        }

        if (Input.GetKey(KeyCode.RightShift))
        {
            m_rigidbody.velocity = Vector3.down * speed;
            move = true;
        }
        if (!move)
        {
            m_rigidbody.velocity = new Vector3(0, m_rigidbody.velocity.y ,0);
        }
        else
        {
            transform.rotation = Quaternion.LookRotation(m_rigidbody.velocity);
        }
    }

    

   public void ShootMethod() 
    {
        /*
         var g = Instantiate(m_sphere);
         g.transform.position = transform.position + transform.forward;
        */
        GameObject newBullet = Instantiate(m_sphere, m_shootingPoint.position, Quaternion.identity);
      //  newBullet.GetComponent<ShpereMove>();
    }   

}
