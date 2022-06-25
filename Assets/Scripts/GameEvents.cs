using UnityEngine;

public class GameEvents : MonoBehaviour
{
    //Events of the PathsRoom
    public delegate void HideScrollView();
    public static event HideScrollView hsv;

    public delegate void ShowScrollView();
    public static event ShowScrollView ssv;

    public void HSV()
    {
        hsv();
    }

    public void SSV()
    {
        ssv();
    }
}
