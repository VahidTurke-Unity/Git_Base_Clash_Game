using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class _TestDragUi : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler{
   
        public static GameObject ItemBeginDraged;
        Vector3 StartPosition;
        Transform startParent;

        public void OnBeginDrag(PointerEventData eventData)
        {
            ItemBeginDraged = gameObject;
            StartPosition = transform.position;
            startParent = transform.parent;
            GetComponent<CanvasGroup>().blocksRaycasts = false;
        }

        public void OnDrag(PointerEventData eventData)
        {
            transform.position = Input.mousePosition;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            ItemBeginDraged = null;
            GetComponent<CanvasGroup>().blocksRaycasts = true;

            if (startParent == transform.parent)
            {
                transform.position = StartPosition;

            }
        }
    }

