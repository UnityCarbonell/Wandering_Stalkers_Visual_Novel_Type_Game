using UnityEngine;
using TMPro;

public class TextManager : MonoBehaviour
{
    [SerializeField] TextTemplate template;
    [SerializeField] TextTemplate[] templatesArray;

    [SerializeField] TextMeshProUGUI narrativeText;
    [SerializeField] TextMeshProUGUI optionOneText;
    [SerializeField] TextMeshProUGUI optionTwoText;

    private void Start()
    {
        template = templatesArray[0];
        ShowText();
    }

    void ShowText()
    {
        narrativeText.text = template.narrativeText;
        optionOneText.text = template.optionOne;
        optionTwoText.text = template.optionTwo;
    }

    public void ButtonsManager(int index)
    {
        template = templatesArray[template.refsArray[index]];
        ShowText();
    }
}
