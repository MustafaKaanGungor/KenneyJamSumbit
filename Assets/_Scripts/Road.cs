using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    [SerializeField] private SettlementScript settlement1;
    [SerializeField] private SettlementScript settlement2;
    [SerializeField] private GameObject roadSprite;
    [SerializeField] private GameObject highlight; 

    void OnMouseEnter() {
        highlight.SetActive(true);
    }

    void OnMouseExit() {
        highlight.SetActive(false);
    }

    void OnMouseDown() {
        roadSprite.SetActive(true);
    }
}
