/// TODO
/// [ ] Make this program a choose your own 'quest' game template.
/// [ ] Allow PC users to click on the answer they want. (This will help when I make this game for mobile)
/// [ ] Make this game for android
/// [X] Make the UI dynamic

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text storyTextComponent;
    [SerializeField] State startingState;
    [SerializeField] TMP_Text headerTextMeshComponent;

    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState; // It starts in the starting state

        FillInStateText();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    /// <summary>
    /// This controls which state is loaded and the controls that choose the different states.
    /// </summary>
    private void ManageState()
    {
        var nextStates = state.GetNextStates();

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
            FillInStateText();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
            FillInStateText();
        }
    }

    /// <summary>
    /// This will fill in the header and story text for each state.
    /// </summary>
    void FillInStateText()
    {
        storyTextComponent.text = state.GetStateStory();
        headerTextMeshComponent.text = state.GetStateHeader();
    }
}
