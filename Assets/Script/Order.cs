using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Order : MonoBehaviour
{
    public CustomerScore items;
    public int score;

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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CheckOrder()
    {
        if (items.I_Mr_Browns)
        {
            if(items.Espresso = ord_Espresso)
            {
                score += 1;
                items.Espresso = false;
                ResetOrder();
                
            }
        }

        if (items.I_Sparkle)
        {
            if (items.Latte_Macchiato == ord_Latte_Macchiato && items.BlueberryMuffin == ord_BlueberryMuffin)
            {
                score += 1;
                items.Latte_Macchiato = false;
                ResetOrder();
            }
        }
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
