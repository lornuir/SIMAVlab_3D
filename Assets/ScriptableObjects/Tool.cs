using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Tool", menuName = "Tool", order = 3)]
public class Tool : ScriptableObject
{
    public string name;
    public int temperature;
    public bool visible;
    public bool interactable;
}
