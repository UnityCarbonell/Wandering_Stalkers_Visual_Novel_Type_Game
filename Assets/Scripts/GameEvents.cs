using UnityEngine;

public class GameEvents : MonoBehaviour
{
    //General events
    public delegate void HideScrollView();
    public static event HideScrollView hsv;

    public delegate void ShowScrollView();
    public static event ShowScrollView ssv;

    //Story One Events
    public delegate void StoryOne();
    public static event StoryOne so;

    public delegate void SOMainBranch();
    public static event SOMainBranch somb;

    public delegate void SOChosenBranch();
    public static event SOChosenBranch socb;

    public void HSV()
    {
        hsv();
    }

    public void SSV()
    {
        ssv();
    }

    public void TaggedEvents(string eventTag)
    {
        if (eventTag == null)
        {
            Debug.LogWarning("No event tag");
        }
        else
        {
            if (eventTag == "StoryOne")
            {
                so();
            }
            if (eventTag == "SOMainBranch")
            {
                somb();
                SSV();
            }
        }
    }

    public void ChooceEvent(string eventTag, int index)
    {
        if (eventTag == "SOChooseBranch")
        {
            socb();
            /*
            if ()
            {

            }
            */
        }
    }
}
