using UnityEngine;

public class GameEvents : MonoBehaviour
{
    //Events of the Paths' Room
    public delegate void HideScrollView();
    public static event HideScrollView hsv;

    public void HSV()
    {
        hsv();
    }
}
