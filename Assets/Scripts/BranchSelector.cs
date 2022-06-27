using UnityEngine;

public class BranchSelector : MonoBehaviour
{
    public GameObject[] branches;

    public void OnEnable()
    {
        GameEvents.cb += ShowBranch;
    }
    public void OnDisable()
    {
        GameEvents.cb -= ShowBranch;
    }
    private void Awake()
    {
        HideAllBranches();
        branches[0].gameObject.SetActive(true);
    }

    void HideAllBranches()
    {
        foreach (GameObject item in branches)
        {
            item.SetActive(false);
        }
    }

    public void ShowBranch(int branch)
    {
        HideAllBranches();
        branches[branch].gameObject.SetActive(true);
    }
}
