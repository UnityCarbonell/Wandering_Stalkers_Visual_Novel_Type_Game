using UnityEngine;

[CreateAssetMenu (menuName = "TextObj")]
public class TextTemplate : ScriptableObject
{
    [TextArea(3, 15)]
    public string narrativeText;

    [Space(20)]
    public string optionOne;
    public string optionTwo;

    [Space(20)]
    public int[] refArray = new int[2];

    [Space(20)]
    public bool hideAfter;
    public bool hasEvent;
    public bool hasChoice;

    [Space(20)]
    public string eventTag;
    public string branchTag;
}
