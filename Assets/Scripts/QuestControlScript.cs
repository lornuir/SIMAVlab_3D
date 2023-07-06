using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class QuestControlScript : MonoBehaviour
{
    public List<Quest> quests;
    int questIndex;
    public TextMeshProUGUI questTitle, questDescription, questProgress;
    GameObject requiredObj, objToRemove;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Quest q in quests) {
            if (q.currentStageID != -1)
            {
                questIndex = quests.IndexOf(q);
            }
        }
        questTitle.text = quests[questIndex].name;
        questDescription.text = quests[questIndex].description;
        questProgress.text = quests[questIndex].stages[quests[questIndex].currentStageID];
        if (quests[questIndex].items[quests[questIndex].currentStageID] != null)
            quests[questIndex].requiredStageItem = quests[questIndex].items[quests[questIndex].currentStageID];
    }

    // Update is called once per frame
    void Update()
    {
        if (quests[questIndex] != null && quests[questIndex].currentStageID != -1)
            questProgress.text = quests[questIndex].stages[quests[questIndex].currentStageID];
        if (quests[questIndex].requiredStageItem != null)
        {
            if (Progress())
            {

                quests[questIndex].currentStageID += 1;
                quests[questIndex].requiredStageItem = quests[questIndex].items[quests[questIndex].currentStageID];

            }
        }
        if (Input.GetKeyUp(KeyCode.C))
        {
            Remove();
        }
    }

    private bool Progress() {
        requiredObj = GameObject.Find(quests[questIndex].requiredStageItem.name + "(Clone)");
        if (requiredObj != null)
            return true;
        else
            return false;

    }

    private void Remove()
    {
        //objToRemove = GameObject.Find(quests[questIndex].items[quests[questIndex].currentStageID - 1].name + "(Clone)");
        objToRemove = GameObject.Find("Container");
        Destroy(objToRemove);
    }
}
