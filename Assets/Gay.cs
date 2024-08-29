using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Gay
{
    public string name;
    public string pet;
    public int tattoos;
    public bool IsSingle;
    public float gaylevel;

    public Gay(string whatName, string whatPet, int TatNumber, bool DTF, float howGay)
    {
        name = whatName;
        pet = whatPet;
        tattoos = TatNumber;
        gaylevel = howGay;
        IsSingle = DTF;
    }
}
