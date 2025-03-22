using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Card2pickup : MonoBehaviour
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
        InventoryManager2.Instance.Remove(card);
        //cardButton.enabled = false;
        this.gameObject.SetActive(false);
        DeckManager.Instance.Add(card);
        
    }

    
    public void OnButtonClick()
    {
        //Debug.Log("count" + DeckManager.Instance.setMaxDeckSize());
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
