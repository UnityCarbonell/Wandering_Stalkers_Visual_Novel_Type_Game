using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionManager : MonoBehaviour
{

    public void OnEnable()
    {
        GameEvents.so += ToStoryOne;
    }
    public void OnDisable()
    {
        GameEvents.so -= ToStoryOne;
    }

    public void ToStoryOne()
    {
        SceneManager.LoadScene("StoryOne");
    }

    public void ToPR()
    {
        SceneManager.LoadScene("PathsRoom");
    }
}
