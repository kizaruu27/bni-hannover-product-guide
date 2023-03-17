using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
    [SerializeField] private string targetCollider;

    public UnityEvent OnTriggerEvent;
    public UnityEvent OnTriggerExitEvent;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == targetCollider)
            OnTriggerEvent.Invoke();
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.tag == targetCollider)
            OnTriggerExitEvent?.Invoke();
    }
    
}
