// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MasterModelDataManager : Singleton<MasterModelDataManager> // TypeDefIndex: 2135
{
	// Fields
	private Dictionary<ItemDBData.ItemType, Dictionary<int, short>> modelFlag; // 0x20
	private Dictionary<ItemDBData.ItemType, Dictionary<int, byte>> modelSkinConvertModelList; // 0x28
	private Dictionary<byte, MasterModelDataManager.ConvertCommonMaterialData> modelSkinConvertList; // 0x30
	private Dictionary<int, Color> equipColorPalette; // 0x38
	private Dictionary<int, Color> avatarSkinColorPalette; // 0x40
	private Dictionary<int, Color> avatarEyeColorPalette; // 0x48
	private Dictionary<int, Color> avatarHairColorPalette; // 0x50
	private Dictionary<int, MasterModelDataManager.ColorListData> effectColorList; // 0x58
	private Dictionary<ElementType, MasterModelDataManager.ColorListData> elementColorList; // 0x60
	private Dictionary<SkillId, MasterModelDataManager.ColorListData> songSkillColorList; // 0x68
	private Dictionary<EmotionPlayer.EmotionType, SkillId> emotionSongId; // 0x70

	// Methods

	// RVA: 0x2147C48 Offset: 0x2143C48 VA: 0x2147C48
	public static void SetChangeMaterialColor(GameObject obj, Color colorR, Color colorG, Color colorB) { }

	// RVA: 0x2147D04 Offset: 0x2143D04 VA: 0x2147D04
	public static void SetChangeMaterialColor(Renderer[] renderer, Color colorR, Color colorG, Color colorB) { }

	// RVA: 0x2147DC4 Offset: 0x2143DC4 VA: 0x2147DC4
	public static void SetChangeMaterialColor(Renderer renderer, Color colorR, Color colorG, Color colorB) { }

	// RVA: 0x2147F10 Offset: 0x2143F10 VA: 0x2147F10
	public static void SetChangeMaterialColor(Material mat, Color colorR, Color colorG, Color colorB) { }

	// RVA: 0x21480D0 Offset: 0x21440D0 VA: 0x21480D0
	public bool ReadMasterData(byte[] data) { }

	// RVA: 0x21486E8 Offset: 0x21446E8 VA: 0x21486E8
	public bool ReadAvaterGroupColor(byte[] data) { }

	// RVA: 0x2148B08 Offset: 0x2144B08 VA: 0x2148B08
	public bool ReadEquipColorPalette(byte[] data) { }

	// RVA: 0x2148CFC Offset: 0x2144CFC VA: 0x2148CFC
	public bool ReadAvatarColorPalette(byte[] data) { }

	// RVA: 0x2149124 Offset: 0x2145124 VA: 0x2149124
	public bool ReadEffectColorList(byte[] data) { }

	// RVA: 0x214B1E0 Offset: 0x21471E0 VA: 0x214B1E0
	public bool ReadElementColorList(byte[] data) { }

	// RVA: 0x214B7D0 Offset: 0x21477D0 VA: 0x214B7D0
	public bool ReadSongColorList(byte[] data) { }

	// RVA: 0x214BAF8 Offset: 0x2147AF8 VA: 0x214BAF8
	public bool CreateChangeSongEmotionToSkillIdData() { }

	// RVA: 0x214BC48 Offset: 0x2147C48 VA: 0x214BC48
	public MasterModelDataManager.BodyModelFlag GetBodyModelFlag(int modelId) { }

	// RVA: 0x214BCFC Offset: 0x2147CFC VA: 0x214BCFC
	public MasterModelDataManager.AvatarModelFlag GetAvatarTopModelFlag(int modelId) { }

	// RVA: 0x214BDB0 Offset: 0x2147DB0 VA: 0x214BDB0
	public MasterModelDataManager.OptionModelFlag GetOptionModelFlag(int modelId) { }

	// RVA: 0x214BE64 Offset: 0x2147E64 VA: 0x214BE64
	public MasterModelDataManager.OptionModelFlag GetAvatarOptionModelFlag(int modelId) { }

	// RVA: 0x214BF18 Offset: 0x2147F18 VA: 0x214BF18
	public bool TryGetEquipCommonMaterialConvertGroupId(ItemDBData.ItemType type, int modelId, out int groupId) { }

	// RVA: 0x214BFEC Offset: 0x2147FEC VA: 0x214BFEC
	public bool TryGetAvatarOptionCommonMaterialConvertGroupId(int modelId, out int groupId) { }

	// RVA: 0x214BFFC Offset: 0x2147FFC VA: 0x214BFFC
	public bool TryGetCommonMaterialConvertGroupIdData(int groupId, Color baseColor, int baseTextureId, out Color convertColor, out int convertTextureId) { }

	// RVA: 0x214C120 Offset: 0x2148120 VA: 0x214C120
	public Color GetEquipColor(int index) { }

	// RVA: 0x214C1C0 Offset: 0x21481C0 VA: 0x214C1C0
	public int GetEquipColorNum() { }

	// RVA: 0x214C210 Offset: 0x2148210 VA: 0x214C210
	public Color GetAvatarSkinColor(int index) { }

	// RVA: 0x214C2B0 Offset: 0x21482B0 VA: 0x214C2B0
	public Color GetAvatarHairColor(int index) { }

	// RVA: 0x214C350 Offset: 0x2148350 VA: 0x214C350
	public Color GetAvatarEyeColor(int index) { }

	// RVA: 0x214C3F0 Offset: 0x21483F0 VA: 0x214C3F0
	public Color GetAvatarOddEyeColor(int index, int eyeColorId) { }

	// RVA: 0x214C400 Offset: 0x2148400 VA: 0x214C400
	public Color GetAvatarHairStreakColor(int index, int eyeColorId, int oddEyeColorId) { }

	// RVA: 0x214C428 Offset: 0x2148428 VA: 0x214C428
	public MasterModelDataManager.ColorListData GetEffectColor(int modelId, int motionId) { }

	// RVA: 0x214C5B4 Offset: 0x21485B4 VA: 0x214C5B4
	public MasterModelDataManager.ColorListData GetElementColor(ElementType elementType) { }

	// RVA: 0x214C6A8 Offset: 0x21486A8 VA: 0x214C6A8
	public MasterModelDataManager.ColorListData GetSongColor(SkillId skillId) { }

	// RVA: 0x214C79C Offset: 0x214879C VA: 0x214C79C
	public SkillId GetEmotionToSkillId(EmotionPlayer.EmotionType emotionType) { }

	// RVA: 0x214C83C Offset: 0x214883C VA: 0x214C83C
	public void .ctor() { }
}
