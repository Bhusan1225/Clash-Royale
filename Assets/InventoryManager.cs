using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
  [SerializeField] private GameObject slotHolder;
  //[SerializeField] private CARD itemToAdd;
  //[SerializeField] private CARD itemToRemove;

  [SerializeField] private List<CARD> cards = new List<CARD>(); //use list as the Card count will increase in future and code modularity

  private GameObject[] slots; //use Array





    private void Start()
    {
        slots = new GameObject[slotHolder.transform.childCount];

        //set all the slots
        for (int i = 0; i < slotHolder.transform.childCount; i++)
        {
            slots[i] = slotHolder.transform.GetChild(i).gameObject;
        }
        RefreshUI();
        //if I increase the slotHolder's child it will increase the slot - and this is modular code


        //Add(itemToAdd);
        //Remove(itemToRemove);
    }

    public void RefreshUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            try
            {
                slots[i].transform.GetChild(0).GetComponent<Image>().enabled = true;
                slots[i].transform.GetChild(0).GetComponent<Image>().sprite = cards[i].cardIcon;
            }
            catch 
            {

                slots[i].transform.GetChild(0).GetComponent<Image>().sprite = null;
                slots[i].transform.GetChild(0).GetComponent<Image>().enabled = false;
            }
            
        }
    }



    public void Add(CARD card)
    {
        
        cards.Add(card);
        RefreshUI();
    }

    public void Remove (CARD card)
    {
        
        cards.Remove(card);
        RefreshUI();
    }

}
