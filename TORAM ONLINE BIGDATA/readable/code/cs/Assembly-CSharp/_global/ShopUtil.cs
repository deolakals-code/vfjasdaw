// Assembly: Assembly-CSharp.dll
// Namespace: 
public static class ShopUtil // TypeDefIndex: 8472
{
	// Methods

	// RVA: 0x1D72DD0 Offset: 0x1D6EDD0 VA: 0x1D72DD0
	public static string InputSpina(string val) { }

	// RVA: 0x1D72EBC Offset: 0x1D6EEBC VA: 0x1D72EBC
	public static string IntToCommaString(long intValue) { }

	// RVA: 0x1D72F3C Offset: 0x1D6EF3C VA: 0x1D72F3C
	public static string IntToCommaStringWithUnit(long intValue, string unit) { }

	// RVA: 0x1D6E4F4 Offset: 0x1D6A4F4 VA: 0x1D6E4F4
	public static string IntToSpinaString(long intValue) { }

	// RVA: 0x1D72FD4 Offset: 0x1D6EFD4 VA: 0x1D72FD4
	public static string IntToCommaString(int charCount, int intValue) { }

	// RVA: 0x1D73098 Offset: 0x1D6F098 VA: 0x1D73098
	public static string IntToCommaStringWithUnit(int charCount, int intValue, string unit) { }

	// RVA: 0x1D6DC78 Offset: 0x1D69C78 VA: 0x1D6DC78
	public static string IntToSpinaString(int charCount, int intValue) { }

	// RVA: 0x1D7316C Offset: 0x1D6F16C VA: 0x1D7316C
	public static string FloatToCommaString(float floatValue) { }

	// RVA: 0x1D731EC Offset: 0x1D6F1EC VA: 0x1D731EC
	public static string FloatToSpinaString(float floatValue) { }

	// RVA: 0x1D6E3A4 Offset: 0x1D6A3A4 VA: 0x1D6E3A4
	public static string FloatToSpinaString(double floatValue) { }

	// RVA: 0x1D731F4 Offset: 0x1D6F1F4 VA: 0x1D731F4
	public static string FloatToCommaString(int charCount, float floatValue) { }

	// RVA: 0x1D732C0 Offset: 0x1D6F2C0 VA: 0x1D732C0
	public static string FloatToSpinaString(int charCount, float floatValue) { }

	// RVA: 0x1D73408 Offset: 0x1D6F408 VA: 0x1D73408
	public static string IntToSignedString(int intValue) { }

	// RVA: 0x1D73474 Offset: 0x1D6F474 VA: 0x1D73474
	public static string GetLocalizedMaterialName(int materialId, SystemTextManager stm) { }

	// RVA: 0x1D7365C Offset: 0x1D6F65C VA: 0x1D7365C
	public static string GetMaterialIconName(int materialId) { }

	// RVA: 0x1D73808 Offset: 0x1D6F808 VA: 0x1D73808
	public static string GetItemNameWithRefine(int itemUuid, PlayerDataManager pdManager, ItemTextManager imanager) { }

	// RVA: 0x1D7384C Offset: 0x1D6F84C VA: 0x1D7384C
	public static string GetItemNameWithRefine(ItemData itemData, ItemTextManager imanager) { }

	// RVA: 0x1D7398C Offset: 0x1D6F98C VA: 0x1D7398C
	public static string GetItemNameWithColorRefine(ItemData itemData, ItemTextManager imanager) { }

	// RVA: 0x1D73ACC Offset: 0x1D6FACC VA: 0x1D73ACC
	public static UIPopWindow CreatePopWindow(GameObject popupWindowObject, string titleText, string messageText, string buttonText, Transform parent, Action openCallback, Action buttonCallback) { }

	// RVA: 0x1D73AF0 Offset: 0x1D6FAF0 VA: 0x1D73AF0
	public static UIPopWindow CreatePopWindow(GameObject popupWindowObject, string titleText, string messageText, string buttonText, Transform parent, UIPopWindow.popupWindowType type, Action openCallback, Action buttonCallback) { }

	// RVA: 0x1D73D10 Offset: 0x1D6FD10 VA: 0x1D73D10
	public static UIPopWindow CreatePopWindowYesNo(GameObject popupWindowObject, string titleText, string messageText, Transform parent, SystemTextManager systemTextManager, Action openCallback, Action buttonCallback, Action cancelCallBack) { }

	// RVA: 0x1D6CBB0 Offset: 0x1D68BB0 VA: 0x1D6CBB0
	public static UIPopWindow CreateOperationFailurePopWindow(GameReturnCode errorCode, Transform parent, Action openCallback, Action buttonCallback, UIBasePanelControl control, string message) { }

	// RVA: 0x1D74000 Offset: 0x1D70000 VA: 0x1D74000
	public static UIPopWindow CreatePopWindowTitleIcon(GameObject popupWindowObject, string titleText, string messageText, string buttonText, string spriteName, Transform parent, Action openCallback, Action buttonCallback) { }

	// RVA: 0x1D7404C Offset: 0x1D7004C VA: 0x1D7404C
	public static GameObject LoadPopupWindow() { }

