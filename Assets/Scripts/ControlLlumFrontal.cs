using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlLlumFrontal : MonoBehaviour
{
    Light frontal;

    // Start is called before the first frame update
    void Start()
    {
        frontal = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            frontal.enabled = !frontal.enabled;
        }
    }
}
