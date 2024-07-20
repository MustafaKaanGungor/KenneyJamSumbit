using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class SettlementScript : MonoBehaviour
{
    [SerializeField] private GameObject hightlight;
    [SerializeField] private ConnectionPanelScript communicationPanel;
    [SerializeField] public string settlementName;
    [SerializeField] public GameObject leaderPortrait;
    [SerializeField] public string leaderName;

    public struct connection
    {
        public SettlementScript target;
        public int relationship;
        public bool isTrading;
    }

    Dictionary<InventoryItems, int> inventory = new Dictionary<InventoryItems, int>();

    public List<connection> connections = new List<connection>();

    void OnMouseDown() {
        communicationPanel.gameObject.SetActive(true);
        communicationPanel.SetPanelActive(this);
        Debug.Log(inventory.Count);
        Debug.Log(inventory[InventoryItems.WOOD]);
        Debug.Log(inventory[InventoryItems.WOOL]);
        Debug.Log(inventory[InventoryItems.FOOD]);
        Debug.Log(inventory[InventoryItems.TOOL]);
        Debug.Log(inventory[InventoryItems.IRON]);

    }

    void OnMouseEnter() {
        hightlight.SetActive(true);
    }

    void OnMouseExit() {
        hightlight.SetActive(false);
    }

    private void Start() {
        inventory.Add(InventoryItems.WOOD,0);
        inventory.Add(InventoryItems.WOOL,0);
        inventory.Add(InventoryItems.FOOD,0);
        inventory.Add(InventoryItems.TOOL,0);
        inventory.Add(InventoryItems.IRON,0);


        int minVal = -1, maxVal = 2;
        inventory[InventoryItems.WOOD] = Random.Range(minVal, maxVal);
        if(inventory[InventoryItems.WOOD] == -1) {
            minVal = 0;
        } else if(inventory[InventoryItems.WOOD] > 0) {
            maxVal = 0;
        }

        inventory[InventoryItems.WOOL] = Random.Range(minVal, maxVal);
        minVal = -1;
        maxVal = 2;
        if(inventory[InventoryItems.WOOL] == -1) {
            minVal = 0;
        } else if(inventory[InventoryItems.WOOL] > 0) {
            maxVal = 0;
        }

        inventory[InventoryItems.FOOD] = Random.Range(minVal, maxVal);
        minVal = -1;
        maxVal = 2;
        if(inventory[InventoryItems.FOOD] == -1) {
            minVal = 0;
        } else if(inventory[InventoryItems.FOOD] > 0) {
            maxVal = 0;
        }

        inventory[InventoryItems.TOOL] = Random.Range(minVal, maxVal);
        minVal = -1;
        maxVal = 2;
        if(inventory[InventoryItems.TOOL] == -1) {
            minVal = 0;
        } else if(inventory[InventoryItems.TOOL] > 0) {
            maxVal = 0;
        }

        inventory[InventoryItems.IRON] = Random.Range(minVal, maxVal);
        minVal = -1;
        maxVal = 2;
        if(inventory[InventoryItems.IRON] == -1) {
            minVal = 0;
        } else if(inventory[InventoryItems.IRON] > 0) {
            maxVal = 0;
        }
    }
}

public enum InventoryItems {
    WOOD,
    WOOL,
    FOOD,
    TOOL,
    IRON,
}
