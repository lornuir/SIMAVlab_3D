using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using JetBrains.Annotations;

public class RecipeMenu : MonoBehaviour
{
    public TextMeshProUGUI recipeDesc;
    public TMP_Dropdown recipeDropdown;
    public Recipe recipe1, recipe2, recipe3, recipe4, recipe5;
    
    public void DisplayText() {
        
        switch (recipeDropdown.value) {
            case 0:
                recipeDesc.text = recipe1.description;
                break;
            case 1:
                recipeDesc.text = recipe2.description;
                break;
            case 2:
                recipeDesc.text = recipe3.description;
                break;
            case 3:
                recipeDesc.text = recipe4.description;
                break;
            default:
                recipeDesc.text = recipe5.description;
                break;
        }

        
    
    }

    public void goToScene() {
        switch (recipeDropdown.value)
        {
            case 0:
                foreach (Item ingredient in recipe1.ingredients) {
                    ingredient.visible = true;
                    ingredient.interactable = true;
                }
                foreach (Tool tool in recipe1.tools) {
                    tool.visible = true;
                    tool.interactable = true;
                }
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case 1:
                foreach (Item ingredient in recipe2.ingredients)
                {
                    ingredient.visible = true;
                    ingredient.interactable = true;
                }
                foreach (Tool tool in recipe2.tools)
                {
                    tool.visible = true;
                    tool.interactable = true;
                }
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case 2:
                foreach (Item ingredient in recipe3.ingredients)
                {
                    ingredient.visible = true;
                    ingredient.interactable = true;
                }
                foreach (Tool tool in recipe3.tools)
                {
                    tool.visible = true;
                    tool.interactable = true;
                }
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case 3:
                foreach (Item ingredient in recipe4.ingredients)
                {
                    ingredient.visible = true;
                    ingredient.interactable = true;
                }
                foreach (Tool tool in recipe4.tools)
                {
                    tool.visible = true;
                    tool.interactable = true;
                }
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            default:
                foreach (Item ingredient in recipe5.ingredients)
                {
                    ingredient.visible = true;
                    ingredient.interactable = true;
                }
                foreach (Tool tool in recipe5.tools)
                {
                    tool.visible = true;
                    tool.interactable = true;
                }
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
        }
    }

    public void QuitGame() 
    {
        Application.Quit();
    }
}
