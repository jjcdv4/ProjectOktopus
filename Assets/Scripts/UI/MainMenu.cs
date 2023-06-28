using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject instructionText;
    [SerializeField] private GameObject creditsText;
    private bool instruction = false;
    private bool credits= false;
    [SerializeField] private ScriptableObjectINT allPlayermoney;
    [SerializeField] private ScriptableObjectINT levelPriceMultiplication;
    public void PlayGame ()
    {
        levelPriceMultiplication.value = 1f;
        allPlayermoney.value = 500;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame ()
    {
        Debug.Log("Exit");
        Application.Quit();
    }

    public void Instructions ()
    {
        instructionText.SetActive(instruction);
        instruction = !instruction;
    }

    public void Credits()
    {
        creditsText.SetActive(credits);
        credits = !credits;
    }
}