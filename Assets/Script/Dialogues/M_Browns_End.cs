using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Doublsb.Dialog;

public class M_Browns_End : MonoBehaviour
{
    public DialogManager DialogManager;
    // Start is called before the first frame update
    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("Here you go, one Espresso to go!", "Baki"));
        
        dialogTexts.Add(new DialogData("Thank you! See you in the afternoon!", "Baki"));

        dialogTexts.Add(new DialogData("Have a good day at Work Mr. Brown", "Mr. Brown"));

        var Text1 = new DialogData("Thank you, you too!", "Baki");
        Text1.SelectList.Add("Continue", "Continue");

        Text1.Callback = () => Check_Correct();

        dialogTexts.Add(Text1);

        DialogManager.Show(dialogTexts);
    }

    // Update is called once per frame
    private void Check_Correct()
    {
        if(DialogManager.Result == "Continue")
        {
           SceneManager.LoadScene("02_M_Sparkle_Start");
        }
}
}
