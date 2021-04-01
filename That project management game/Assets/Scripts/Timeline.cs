using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timeline : MonoBehaviour
{
    public Slider sltime;
    public Vector3 direccion;
    public void setTime(float tiempo)
    {
        sltime.value = tiempo;
        
    }
 
    public void setMaxTime(float aux,float puntoPartida)
    {
        sltime.value = puntoPartida;
        sltime.maxValue = aux;
        
    }
        // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
     direccion = sltime.fillRect.position;  
    }
}
