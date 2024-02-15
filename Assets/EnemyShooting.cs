using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField] private GameObject m_sphere;
    
    void ShootMethod()
    {
        var g = Instantiate(m_sphere);
        g.transform.position = transform.position;
    }
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ShootMethod", 0.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
    
