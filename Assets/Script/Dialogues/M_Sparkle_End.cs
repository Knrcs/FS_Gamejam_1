using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Doublsb.Dialog;

public class M_Sparkle_End : MonoBehaviour
{
    public DialogManager DialogManager;
    // Start is called before the first frame update
    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("Here you go Mam", "Baki"));
        
        dialogTexts.Add(new DialogData("Thank you so much! My name is Sparkle ", "Sparkle"));

        dialogTexts.Add(new DialogData("Oh Awesome Sparkle! Have a lovely day ", "Baki"));

        var Text1 = new DialogData("Thank you! You too!", "Sparkle");
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
           SceneManager.LoadScene("03_N_Quaso_Start");
        }
}
}
