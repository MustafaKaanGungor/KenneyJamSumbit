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

    public List<connection> connections = new List<connection>();

    void OnMouseDown() {
        communicationPanel.gameObject.SetActive(true);
        communicationPanel.SetPanelActive(this);
    }

    void OnMouseEnter() {
        hightlight.SetActive(true);
    }

    void OnMouseExit() {
        hightlight.SetActive(false);
    }
}
