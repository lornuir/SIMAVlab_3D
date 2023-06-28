using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncubatoreScript : MonoBehaviour
{
    public Tool incubatore;
    public GameObject IncubatoreModel;
    void Start()
    {
        IncubatoreModel.SetActive(incubatore.visible);
    }

    
}
