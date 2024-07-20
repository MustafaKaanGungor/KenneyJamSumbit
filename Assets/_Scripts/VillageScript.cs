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
    }

    public void ValueChanger(int number) {
        string heyo = spriteLibraryAsset.GetCategoryLabelNames("Villages").ElementAt(number);
        spriteResolver.SetCategoryAndLabel("Villages",heyo);
    }
}
