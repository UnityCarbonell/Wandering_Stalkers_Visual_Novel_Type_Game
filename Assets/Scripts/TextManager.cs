using System;
using UnityEngine;
using TMPro;

public class TextManager : MonoBehaviour
{
    //Text templates
    [SerializeField] TextTemplate template;
    [SerializeField] TextTemplate[] templatesArray;

    //Text Templates Content
    public TextMeshProUGUI screenText;
    public TextMeshProUGUI ansOne;
    public TextMeshProUGUI ansTwo;
    public bool hideAfter;
    public bool hasEvent;
    public bool hasCoice;
    public string eventTag;
    public int branchTag;

    //Game Events
    public GameEvents ge;

    //Hide or Show Scrollview
    public bool hidden;
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
        hidden = false;
        template = templatesArray[0];
        ShowTexts();
    }

    public void ShowTexts()
    {
        screenText.text = template.narrativeText.ToString();
        ansOne.text = template.optionOne.ToString();
        ansTwo.text = template.optionTwo.ToString();
        hideAfter = template.hideAfter;
        hasEvent = template.hasEvent;
        hasCoice = template.hasChoice;
        eventTag = template.eventTag.ToString();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ButtonAction(0);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            ButtonAction(1);
        }
        if (Input.GetKeyDown(KeyCode.Space) && hidden == false)
        {
            HideScrollView();
        }
        else if (Input.GetKeyDown(KeyCode.Space) && hidden == true)
        {
            ShowScrollView();
        }

        //For testing propouses
        if (Input.GetKeyDown(KeyCode.R))
        {
            RechargeTexts();
        }
    }

    public void ButtonAction(int index)
    {
        if (hidden == false)
        {
            if (hasEvent == true)
            {
                if (hasCoice == true)
                {
                    branchTag = Convert.ToInt32(template.branchTag);
                    ge.ChooseEvent(eventTag, branchTag, index);
                }
                else
                {
                    ge.TaggedEvents(eventTag);
                }
                template = templatesArray[template.refArray[index]];
                ShowTexts();
            }
            else
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
        hidden = true;
    }

    void ShowScrollView()
    {
        scrollViewUI.SetTrigger("ShowScrollView");
        hidden = false;
    }

    //For testing propouses
    private void RechargeTexts()
    {
        screenText.text = template.narrativeText.ToString();

        Debug.Log("Reolading Texts");
    }
}
