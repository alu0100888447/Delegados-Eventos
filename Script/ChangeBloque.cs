using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBloque : MonoBehaviour {

    public GameObject []bloques;
    public static int contador = 0;
    public Material colorMaterial;

    private void Start()
    {
        bloques = GameObject.FindGameObjectsWithTag("NegativeObstacle");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Player" && contador % 2 == 0)
        {
            foreach(GameObject bloque in bloques)
            {
                bloque.GetComponent<Renderer>().material.color = new UnityEngine.Color(0, 0, 0);
            }
            contador++;
        } else if (collision.collider.name == "Player" && contador % 2 == 1)
        {
            foreach (GameObject bloque in bloques)
            {
                bloque.GetComponent<Renderer>().material = colorMaterial;
            }
            contador++;
        }
    }
}
