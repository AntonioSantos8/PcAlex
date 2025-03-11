
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TentativasUp : MonoBehaviour
{
    [SerializeField] TMP_Text tryText;
    public static int numberOfTry;
   
    
    private void Start()
    {
      
    }
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
