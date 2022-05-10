using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outliner : MonoBehaviour
{
    float rayDistance = 3f;
    [HideInInspector] public Transform outlinedObject = null;

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2f, Screen.height / 2f, 0));

        if (Physics.Raycast(ray, out RaycastHit hitInfo, rayDistance, LayerMask.GetMask("Outlineable")))
        {
            if (!hitInfo.transform.GetComponent<Outline>().enabled)
            {
                outlinedObject = hitInfo.transform;
                hitInfo.transform.GetComponent<Outline>().enabled = true; 
            }
        }
        else
        {
            if (outlinedObject != null)
            {
                outlinedObject.GetComponent<Outline>().enabled = false;
                outlinedObject = null; 
            }
        }
    }
}
