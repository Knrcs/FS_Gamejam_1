using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Doublsb.Dialog;

public class M_Sparkle_Start : MonoBehaviour
{
    public DialogManager DialogManager;
    // Start is called before the first frame update
    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("Heya I'm Baki! What can I do for you today?", "Baki"));
        
        dialogTexts.Add(new DialogData("I would like to have a latte macchiato please", "Sparkle"));

        dialogTexts.Add(new DialogData("Good choice! Anything to go with that?", "Baki"));

        dialogTexts.Add(new DialogData("Oh those Blueberry Muffins look delicious, I want one of those pleaaase!", "Sparkle"));

        var Text1 = new DialogData("Alright, gimme a second!", "Baki");
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
           SceneManager.LoadScene("02_M_Sparkle_Order");
        }
}
}
