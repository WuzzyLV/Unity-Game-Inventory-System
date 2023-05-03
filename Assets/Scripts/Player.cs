using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField] public SpriteRenderer helmet;
    [SerializeField] public SpriteRenderer head;
    
    [SerializeField] public SpriteRenderer chestPlate;
    [SerializeField] public SpriteRenderer backArm;
    [SerializeField] public SpriteRenderer frontArm;
    
    [SerializeField] public SpriteRenderer leftLeg;
    [SerializeField] public SpriteRenderer rightLeg;
    
    [SerializeField] public SpriteRenderer rightWeapon;
    [SerializeField] public SpriteRenderer leftWeapon;
    
    [SerializeField] public SpriteRenderer leftShield;
    [SerializeField] public SpriteRenderer rightShield;

    public enum Direction
    {
        None,
        Left,
        Right
    }
    public enum Equipment
    {
        Head,
        ChestPlate,
        Helmet,
        Boots,
        Weapon,
        Shield
    }

    /*
        For chest first index is chest second is left arm third is right arm
     */
    public void SetEquipment(Equipment equipment,Direction direction , Sprite[] sprites)
    {
        switch (equipment)
        {
            case Equipment.Helmet:
                helmet.sprite = sprites[0];
                break;
            case Equipment.Head:
                head.sprite = sprites[0];
                break;
            case Equipment.ChestPlate:
                chestPlate.sprite = sprites[0];
                backArm.sprite = sprites[1];
                frontArm.sprite = sprites[2];
                break;
            case Equipment.Boots:
                leftLeg.sprite = sprites[0];
                rightLeg.sprite = sprites[0];
                break;
            case Equipment.Weapon:
                if (direction == Direction.Left)
                {
                    leftWeapon.sprite = sprites[0];
                    leftShield.sprite = null;
                }
                else
                {
                    rightWeapon.sprite = sprites[0];
                    rightShield.sprite = null;
                }
                break;
            case Equipment.Shield:
                if (direction == Direction.Left)
                {
                    leftShield.sprite = sprites[0];
                    leftWeapon.sprite = null;
                }
                else
                {
                    rightShield.sprite = sprites[0];
                    rightWeapon.sprite = null;
                }
                break;
        }
    }

    public void RemoveEquipment(Equipment equipment, Direction direction)
    {
        switch (equipment)
        {
            case Equipment.Helmet:
                helmet.sprite = null;
                break;
            case Equipment.Head:
                head.sprite = null;
                break;
            case Equipment.ChestPlate:
                chestPlate.sprite = null;
                backArm.sprite = null;
                frontArm.sprite = null;
                break;
            case Equipment.Boots:
                leftLeg.sprite = null;
                rightLeg.sprite = null;
                break;
            case Equipment.Weapon:
                if (direction == Direction.Left)
                    leftWeapon.sprite = null;
                else
                    rightWeapon.sprite = null;
                break;
            case Equipment.Shield:
                if (direction == Direction.Left)
                    leftShield.sprite = null;
                else
                    rightShield.sprite = null;
                break;
        }
    }
}
