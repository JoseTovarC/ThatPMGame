using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Shuffle 
{
    public static void Shuff<T>(this List<T> list, int ShuffleAccuracy)
    {
        for (int i = 0; i < ShuffleAccuracy; i++)
        {
            int randomIndex = Random.Range(1, list.Count);
            T temp = list[randomIndex];
            list[randomIndex] = list[0];
            list[0] = temp;
        }
    }
}
