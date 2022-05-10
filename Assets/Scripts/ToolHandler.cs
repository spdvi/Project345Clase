using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolHandler : MonoBehaviour
{
    //[SerializeField] private GameObject mainCamera; 

    [SerializeField] private Outliner outliner;
    private LevelManager levelManager;

    private void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Si no tinc res en sa ma, agafar la eina que esta outlineada
            if(transform.childCount == 0)
            {
                if (outliner.outlinedObject != null && outliner.outlinedObject.CompareTag("Eina"))
                {
                    // Fer la eina fill nostre
                    Transform eina = outliner.outlinedObject;
                    eina.parent = transform;
                    eina.GetComponent<Rigidbody>().isKinematic = true;
                    eina.GetComponent<Collider>().enabled = false;
                    eina.localPosition = Vector3.zero;
                    eina.localRotation = Quaternion.identity;
                }
            }
            // Si ja tinc algo a sa ma, penjar-lo o amollar-lo
            else if (transform.childCount == 1)
            {
                // Si estic mirant a un penjador, penjar-lo
                if (outliner.outlinedObject != null && outliner.outlinedObject.CompareTag("Penjador"))
                {
                    Transform penjador = outliner.outlinedObject;
                    Transform eina = transform.GetChild(0);
                    eina.parent = penjador;
                    eina.localPosition = Vector3.zero;
                    eina.localRotation = Quaternion.identity;
                    //eina.localScale = Vector3.one;
                    levelManager.IncrementEinesPenjades();
                }
            }
            
        }
    }
}