	// RVA: 0x1D740BC Offset: 0x1D700BC VA: 0x1D740BC
	public static GameObject LoadPopupRewardWindow() { }

	// RVA: 0x1D73F90 Offset: 0x1D6FF90 VA: 0x1D73F90
	public static GameObject LoadOperationFailureWindow() { }

	// RVA: 0x1D7412C Offset: 0x1D7012C VA: 0x1D7412C
	public static string GetItemPropertyText(ItemDBData itemData, SystemTextManager systemTextManager, ItemTextManager itemTextManager, ItemPropertyTextManager itemPropertyTextManager) { }

	// RVA: 0x1D74690 Offset: 0x1D70690 VA: 0x1D74690
	public static string GetManufactureItemText(ItemDBData itemData, SystemTextManager systemTextManager, ItemTextManager itemTextManager, ItemPropertyTextManager itemPropertyTextManager) { }

	// RVA: 0x1D741C4 Offset: 0x1D701C4 VA: 0x1D741C4
	public static string GetWeaponItemPropertyText(ItemDBData itemData, SystemTextManager systemTextManager, ItemTextManager itemTextManager, ItemPropertyTextManager itemPropertyTextManager) { }

	// RVA: 0x1D74720 Offset: 0x1D70720 VA: 0x1D74720
	public static string GetManufactureItemPropertyText(ItemDBData itemData, SystemTextManager systemTextManager, ItemTextManager itemTextManager, ItemPropertyTextManager itemPropertyTextManager) { }

	// RVA: 0x1D74BC0 Offset: 0x1D70BC0 VA: 0x1D74BC0
	public static bool IsEquipItem(int itemId) { }

	// RVA: 0x1D74C30 Offset: 0x1D70C30 VA: 0x1D74C30
	public static bool IsModelEquipItem(int itemId) { }

	// RVA: 0x1D74B38 Offset: 0x1D70B38 VA: 0x1D74B38
	public static bool IsWeaponItem(int itemId) { }

	// RVA: 0x1D74CB4 Offset: 0x1D70CB4 VA: 0x1D74CB4
	public static bool IsBodyItem(int itemId) { }

	// RVA: 0x1D74D20 Offset: 0x1D70D20 VA: 0x1D74D20
	public static bool IsArmsItem(int itemType) { }

	// RVA: 0x1D74D30 Offset: 0x1D70D30 VA: 0x1D74D30
	public static bool IsArmorItem(int itemType) { }

	// RVA: 0x1D74D3C Offset: 0x1D70D3C VA: 0x1D74D3C
	public static bool IsOptionItem(int itemType) { }

	// RVA: 0x1D74D48 Offset: 0x1D70D48 VA: 0x1D74D48
	public static bool IsNonModelItem(int itemType) { }

	// RVA: 0x1D74D6C Offset: 0x1D70D6C VA: 0x1D74D6C
	public static bool IsPetCageItem(int itemId) { }

	// RVA: 0x1D74DD8 Offset: 0x1D70DD8 VA: 0x1D74DD8
	public static ItemSelector CreateItemSelector(Transform parent) { }

	// RVA: 0x1D74F80 Offset: 0x1D70F80 VA: 0x1D74F80
	public static List<Pair<short, short>> GetDBItemCaps(ItemDBData db) { }

	// RVA: 0x1D75664 Offset: 0x1D71664 VA: 0x1D75664
	public static string GetPlayerAnimationNameByWeaponType(int weaponType, int subWeaponType, PlayerAnimationType type) { }

	// RVA: 0x1D7572C Offset: 0x1D7172C VA: 0x1D7572C
	public static int MaterialParamaterPointMax() { }

	// RVA: 0x1D75784 Offset: 0x1D71784 VA: 0x1D75784
	public static int MaterialPointMax() { }

	// RVA: 0x1D758E4 Offset: 0x1D718E4 VA: 0x1D758E4
	public static long GetOverSpina(long checkSpina) { }

	// RVA: 0x1D758F4 Offset: 0x1D718F4 VA: 0x1D758F4
	public static long GetOverMaterialPoint(long checkPoint) { }

	// RVA: 0x1D7590C Offset: 0x1D7190C VA: 0x1D7590C
	public static long GetOverProcessingMaterialPoint(long checkPoint, long currentPoint) { }

	// RVA: 0x1D75988 Offset: 0x1D71988 VA: 0x1D75988
	public static UIPopWindow CreateWindowOverSpina(long checkSpina, Transform parent, Action callback) { }

	// RVA: 0x1D75C10 Offset: 0x1D71C10 VA: 0x1D75C10
	public static UIPopWindow CreateWindowOverMaterialPoint(int checkPoint, int cururentPoint, Transform parent, Action callback) { }

	[IteratorStateMachine(typeof(ShopUtil.<CheckOrbItem>d__49))]
	// RVA: 0x1D75EC4 Offset: 0x1D71EC4 VA: 0x1D75EC4
	public static IEnumerator CheckOrbItem(int itemId, Action errorCloseCallback) { }
}
