using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Doublsb.Dialog;

public class N_Quaso_Start : MonoBehaviour
{
    public DialogManager DialogManager;
    // Start is called before the first frame update
    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("... Hey", "Baki"));
        
        dialogTexts.Add(new DialogData("Quaso?", "Quaso"));

        dialogTexts.Add(new DialogData("Huh?", "Baki"));

        dialogTexts.Add(new DialogData("Quaso?", "Quaso"));

        dialogTexts.Add(new DialogData("You mean... Crossaint?", "Baki"));

        dialogTexts.Add(new DialogData("Quaso!", "Quaso"));        

        var Text1 = new DialogData("Alright alright give me a second", "Baki");
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
           SceneManager.LoadScene("03_N_Quaso_Order");
        }
}
}
