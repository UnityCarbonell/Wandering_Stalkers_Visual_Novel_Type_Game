using UnityEngine;

public class BranchScript : MonoBehaviour
{
    public GameObject[] branchScenes;

    public int sceneOnDisplay;

    protected virtual void OnEnable()
    {
        GameEvents.ba += IncreaseVar;
        GameEvents.cb += ResetVar;
    }
    protected virtual void OnDisable()
    {
        GameEvents.ba -= IncreaseVar;
        GameEvents.cb -= ResetVar;
    }
    protected virtual void Awake()
    {
        sceneOnDisplay = 0;
        SceneDisplay(sceneOnDisplay);
    }
    protected void SceneDisplay(int index)
    {
        foreach (GameObject item in branchScenes)
        {
            item.SetActive(false);
        }
        branchScenes[index].SetActive(true);
    }
    void IncreaseVar()
    {
        sceneOnDisplay++;
        SceneDisplay(sceneOnDisplay);
    }

    void ResetVar(int index)
    {
        Debug.Log("Displaying branch no." + index.ToString() + ".");
        sceneOnDisplay = 0;
        SceneDisplay(sceneOnDisplay);
    }
}
