using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldManager : MonoBehaviour
{
    [SerializeField] private InputField myInputField;
    public Button profileButton;
    public Text statusText;
    public Text profileButtonText;

    public const string PlayerNameKey = "PlayerName";

    private string userName;

    // Start is called before the first frame update
    void Start()
    {
        myInputField.onSubmit.AddListener(myInputFieldSubmit);
        profileButton.onClick.AddListener(SelectProfileName);

        if (PlayerPrefs.HasKey(PlayerNameKey))
        {
            string storedName = PlayerPrefs.GetString(PlayerNameKey);
            statusText.text = "Perfil encontrado";
            profileButtonText.text = storedName;
            profileButton.gameObject.SetActive(true);
            myInputField.gameObject.SetActive(false);
        }
        else
        {
            statusText.text = "Perfil vacio";
            profileButton.gameObject.SetActive(false);
            myInputField.gameObject.SetActive(true);
        }
    }

    void myInputFieldSubmit(string inputText)
    {
        if (!string.IsNullOrEmpty(inputText))
        {
            PlayerPrefs.SetString(PlayerNameKey, inputText);
            statusText.text = "Perfil encontrado";
            profileButtonText.text = inputText;
            profileButton.gameObject.SetActive(true);
            myInputField.gameObject.SetActive(false);
        }
    }

    void SelectProfileName()
    {
        string storedName = PlayerPrefs.GetString(PlayerNameKey);

        statusText.text = storedName;
        profileButton.gameObject.SetActive(false);
    }
}
