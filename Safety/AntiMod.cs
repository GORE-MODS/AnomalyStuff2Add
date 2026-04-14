       public static void AntiMod()
        {
            foreach (VRRig rig in VRRigCache.ActiveRigs)
            {
                if (rig._playerOwnedCosmetics.Concat().Contains("LBAAK") || rig._playerOwnedCosmetics.Concat().Contains("LBAAD") || rig._playerOwnedCosmetics.Concat().Contains("LMAPY"))
                {
                    PhotonNetwork.Disconnect();
                }
            }
        }
