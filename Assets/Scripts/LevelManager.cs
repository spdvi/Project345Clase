using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] GameObject[] penjadors;
    private int einesPenjades = 0;
    public int totalEines = 3;
    private void Start()
    {
        penjadors = GameObject.FindGameObjectsWithTag("Penjador");
    }

    public void IncrementEinesPenjades()
    {
        einesPenjades++;
        if (einesPenjades == totalEines)
        {
            CheckToolsPlacement();
        }
    }

    public bool CheckToolsPlacement()
    {
        Dictionary<string, string> results = new Dictionary<string, string>();
        foreach(GameObject penjador in penjadors)
        {
            string nomEina;
            nomEina = penjador.transform.GetChild(1).name.Substring(0,
                penjador.transform.GetChild(1).name.IndexOf('('));
            string nomPenjador = penjador.transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().text;
            results.Add(nomPenjador, nomEina);
        }

        bool guanya = true;

        foreach(KeyValuePair<string,string> result in results)
        {
            if (result.Key != result.Value)
            {
                guanya = false;
                Debug.Log("Error: " + result.Key + " conté la eina " + result.Value);
            }
        }

        return guanya;
    }
}
