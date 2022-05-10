using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EinaSpawner : MonoBehaviour
{
    public List<GameObject> einesPrefabs;
    int indexEina = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (einesPrefabs[indexEina].GetComponent<Outline>() == null)
        {
            //Outline outline = new Outline();
            Outline outline = einesPrefabs[indexEina].AddComponent<Outline>();
            //einesPrefabs[indexEina].GetComponent<Outline>().enabled = false;
            outline.enabled = false;

            //if (einesPrefabs[indexEina].layer != LayerMask.GetMask("Outlineable"))
            //{
            //    einesPrefabs[indexEina].layer = LayerMask.GetMask("Outlineable");
            //}
        }
        Instantiate(einesPrefabs[indexEina++], new Vector3(0,6,0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (indexEina < einesPrefabs.Count)
            {
                int xRandom = Random.Range(-9, 9);
                Vector3 randomPoint = new Vector3(xRandom,6,0);
                
                if (einesPrefabs[indexEina].GetComponent<Outline>() == null)
                {
                    //Outline outline = new Outline();
                    Outline outline = einesPrefabs[indexEina].AddComponent<Outline>();
                    //einesPrefabs[indexEina].GetComponent<Outline>().enabled = false;
                    outline.enabled = false;

                    //if (einesPrefabs[indexEina].layer != LayerMask.GetMask("Outlineable"))
                    //{
                    //    einesPrefabs[indexEina].layer = LayerMask.GetMask("Outlineable");
                    //}
                }

                Instantiate(einesPrefabs[indexEina++], randomPoint, Quaternion.identity);
            }
            else
            {
                Debug.Log("No hi ha mes eines");
            }

        }
    }
}
