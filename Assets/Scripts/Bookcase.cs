using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bookcase : MonoBehaviour, IInteractable

{
    [SerializeField] private Transform baseObject;
    [SerializeField] private Transform outlineObject;

    Transform IInteractable.baseObject { get { return baseObject; } set { baseObject = value; } }
    Transform IInteractable.outlineObject { get { return outlineObject; } set {  outlineObject = value; } }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
