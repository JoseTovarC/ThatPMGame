using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Task : MonoBehaviour
{
    public List<Slider> Tareas = new List<Slider>();
    public Transform puntoinicio;
    public Transform puntofinal;
    public static Task ActTask;
    // Start is called before the first frame update
    private void Awake()
    {
        if (ActTask == null)
        {
            ActTask = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    void Start()
    {
        int randomIndex = Random.Range(0, Tareas.Count-2);
        Slider tareainicial = Tareas[randomIndex];
        //tareainicial.fillRect.position.x = 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
