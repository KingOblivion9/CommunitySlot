using CalamityMod.Items.Accessories;
using CalamityMod.Schematics;
using Terraria;
using Terraria.ModLoader;

namespace ComSlot;

public class CommunitySlot : ModAccessorySlot
{
    public override string FunctionalTexture => "ComSlot/TheCommunity";

    public override bool CanAcceptItem(Item checkItem, AccessorySlotType context)
	{
		if (checkItem.type == ModContent.ItemType<TheCommunity>())
		{
			return true;
		}
        if (checkItem.type == ModContent.ItemType<ShatteredCommunity>())
        {
            return true;
        }
        return false;
	}

	public override bool ModifyDefaultSwapSlot(Item item, int accSlotToSwapTo)
	{
		if (item.type == ModContent.ItemType<TheCommunity>())
		{
			return true;
		}
		if (item.type == ModContent.ItemType<ShatteredCommunity>())
		{
			return true;
		}
		return false;
	}
    public override void OnMouseHover(AccessorySlotType context)
    {
        if (context == AccessorySlotType.DyeSlot)
        {
            Main.hoverItemName = "Dye";
        }
        if (context == AccessorySlotType.VanitySlot)
        {
            Main.hoverItemName = "Vanity Slot";
        }
        if (context == AccessorySlotType.FunctionalSlot)
        {
            Main.hoverItemName = "The Community";
        }
    }
    public override bool IsVisibleWhenNotEnabled()
	{
		return false;
	}
}
