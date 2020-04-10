using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This allows you to right-click and create a new State object in Unity
[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    // 1st # = minimum, 2nd # = number of lines before we start to scroll
    [TextArea(14, 10)] [SerializeField] string storyText;

    // Maybe use a dictionary or something for the header part.
    //   The way I'm doing this might not be adequate. (Me tend be dumb)
    [SerializeField] string headerText;

    [SerializeField] State[] nextStates;

    /// <summary>
    /// Gets the story for the current state.
    /// </summary>
    /// <returns>The story text</returns>
    public string GetStateStory()
    {
        return storyText;
    }

    /// <summary>
    /// Gets the header text for the current state.
    /// </summary>
    /// <returns>The title of the place you are</returns>
    public string GetStateHeader()
    {
        // <notes>
        // This method could be used for debugging.
        // I'm assuming you would usually just have a static header that is the title of the game.
        // </notes>
    
        return headerText;
    }

    /// <summary>
    /// Get's an array of the next states.
    /// </summary>
    /// <returns>Return the array of the next states.</returns>
    public State[] GetNextStates()
    {
        return nextStates;
    }
}
