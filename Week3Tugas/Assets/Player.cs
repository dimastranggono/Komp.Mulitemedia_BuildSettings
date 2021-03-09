using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public Text humanText;
    private int totalHuman = 0;
    void Start()
    {
        UpdateHumanText();
    }
    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("Human"))
        {
            totalHuman++;
            UpdateHumanText();
            Destroy(hit.gameObject);
        }
    }
    private void UpdateHumanText()
    {
        string starMessage = "Humans = " + totalHuman;
        humanText.text = starMessage;
    }
}