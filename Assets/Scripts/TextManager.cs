using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextManager : MonoBehaviour
{
    [SerializeField] TextTemplate template;
    [SerializeField] TextTemplate[] templatesArray;

    public TextMeshProUGUI screenText;
    public TextMeshProUGUI ansOne;
    public TextMeshProUGUI ansTwo;

    public bool hideAfter;
    public bool isHidden;

    public GameEvents ge;

    public Animator scrollViewUI;

    public void OnEnable()
    {
        GameEvents.hsv += HideScrollView;
        GameEvents.ssv += ShowScrollView;
    }
    public void OnDisable()
    {
        GameEvents.hsv -= HideScrollView;
        GameEvents.ssv -= ShowScrollView;
    }
    void Awake()
    {
        template = templatesArray[0];
        ShowTexts();
        isHidden = false;
    }

    public void ShowTexts()
    {
        screenText.text = template.narrativeText.ToString();
        ansOne.text = template.optionOne.ToString();
        ansTwo.text = template.optionTwo.ToString();
        hideAfter = template.hideAfter;
    }

    public void ButtonAction(int index)
    {
        if (hideAfter == true)
        {
            ge.HSV();
        }
        else
        {
            template = templatesArray[template.refArray[index]];
            ShowTexts();
        }
    }

    public void StorySelector(int index)
    {
        ge.SSV();
        template = templatesArray[index];
        ShowTexts();

    }

    void HideScrollView()
    {
        scrollViewUI.SetTrigger("HideScrollView");
        isHidden = true;
    }

    void ShowScrollView()
    {
        scrollViewUI.SetTrigger("ShowScrollView");
        isHidden = false;
    }
}
