using System.Net;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class Item : ScriptableObject
{

    public new string name;
    public string description;
    public enum Type // type of item
    {
        Healing,
        Damage,
        Utility,
        Special,
        Other,
    }
    public string lore;

    public Sprite look;

    public int attackDamage;
    public int attackSpeed;
    public int moveSpeed;
    public int health;
    public int healing;
    public int armor;

}
