using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ConnectionPanelScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI titleText;
    [SerializeField] TextMeshProUGUI leaderNameText;
    [SerializeField] List<RelationMeterScript> relationMeters = new List<RelationMeterScript>();

    public void SetPanelActive(SettlementScript owner) {
        titleText.text = owner.settlementName;
        leaderNameText.text = owner.leaderName;
        owner.leaderPortrait.SetActive(true);

        for(int i = 0; i < relationMeters.Count; i++) {
            string targetToownerValue = "";
            for(int j = 0; j < relationMeters.Count; j++) {
                if(owner.connections[i].target.connections[j].target.Equals(owner)) {
                    targetToownerValue = owner.connections[i].target.connections[j].relationship.ToString();
                }
            }
            relationMeters[i].SetRelationMeter(owner.connections[i].target.settlementName,owner.connections[i].relationship.ToString(),targetToownerValue);
            }
        
    }
}
