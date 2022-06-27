using UnityEngine;

public class BranchScript : MonoBehaviour
{
    public GameObject[] branchScenes;

    public int sceneOnDisplay;

    protected virtual void OnEnable()
    {
        GameEvents.somb += IncreaseVar;
        GameEvents.socb += HideBranch;
    }
    protected virtual void OnDisable()
    {
        GameEvents.somb -= IncreaseVar;
        GameEvents.socb -= HideBranch;
    }
    public void Awake()
    {
        sceneOnDisplay = 0;
        SceneDisplay(sceneOnDisplay);
        gameObject.SetActive(true);
    }
    void SceneDisplay(int index)
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

    void HideBranch()
    {
        gameObject.SetActive(false);
    }
}
