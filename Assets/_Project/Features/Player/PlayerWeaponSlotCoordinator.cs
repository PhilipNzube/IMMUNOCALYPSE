using UnityEngine;

public class PlayerWeaponSlotCoordinator
{
    public void SetWeaponSlotActive(GameObject[] weapons, int activeIndex)
    {
        if (weapons == null) return;
        for (int i = 0; i < weapons.Length; i++)
        {
            if (weapons[i] != null)
            {
                weapons[i].SetActive(i == activeIndex);
            }
        }
    }

    public void DeactivateAll(GameObject[] weapons)
    {
        if (weapons == null) return;
        for (int i = 0; i < weapons.Length; i++)
        {
            if (weapons[i] != null)
            {
                weapons[i].SetActive(false);
            }
        }
    }
}
