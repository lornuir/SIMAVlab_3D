using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolSpawnerScript : MonoBehaviour
{
    [SerializeField] GameObject obj;
    [SerializeField] Tool tool;
    // Start is called before the first frame update
    void Start()
    {
        obj.SetActive(tool.visible);
    }

    
}
