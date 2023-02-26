using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Doublsb.Dialog;

public class M_Browns_Starts : MonoBehaviour
{
    public DialogManager DialogManager;
    // Start is called before the first frame update
    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("Good Morning!", "Baki"));
        
        dialogTexts.Add(new DialogData("Oh Oh Good Morning Mr. Brown, how can I serve today?", "Baki"));

        dialogTexts.Add(new DialogData("I would like the same as usual, an Espresso to go!", "Mr. Brown"));

        var Text1 = new DialogData("Alrighty! one Espresso to go, coming right up!", "Baki");
        Text1.SelectList.Add("Continue", "Get to work!");

        Text1.Callback = () => Check_Correct();

        dialogTexts.Add(Text1);

        DialogManager.Show(dialogTexts);
    }

    // Update is called once per frame
    private void Check_Correct()
    {
        if(DialogManager.Result == "Continue")
        {
           SceneManager.LoadScene("01_M_Browns_Order");
        }
}
}
