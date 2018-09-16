using UnityEngine;
using UnityEngine.UI;

public class Credits : MonoBehaviour
{
    public Text text;
   public void Quit()
    {
        Application.Quit();
    }
    public void ChangeText()
    {
        text.text = " Oh, honey, don't be so sad ... Look! \nThe text changes color!";
    }
}
