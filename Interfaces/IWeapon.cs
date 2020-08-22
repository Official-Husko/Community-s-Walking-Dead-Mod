﻿using GTA.Native;

namespace CWDM.Interfaces
{
    public interface IWeapon
    {
        int Ammo
        {
            get;
            set;
        }

        WeaponHash Hash
        {
            get;
            set;
        }

        WeaponComponent[] Components
        {
            get;
            set;
        }
    }
}
