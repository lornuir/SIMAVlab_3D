using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VortexScript : MonoBehaviour
{
    public GameObject vortexModel;
    public Tool vortex;
    void Start()
    {
        vortexModel.SetActive(vortex.visible);
    }

}
