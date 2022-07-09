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

    public delegate void BranchAvance();
    public static event BranchAvance ba;

    public delegate void ChosenBranch(int branch);
    public static event ChosenBranch cb;

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
            if (eventTag == "NextScene")
            {
                ba();
            }
        }
    }

    public void ChooseEvent(string eventTag, int choice,int index)
    {
        if (eventTag == "ChooseBranch")
        {
            if (choice == 1)
            {
                if (index == 0)
                {
                    cb(1);
                }
                else if (index == 1)
                {
                    cb(2);
                }
            }
            if (choice == 2)
            {
                if (index == 0)
                {
                    cb(3);
                }
                else if (index == 1)
                {
                    cb(4);
                }
            }
        }
    }
}
