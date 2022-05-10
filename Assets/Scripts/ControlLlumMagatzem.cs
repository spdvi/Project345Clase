using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlLlumMagatzem : MonoBehaviour
{
    [SerializeField] private Light pointLight1;
    [SerializeField] private Light pointLight2;
    [SerializeField] private Transform lightSwitch;
    public Transform esfera1;
    public Transform esfera2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rayOrigin = esfera1.position;
        Vector3 rayDirection = esfera2.position - rayOrigin;
        float distancia = Vector3.Distance(esfera1.position, esfera2.position);
        Ray ray = new Ray(rayOrigin, rayDirection);
        Debug.DrawRay(ray.origin, ray.direction * distancia, Color.red);

        if (Input.GetKeyDown(KeyCode.L))
        {
            pointLight1.enabled = !pointLight1.enabled;
            pointLight2.enabled = !pointLight2.enabled;
        }
    }
}
