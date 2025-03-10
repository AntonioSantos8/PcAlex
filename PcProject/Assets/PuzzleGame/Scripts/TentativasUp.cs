
using TMPro;
using UnityEngine;

public class TentativasUp : MonoBehaviour
{
    [SerializeField] TMP_Text tryText;
    public static int numberOfTry;
    void Update()
    {
        tryText.text = "Tentativas: " + numberOfTry.ToString();
    }
    public void TryUp()
    {
        numberOfTry++;
    }
    public void TryReset()
    {
        numberOfTry = 0;
    }
}
