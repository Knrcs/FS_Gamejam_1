using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Doublsb.Dialog;

public class N_Quaso_End : MonoBehaviour
{
    public DialogManager DialogManager;
    // Start is called before the first frame update
    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("There's your Crossaint", "Baki"));
        
        dialogTexts.Add(new DialogData("Quaso!", "Quaso"));

        dialogTexts.Add(new DialogData("I think that's a goodbye?", "Baki"));

        dialogTexts.Add(new DialogData("Quaso!", "Quaso"));   

        var Text1 = new DialogData("Okay bye! (and that's also the end of the game :3 thanks for playing)", "Baki");
        Text1.SelectList.Add("Continue", "Quit Game");

        Text1.Callback = () => Check_Correct();

        dialogTexts.Add(Text1);

        DialogManager.Show(dialogTexts);
    }

    // Update is called once per frame
    private void Check_Correct()
    {
        if(DialogManager.Result == "Continue")
        {
           Application.Quit();
        }
}
}
