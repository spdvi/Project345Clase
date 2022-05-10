using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DibujaRayo : MonoBehaviour
{
    [SerializeField] private Light pointLight1;
    [SerializeField] private Light pointLight2;
    private Transform lightSwitch;

    // Start is called before the first frame update
    void Start()
    {
        lightSwitch = GameObject.Find("Switch").transform;

    }

    // Update is called once per frame
    void Update()
    {
        // Importar asset Workplace tools


        //Vector3 rayOrigin = ;
        //Vector3 rayDirection ;
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2f, Screen.height / 2f, 0));
        Debug.DrawRay(ray.origin, ray.direction * 15, Color.green);

        if(Physics.Raycast(ray, out RaycastHit hitInfo, 3, LayerMask.GetMask("Interruptors")))
        {
            //Debug.Log("Colisionat amb " + hitInfo.collider.name);
            // Encendre o apagar llums.
            if(Input.GetMouseButtonDown(0))
            {

                if (pointLight1.enabled)
                {
                    lightSwitch.Rotate(Vector3.right, 60f);
                }
                else
                {
                    lightSwitch.Rotate(Vector3.right, -60f);
                }

                pointLight1.enabled = !pointLight1.enabled;
                pointLight2.enabled = !pointLight2.enabled;

            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
