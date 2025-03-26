using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Cardpickup : MonoBehaviour
{
    public Card card;
    Button cardButton;
    
    private void Start()
    {
        cardButton = GetComponent<Button>();
        cardButton.onClick.AddListener(OnButtonClick);
    }
    void Pickup()
    {
       

        DeckManager.Instance.Add(card);
        InventoryManager2.Instance.Remove(card);
        this.gameObject.SetActive(false);


    }


    public void OnButtonClick()
    {
        
        if(DeckManager.Instance.CARDS.Count < DeckManager.Instance.getMaxDeckSize())
        {
            Pickup();
            Debug.Log("You picked a card");
        }
        else
        {
            Debug.Log("You can not able to pick a card");
        }
            
    }
}
