using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockLine : MonoBehaviour
{
    private bool isLocked;
    [SerializeField] private GameObject lockSprite;
    [SerializeField]private List<Image> renderers = new List<Image>();
    public event Action onUnlock;
    public event Action onLock;
    private void Start()
    {
        Lock();
    }
    public void Lock()
    {
        onLock?.Invoke();
        lockSprite.SetActive(true);
        isLocked = true;
        foreach (var item in renderers)
        {
            item.color = new Color(0.7f, 0.7f, 0.7f, 1);
            
        }
    }
    
    public void Unlock()
    {
        onUnlock?.Invoke();
        lockSprite.SetActive(false);
        isLocked = false;
        foreach (var item in renderers)
        {
            item.color = Color.white;
        }
    }
}
