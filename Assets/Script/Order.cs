using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Order : MonoBehaviour
{
    public CustomerScore items;
    public int score;
    public Button btn = null;

    [Header("Drinks")]
    public bool ord_Mocha;
    public bool ord_Espresso;
    public bool ord_Latte_Macchiato;
    public bool ord_Cappuchino;
    public bool ord_White_Chocolate;
    public bool ord_Hot_Chocolate;
    
    [Header("Food")]
    public bool ord_BlueberryMuffin;
    public bool ord_Brownies;
    public bool ord_Cheesecake;
    public bool ord_Cinnamon_rolls;
    public bool ord_Cookies;
    public bool ord_Crossiant;
    public bool ord_Macaroons;
    // Start is called before the first frame update
    void Awake()
    {
        // adding a delegate with no parameters
        btn.onClick.AddListener(NoParamaterOnclick);
           
        // adding a delegate with parameters
        btn.onClick.AddListener(delegate{ParameterOnClick("Button was pressed!");});
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CheckOrder()
    {
        if (items.I_Mr_Browns)
        {
            if(items.Espresso == true && ord_Espresso == true)
            {
                score += 1;
                items.Espresso = false;
                ResetOrder();
                SceneManager.LoadScene("01_Mr.Browns_end");
            }
            else
            {
                items.Espresso = false;
                ResetOrder(); 
                SceneManager.LoadScene("01_Mr.Browns_end");              
            }
        }

        if (items.I_Sparkle)
        {
            if (items.Latte_Macchiato == true && ord_Latte_Macchiato == true && items.BlueberryMuffin == true && ord_BlueberryMuffin == true)
            {
                score += 1;
                items.Latte_Macchiato = false;
                items.BlueberryMuffin = false;
                ResetOrder();
                SceneManager.LoadScene("02_M_Sparkle_end"); 
            }
            else
            {
                items.Latte_Macchiato = false;
                items.BlueberryMuffin = false;
                ResetOrder(); 
                SceneManager.LoadScene("02_M_Sparkle_end");                
            }
        }

        if (items.II_Quaso)
        {
            if(items.Crossiant == true && ord_Crossiant == true)
            {
                score += 1;
                items.Crossiant = false;
                ResetOrder();
                SceneManager.LoadScene("03_N_Quaso_End");
            }
            else
            {
                items.Crossiant = false;
                ResetOrder(); 
                SceneManager.LoadScene("03_N_Quaso_End");              
            }
        }
    }

    private void NoParamaterOnclick()
    {
        Debug.Log("Button clicked with no parameters");
    }
    
    private void ParameterOnClick(string test)
    {
        CheckOrder();
    }

     public void Z_Mocha(){
         ord_Mocha = !ord_Mocha;
     }
     
     public void Z_Espresso(){
         ord_Espresso = !ord_Espresso;
     }

     public void Z_Latte_Macciato(){
         ord_Latte_Macchiato = !ord_Latte_Macchiato;
     }

     public void Z_Cappuchino(){
         ord_Cappuchino = !ord_Cappuchino;
     }

     public void Z_White_Chocolate(){
         ord_White_Chocolate = !ord_White_Chocolate;
     }

     public void Z_Hot_Chocolate(){
         ord_Hot_Chocolate = !ord_Hot_Chocolate;
     }


     public void Y_BlueberryMuffin(){
         ord_BlueberryMuffin = !ord_BlueberryMuffin;
     }

     public void Y_Brownies(){
         ord_Brownies = !ord_Brownies;
     }

     public void Y_Cheesecake(){
         ord_Cheesecake = !ord_Cheesecake;
     }

     public void Y_Cinnamon_rolls(){
         ord_Cinnamon_rolls = !ord_Cinnamon_rolls;
     }

     public void Y_Cookies(){
         ord_Cookies = !ord_Cookies;
     }

     public void Y_Crossiant(){
         ord_Crossiant = !ord_Crossiant;
     }

     public void Y_Macaroons(){
         ord_Macaroons = !ord_Macaroons;
     }

    void ResetOrder()
    {
        // Hot Drink
        
        ord_Mocha = false;
        ord_Espresso = false;
        ord_Latte_Macchiato = false;
        ord_Cappuchino = false;
        ord_White_Chocolate = false;
        ord_Hot_Chocolate = false;

        // Foof
        
        ord_BlueberryMuffin = false;
        ord_Brownies = false;
        ord_Cheesecake = false;
        ord_Cinnamon_rolls = false;
        ord_Cookies = false;
        ord_Crossiant = false;
        ord_Macaroons = false;        
    }
}
