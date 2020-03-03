﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuBehaviour : MonoBehaviour
{
    public Quest selectedQuest;
    GameObject selectButton;

    // Start is called before the first frame update
    void Start()
    {
        selectButton = GameObject.Find("SelectionButton");
        selectButton.GetComponent<Button>().interactable = false;
    }

    public void SelectQuest()
    {
        Debug.Log("Selected Quest: " + selectedQuest.name);
    }

    public void AllowQuestSelect(Quest quest)
    {
        selectButton.GetComponent<Button>().interactable = true;
        selectedQuest = quest;
    }

    public void DeactivateQuestSelect()
    {
        selectButton.GetComponent<Button>().interactable = false;
    }
}
