/// TODO
/// [ ] Make this program a choose your own 'quest' game template.
/// [ ] Allow PC users to click on the answer they want. (This will help when I make this game for mobile)
/// [ ] Make this game for android
/// [X] Make the UI dynamic
/// 
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

    //int[] oddNumbers = { 1, 3, 5, 7, 9 }; // Array Example

    // Start is called before the first frame update
    void Start()
    {
        state = startingState; // It starts in the starting state

        FillInStateText();

        //textComponent.text = ("This text is added programmatically as a test example!");
        //Debug.Log(oddNumbers[3]); // Array Example...printing it
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    /// <summary>
    /// TODO
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
        //else if (Input.GetKeyDown(KeyCode.T))  // This is just for testing. Delete before sending out the game.
        //{
        //    state = nextStates[2];
        //    FillInStateText();
        //}

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
