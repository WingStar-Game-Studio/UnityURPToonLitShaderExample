using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reflection : MonoBehaviour
{
    private ReflectionProbe m_probe;
    [SerializeField] private Camera m_camera;
    
    // Start is called before the first frame update
    void Start()
    {
        m_probe = GetComponent<ReflectionProbe>();
    }

    // Update is called once per frame
    void Update()
    {
        var newPos = m_camera.transform.position;
        m_probe.transform.position = new Vector3(newPos.x, newPos.y * -1f, newPos.z);
        m_probe.RenderProbe();
    }
}
