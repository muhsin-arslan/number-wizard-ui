using TMPro;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int highestNumber;
    [SerializeField] int lowestNumber;
    [SerializeField] TextMeshProUGUI guessedNumberText;

    private int _guessedNumber = 500;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        highestNumber++;
        Guess();
    }

    public void OnPressHigher()
    {
        lowestNumber = _guessedNumber;
        Guess();
    }

    public void OnPressLower()
    {
        highestNumber = _guessedNumber;
        Guess();
    }

    private void Guess()
    {
        _guessedNumber = (highestNumber + lowestNumber) / 2;
        guessedNumberText.text = $"Is your guessed number {_guessedNumber}?";
    }
}