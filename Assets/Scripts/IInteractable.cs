using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable {

    public Transform baseObject { get; set; }
    public Transform outlineObject { get; set; }

    public void OnInteract() {
        Debug.Log("Interact!");
    }


}
