/// <summary>
/// $Nosville Command
/// </summary>
/// <param name="WarpPacket"></param>
public void Warp(WarpPacket warppacket)
{
    if (warppacket.Data != null)
    {
        if (Session.Character.MapId > 153 || Session.Character.MapId < 130)
        {
            string Location = warppacket.Data;
            if (Session.Character.HasShopOpened || Session.Character.InExchangeOrTrade)
            {
                Session.Character.Dispose();
            }
            if (Session.Character.IsChangingMapInstance)
            {
                return;
            }

            switch (Location.ToUpper())
            {
                case "ICE":
                    ServerManager.Instance.ChangeMap(Session.Character.CharacterId, 145, 51, 41);
                    break;
                case "HOME":
                    ServerManager.Instance.ChangeMap(Session.Character.CharacterId, 75, 11, 17);
                    break;
                case "LDT":
                    ServerManager.Instance.ChangeMap(Session.Character.CharacterId, 98, 6, 35);
                    break;
            }
        }
    }
}