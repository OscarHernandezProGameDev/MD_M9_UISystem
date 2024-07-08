using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownManager : MonoBehaviour
{
    public Dropdown myDropdown;
    public InputField inputField;
    public Button addButton;
    public Button removeButton;

    Dropdown.OptionData newData, newData2;
    List<Dropdown.OptionData> newDataList = new List<Dropdown.OptionData>();


    // Start is called before the first frame update
    void Start()
    {
        myDropdown.ClearOptions();

        newData = new Dropdown.OptionData();
        newData.text = "Option 1";
        newDataList.Add(newData);

        newData2 = new Dropdown.OptionData();
        newData2.text = "Option 2";
        newDataList.Add(newData2);

        foreach (Dropdown.OptionData data in newDataList)
        {
            myDropdown.options.Add(data);
        }

        addButton.onClick.AddListener(AddOption);
        removeButton.onClick.AddListener(RemoveOption);
    }

    void AddOption()
    {
        string option = inputField.text;

        if (!string.IsNullOrEmpty(option))
        {
            myDropdown.options.Add(new Dropdown.OptionData(option));

            myDropdown.RefreshShownValue();
            inputField.text = "";
        }
    }

    void RemoveOption()
    {
        string option = inputField.text;

        if (!string.IsNullOrEmpty(option))
        {
            for(int i = 0; i < myDropdown.options.Count; i++)
            {
                if(myDropdown.options[i].text == option)
                {
                    myDropdown.options.RemoveAt(i);
                    myDropdown.RefreshShownValue();
                    inputField.text = "";
                }
            }
        }
    }
}
