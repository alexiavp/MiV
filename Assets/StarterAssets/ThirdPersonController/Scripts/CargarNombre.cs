using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CargarNombre : MonoBehaviour
{
	private GameObject nombre1;
    // Start is called before the first frame update
    private void Start()
    {
        nombre1 = GameObject.FindGameObjectWithTag("nombre1");
		nombre1.GetComponent<Text>().text = PlayerPrefs.GetString("nombre1");
    }

}
