using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Task : MonoBehaviour
{
    public List<Slider> tareas = new List<Slider>();
    public Transform puntoinicio;
    public Transform puntofinal;
    public List<GameObject> relleno_tareas = new List<GameObject>();
    public static Task ActTask;
    System.Random random = new System.Random();
    
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

    float random_condicion_inicio(float minimo, float maximo)
    {
        float val = (float)(random.NextDouble() * (maximo - minimo) + minimo);
        while (val - 1 < 1 || val - 1 > 2)
        {
            val = (float) (random.NextDouble() * (maximo - minimo) + minimo);
        }
        return val;
    }
    
    float random_condicion_final(float minimo, float maximo)
    {
        float val = (float)(random.NextDouble() * (maximo - minimo) + minimo);
        while (5.58-val < 1 || 5.58-val > 2)
        {
            val = (float) (random.NextDouble() * (maximo - minimo) + minimo);
        }
        return val;
    }
    
    void Start()
    {
        List<int> indices = new List<int>(){0,1,2,3,4};
        int randomIndex = Random.Range(0, tareas.Count-2);
        Slider tareainicial = tareas[randomIndex];
        tareainicial.minValue = 1f;
        float max = 5.58f;
        float min = 1f;
        float val = random_condicion_inicio(min, max);
        float xInicio = 170;
        float xFinal = 590;
        float pos_x = ((xFinal - xInicio) / 4.58f) * (val - 1f) + xInicio;
        tareainicial.maxValue = val;
        relleno_tareas[randomIndex].GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, xInicio, pos_x - xInicio);
        int randomIndex_final = Random.Range(randomIndex+2, tareas.Count);
        Slider tareafinal = tareas[randomIndex_final];
        tareafinal.maxValue = 5.58f;
        min = val;
        float valor = random_condicion_final(min, max);
        tareafinal.minValue = valor;
        float pos_x_final = ((xFinal - xInicio) / 4.58f) * (valor - 1f) + xInicio;
        relleno_tareas[randomIndex_final].GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, pos_x_final, xFinal - pos_x_final);
        int ramdonIndex_mitad = Random.Range(randomIndex+1, randomIndex_final);
        Slider tareamedio = tareas[ramdonIndex_mitad];
        tareamedio.maxValue = valor;
        tareamedio.minValue = val;
        relleno_tareas[ramdonIndex_mitad].GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, pos_x, pos_x_final - pos_x);
        indices.RemoveAt(randomIndex_final);
        indices.RemoveAt(ramdonIndex_mitad);
        indices.RemoveAt(randomIndex);
        foreach(var i in indices)
        {
            float minimo = 1f;
            float maximo = 5.58f;
            float val1 = (float) (random.NextDouble() * (maximo - minimo) + minimo);
            float val2 = (float) (random.NextDouble() * (maximo - val1) + val1);
            while (val2 - val1 < 1 || val2 - val1 > 2.3)
            {
                val1 = (float) (random.NextDouble() * (maximo - minimo) + minimo);
                val2 = (float) (random.NextDouble() * (maximo - val1) + val1);
            }
            float valor_x1 = ((xFinal - xInicio) / 4.58f) * (val1 - 1f) + xInicio;
            float valor_x2 = ((xFinal - xInicio) / 4.58f) * (val2 - 1f) + xInicio;
            relleno_tareas[i].GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, valor_x1, valor_x2 - valor_x1);
            tareas[i].minValue = val1;
            tareas[i].maxValue = val2;

        }
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
