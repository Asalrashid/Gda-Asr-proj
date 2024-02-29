    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField] private SpeedandDelay m_delay;
    [SerializeField] private GameObject m_sphere;
    public bool ShootOnStart = true;

    private void Start()
    {
        if (ShootOnStart)
            StartShooting();
        StartCoroutine(IShoot());
    }
    public void StartShooting()
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
        var g = Instantiate(m_sphere, transform.position + Vector3.up, Quaternion.identity);
        g.GetComponent<EnemyBullet>().Init(m_delay.Speed, true, m_delay.Autoaim);
    }
    // Start is called before the first frame update
    /*void Start()
    {
        InvokeRepeating("ShootMethod", 0.0f, m_delay.Delay);
    }*/

    // Update is called once per frame
}
    
