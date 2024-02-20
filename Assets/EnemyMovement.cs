using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody m_rigidbody;
    [SerializeField] private float m_speed;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Movement());
        m_rigidbody = GetComponent<Rigidbody>();
    }

    private IEnumerator Movement()
    {
        while (true)
        {
            yield return new WaitForSeconds(2.0f);
            m_rigidbody.velocity = Vector3.forward * m_speed;
            yield return new WaitForSeconds(2.0f);
            m_rigidbody.velocity = Vector3.back * m_speed;
            yield return new WaitForSeconds(2.0f);
            m_rigidbody.velocity = Vector3.left * m_speed;
            yield return new WaitForSeconds(2.0f);
            m_rigidbody.velocity = Vector3.right * m_speed;

        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
       /* for(int i = 0; i > 200; i++)
        {

        }*/
    }
}
