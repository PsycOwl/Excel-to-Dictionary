using TMPro;
using UnityEngine;
using System.Collections.Generic;

public class TextController : MonoBehaviour {

    public List<TextMeshProUGUI> TextMeshProUGUIs;
    SystemLanguage Language;
    
	void Start () {
        Language = GameController.Instance.Language;
        foreach (TextMeshProUGUI TextMeshPro in TextMeshProUGUIs)
        {
            //Debug.Log(TextMeshPro.text);
            TextMeshPro.text = Localization.GetEquivalent(TextMeshPro.text.Trim(), Language);
        }
    }

    public void UpdateLanguage()
    {
        //Reverse everything to english
        foreach (TextMeshProUGUI TextMeshPro in TextMeshProUGUIs)
        {
            //Debug.Log(TextMeshPro.text);
            TextMeshPro.text = Localization.GetReversedEquivalent(TextMeshPro.text.Trim(), Language);
        }
        //Re-Change everything from english to detected language
        Language = GameController.Instance.Language;
        foreach (TextMeshProUGUI TextMeshPro in TextMeshProUGUIs)
        {
            //Debug.Log(TextMeshPro.text);
            TextMeshPro.text = Localization.GetEquivalent(TextMeshPro.text.Trim(), Language);
        }
    }
}