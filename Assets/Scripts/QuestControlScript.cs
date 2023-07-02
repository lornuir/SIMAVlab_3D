using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class QuestControlScript : MonoBehaviour
{
    public List<Quest> quests;
    Quest activeQuest;
    public TextMeshProUGUI questTitle, questDescription, questProgress;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Quest q in quests) {
            if (q.currentStageID != -1)
                activeQuest = q;
        }
        questTitle.text = activeQuest.name;
        questDescription.text = activeQuest.description;
        questProgress.text = activeQuest.stages[activeQuest.currentStageID];
    }

    // Update is called once per frame
    void Update()
    {
        if (activeQuest != null && activeQuest.currentStageID != -1)
            questProgress.text = activeQuest.stages[activeQuest.currentStageID];
    }
}
