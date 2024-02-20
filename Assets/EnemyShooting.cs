using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField] private SpeedandDelay m_delay;
    [SerializeField] private GameObject m_sphere;


    private void Start()
    {
        StartCoroutine(IShoot());
    }
    private IEnumerator IShoot()
    {
        while(true) 
        {
            yield return new WaitForSeconds(m_delay.Delay);
            ShootMethod();
            yield return new WaitForSeconds(0.1f);
            ShootMethod();
            yield return new WaitForSeconds(0.1f);
            ShootMethod();
        }
    }
    void ShootMethod()
    {
        var g = Instantiate(m_sphere);
        g.transform.position = transform.position;
    }
    // Start is called before the first frame update
    /*void Start()
    {
        InvokeRepeating("ShootMethod", 0.0f, m_delay.Delay);
    }*/

    // Update is called once per frame
}
    
