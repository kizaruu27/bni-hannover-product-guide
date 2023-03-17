using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DescriptionUIHandler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI descriptionText;
    [SerializeField] private Animator anim;

    private void OnEnable()
    {
        anim.Play("Pop Up_Anim");
    }

    // private void Start()
    // {
    //     gameObject.SetActive(false);
    // }

    public void SetDescription(string desc)
    {
        descriptionText.text = desc;
    }
}
