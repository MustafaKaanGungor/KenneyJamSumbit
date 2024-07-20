using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class CastleScript : SettlementScript
{
    [SerializeField] private GameObject sprite;
    private SpriteResolver spriteResolver;
    private SpriteLibrary spriteLibrary;
    private SpriteLibraryAsset spriteLibraryAsset;

    private void Start() {
        spriteResolver = sprite.GetComponent<SpriteResolver>();
        spriteLibrary = spriteResolver.spriteLibrary;
        spriteLibraryAsset = spriteLibrary.spriteLibraryAsset;

        ValueChanger(Random.Range(0,9));
    }

    public void ValueChanger(int number) {
        string heyo = spriteLibraryAsset.GetCategoryLabelNames("Castles").ElementAt(number);
        spriteResolver.SetCategoryAndLabel("Castles",heyo);
    }
}
