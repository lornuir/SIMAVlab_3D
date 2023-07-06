using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InteractionHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI interactionText;
    [SerializeField] List<Tool> tools;
    private Tool interactableTool;
    [SerializeField] Transform holdAreaPos;
    private RaycastHit hit;
    [SerializeField] GameObject holdArea;
    private float range = 5;
    private bool interactionPossible;

    void Update()
    {
        checkInteraction();
        displayInteraction();

        if (Input.GetKeyDown(KeyCode.E))
            useStation();
        
    }

    private void checkInteraction()
    {
        Debug.DrawRay(holdAreaPos.position, holdAreaPos.forward * range, Color.red);
        if (Physics.Raycast(holdAreaPos.position, holdAreaPos.forward, out hit, range))
        {
            if (hit.transform.parent.gameObject != null | hit.transform.gameObject != null)
            {
                switch (hit.transform.parent.gameObject.name)
                {
                    case "Incubator":
                        tools.Find(tool => tool.name == "Incubator").interactable = true;
                        interactionPossible = true;
                        //Debug.Log("Incubator is interactable");
                        break;
                    case "FumeHood":
                        tools.Find(tool => tool.name == "FumeHood").interactable = true;
                        interactionPossible = true;
                        //Debug.Log("FumeHood is interactable");
                        break;
                    case "Microscope":
                        tools.Find(tool => tool.name == "Microscope").interactable = true;
                        interactionPossible = true;
                        //Debug.Log("Microscope is interactable");
                        break;
                    case "Vortex":
                        tools.Find(tool => tool.name == "Vortex").interactable = true;
                        interactionPossible = true;
                        //Debug.Log("Vortex is interactable");
                        break;
                    default:
                        tools.ForEach(tool => tool.interactable = false);
                        //Debug.Log("Nothing is interactable");
                        interactionPossible = false;
                        break;
                }
            }
            else
            {
                tools.ForEach(tool => tool.interactable = false);
                interactionPossible = false;

            }
        }
        else
        {
            tools.ForEach(tool => tool.interactable = false);
            interactionPossible = false;
        }

    }

    private void displayInteraction()
    {
        interactableTool = tools.Find(tool => tool.interactable == true);

        if (interactableTool != null)
        {
            interactionText.text = interactableTool.name + "\n Press E while holding an item to use.";
            
        }
        else
        {
            interactionText.text = "";
        }
    }

    private void useStation()
    {
        if (!interactionPossible | holdArea.transform.childCount == 0 | (!interactionPossible && holdArea.transform.childCount == 0))
            Debug.Log("You need to hold an item and interact with a station to craft");
        
        else
            Debug.Log("Crafting with station");
    }
}
