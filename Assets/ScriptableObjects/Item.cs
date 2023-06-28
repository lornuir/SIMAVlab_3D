using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item", order = 2)]
public class Item : ScriptableObject
{
    public string name;
    public bool visible = false;
    public bool interactable = false;
}
