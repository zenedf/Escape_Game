using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This allows you to right-click and createa new State object in Unity
[CreateAssetMenu(menuName ="State")]
public class State : ScriptableObject
{
    // 1st # = minimum, 2nd # = number before we start to scroll
    [TextArea(14, 10)] [SerializeField] string storyText;

    // Maybe use a dictionary or something for the header part.
    //   The way I'm doing this might not be adequate. (Me tend be dumb)
    [SerializeField] string headerText;

    [SerializeField] State[] nextStates;

    /// <summary>
    /// TODO
    /// </summary>
    /// <returns>The story text</returns>
    public string GetStateStory()
    {
        return storyText;
    }

    /// <summary>
    /// TODO
    /// </summary>
    /// <returns>The title of the place you are</returns>
    /// <notes>
    /// This method could used for debugging.
    /// I'm assuming you would usually just have a static header that is the title of the game.
    /// </notes>
    public string GetStateHeader()
    {
        return headerText;
    }

    /// <summary>
    /// TODO
    /// </summary>
    /// <returns>TODO</returns>
    public State[] GetNextStates()
    {
        return nextStates;
    }
}
