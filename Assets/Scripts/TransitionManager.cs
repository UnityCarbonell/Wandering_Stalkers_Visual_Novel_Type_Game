using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionManager : MonoBehaviour
{
    public void NotYet()
    {
        Debug.LogWarning("This story has not been written yet");
    }

    public void ToPR()
    {
        SceneManager.LoadScene("PathsRoom");
    }
}
