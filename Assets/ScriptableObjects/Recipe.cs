using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Recipe", menuName = "Recipe", order = 1)]
public class Recipe : ScriptableObject
{
    public List<Item> ingredients;
    public List<int> ingredientCounts;
    public List<Tool> tools;
    public string name;
    public string description;
}
