using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Style", menuName = "Style", order = 51)]
public class UIStyle : ScriptableObject
{
    [field: SerializeField] public Sprite charButtonDefault { get; private set; }
    [field: SerializeField] public Sprite charButtonGreen { get; private set; }
    [field: SerializeField] public Sprite charButtonYellow { get; private set; }
    [field: SerializeField] public Sprite charButtonGray { get; private set; }
    [field: SerializeField]public Sprite background { get;private set; }
    [field:SerializeField]public Sprite menuBackground { get; private set; }
    [field: SerializeField] public Sprite keyboardBackground {  get; private set; }
}
