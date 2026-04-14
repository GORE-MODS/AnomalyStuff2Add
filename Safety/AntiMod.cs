        public static void AntiMod()
        {
            foreach (VRRig rig in VRRigCache.ActiveRigs)
            {
                if (rig.IsItemAllowed("LBAAK") || rig.IsItemAllowed("LBAAD") || rig.IsItemAllowed("LMAPY"))
                {
                    PhotonNetwork.Disconnect();
                }
            }
        }
