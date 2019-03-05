using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perdio : MonoBehaviour {

    public GameObject textoPerder;
    private bool hayColision = false;
    private bool reiniciar = false;
    public GameObject textRetry;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (reiniciar && Input.GetKeyDown(KeyCode.Space))
        {
            Application.LoadLevel("Haptic Demo");
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("Block"))
        {
            Debug.Log("Colision!!");
            textoPerder.SetActive(true);
            textRetry.SetActive(true);
            reiniciar = true;
            hayColision = true;
        }
    }

    public bool HayColision()
    {
        return hayColision;
    }

}
