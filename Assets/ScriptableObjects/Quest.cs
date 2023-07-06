using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

[CreateAssetMenu(menuName= "Quest")]
public class Quest : ScriptableObject
{
    public List<string> stages;
    public List<Item> items;
    public string name;
    public string description;
    public int questID;
    public int currentStageID;
    public Item requiredStageItem;
    public bool completed;
}
