using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(EntityController))]
public class EntityPlayerBehaviour : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    EntityController controller;

    private void OnValidate()
    {
        if(controller == null) controller = GetComponent<EntityController>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Left) controller.MoveForward();
        if(eventData.button == PointerEventData.InputButton.Right) controller.RotateLeft();
    }

}
