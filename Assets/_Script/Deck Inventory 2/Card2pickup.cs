using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Card2pickup : MonoBehaviour
{
    public Card2 card2;
    Button cardButton;

    private void Start()
    {
        cardButton = GetComponent<Button>();
        cardButton.onClick.AddListener(OnButtonClick);
    }
    void Pickup()
    {
        InventoryManager2.Instance.Remove(card2);
        //cardButton.enabled = false;
        this.gameObject.SetActive(false);
        DeckManager.Instance.Add(card2);
        
    }

    
    public void OnButtonClick()
    {
        Pickup();
        Debug.Log("Button clicked!");
    }

}
