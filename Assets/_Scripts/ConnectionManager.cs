using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectionManager : MonoBehaviour
{
    [SerializeField] private List<SettlementScript> settlements = new List<SettlementScript>();
    
    private void Start() {
        foreach (SettlementScript owner in settlements)
        {
            foreach(SettlementScript target in settlements) {
                if(owner.settlementName.Equals(target.settlementName)) {
                } else {
                    SettlementScript.connection newConnection = new SettlementScript.connection
                    {
                        target = target,
                        relationship = 50,
                        isTrading = false
                    };
                    owner.connections.Add(newConnection);
                }
            }
        }
    }
}
