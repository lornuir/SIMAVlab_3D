using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public List<Recipe> recipes;
    private void backToMenu()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            foreach (Recipe r in recipes) {
                r.relatedQuest.currentStageID = -1;
                foreach (Item ingredient in r.ingredients)
                {
                    ingredient.visible = false;
                    ingredient.interactable = false;
                }
                foreach (Tool tool in r.tools)
                {
                    tool.visible = false;
                    tool.interactable = false;
                }

            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

    }
    

    // Update is called once per frame
    void Update()
    {
        backToMenu();
    }
}
