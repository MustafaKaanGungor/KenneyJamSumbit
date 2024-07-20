using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RelationMeterScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI targetText;
    [SerializeField] TextMeshProUGUI ownerToTargetText;
    [SerializeField] TextMeshProUGUI targetToOwnerText;

    public void SetRelationMeter(string target, string ownerToTarget, string targetToOwner) {
        targetText.text = target;
        ownerToTargetText.text = ownerToTarget;
        targetToOwnerText.text = targetToOwner;
    }
}
