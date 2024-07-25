using System.Linq;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class VillageScript : SettlementScript
{
    [SerializeField] private GameObject sprite;
    private SpriteResolver spriteResolver;
    private SpriteLibrary spriteLibrary;
    private SpriteLibraryAsset spriteLibraryAsset;

    private void Start() {
        spriteResolver = sprite.GetComponent<SpriteResolver>();
        spriteLibrary = spriteResolver.spriteLibrary;
        spriteLibraryAsset = spriteLibrary.spriteLibraryAsset;

        ValueChanger(Random.Range(0,10));

        inventory.Add(InventoryItems.WOOD,1);
        inventory.Add(InventoryItems.WOOL,1);
        inventory.Add(InventoryItems.FOOD,1);
        inventory.Add(InventoryItems.TOOL,1);
        inventory.Add(InventoryItems.IRON,1);

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

        Debug.Log(inventory.Count);
        Debug.Log(inventory[InventoryItems.WOOD]);
        Debug.Log(inventory[InventoryItems.WOOL]);
        Debug.Log(inventory[InventoryItems.FOOD]);
        Debug.Log(inventory[InventoryItems.TOOL]);
        Debug.Log(inventory[InventoryItems.IRON]);
    }

    public void ValueChanger(int number) {
        string heyo = spriteLibraryAsset.GetCategoryLabelNames("Villages").ElementAt(number);
        spriteResolver.SetCategoryAndLabel("Villages",heyo);
    }
    
}
