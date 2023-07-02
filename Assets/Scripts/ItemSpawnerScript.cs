using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawnerScript : MonoBehaviour
{
    public GameObject obj;
    public Item item;
    // Start is called before the first frame update
    void Start()
    {
        obj.SetActive(item.visible);
    }

}
