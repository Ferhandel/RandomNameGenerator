using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextoController : MonoBehaviour
{
    public static TextoController instance;
    public TextMeshProUGUI texto;
    public List<string> nombres = new List<string>();


    void Awake(){
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        nombres.Add("Balardo");
        nombres.Add("Viriato");
        nombres.Add("Bitongo");
        nombres.Add("Suga");
        nombres.Add("Felix");
        if (texto == null){
            Debug.Log("Texto no asignado");
        } else{
            texto.text = nombres[Random.Range(0, nombres.Count)].ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
