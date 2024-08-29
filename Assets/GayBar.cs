using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GayBar : MonoBehaviour
{
    Gay gay1 = new Gay("Steph", "Dog", 5, true, 7.6f);
    Gay gay2 = new Gay("Jess", "Cat", 2, false, 3.2f);
    Gay gay3 = new Gay("Alicia", "Bearded Dragon", 8, true, 5.5f);

void Start()
    {
        Debug.Log(gay1.IsSingle);
        Debug.Log(gay3.name);
        Debug.Log(gay2.gaylevel);
    }
}
