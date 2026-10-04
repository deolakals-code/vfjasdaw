// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrbShopDailyDartsGameManager // TypeDefIndex: 2154
{
	// Fields
	[CompilerGenerated]
	private byte <ThrowNum>k__BackingField; // 0x10
	private List<OrbShopDailyDartsGameManager.RewardPanelData> rewardData; // 0x18
	[CompilerGenerated]
	private OrbShopDailyDartsGameManager.RewardPanelData <Reward>k__BackingField; // 0x20
	private bool isEnterGame; // 0x28
	[CompilerGenerated]
	private MiniGameOperationCode <ConnectionCode>k__BackingField; // 0x2C
	[CompilerGenerated]
	private short <ConnectionReturnCode>k__BackingField; // 0x30

	// Properties
	public byte ThrowNum { get; set; }
	public OrbShopDailyDartsGameManager.RewardPanelData[] GetRewardData { get; }
	public OrbShopDailyDartsGameManager.RewardPanelData Reward { get; set; }
	public bool IsEnterGame { get; }
	public MiniGameOperationCode ConnectionCode { get; set; }
	public short ConnectionReturnCode { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x21503CC Offset: 0x214C3CC VA: 0x21503CC
	public byte get_ThrowNum() { }

	[CompilerGenerated]
	// RVA: 0x21503D4 Offset: 0x214C3D4 VA: 0x21503D4
	private void set_ThrowNum(byte value) { }

	// RVA: 0x21503DC Offset: 0x214C3DC VA: 0x21503DC
	public OrbShopDailyDartsGameManager.RewardPanelData[] get_GetRewardData() { }

	[CompilerGenerated]
	// RVA: 0x215042C Offset: 0x214C42C VA: 0x215042C
	public OrbShopDailyDartsGameManager.RewardPanelData get_Reward() { }

	[CompilerGenerated]
	// RVA: 0x2150434 Offset: 0x214C434 VA: 0x2150434
	private void set_Reward(OrbShopDailyDartsGameManager.RewardPanelData value) { }

	// RVA: 0x215043C Offset: 0x214C43C VA: 0x215043C
	public bool get_IsEnterGame() { }

	[CompilerGenerated]
	// RVA: 0x21504AC Offset: 0x214C4AC VA: 0x21504AC
	public MiniGameOperationCode get_ConnectionCode() { }

	[CompilerGenerated]
	// RVA: 0x21504B4 Offset: 0x214C4B4 VA: 0x21504B4
	private void set_ConnectionCode(MiniGameOperationCode value) { }

	[CompilerGenerated]
	// RVA: 0x21504BC Offset: 0x214C4BC VA: 0x21504BC
	public short get_ConnectionReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x21504C4 Offset: 0x214C4C4 VA: 0x21504C4
	private void set_ConnectionReturnCode(short value) { }

	// RVA: 0x21504CC Offset: 0x214C4CC VA: 0x21504CC
	private void SetConnectionCode(MiniGameOperationCode code) { }

	// RVA: 0x21504D8 Offset: 0x214C4D8 VA: 0x21504D8
	public void ReceiveFailure(byte subCode, short returnCode) { }

	// RVA: 0x21504E4 Offset: 0x214C4E4 VA: 0x21504E4
	public void GameEnter() { }

	// RVA: 0x2150580 Offset: 0x214C580 VA: 0x2150580
	public void ReceiveGameEnter(DailyDartsGameEnterResponse response) { }

	// RVA: 0x21508CC Offset: 0x214C8CC VA: 0x21508CC
	public void GameStart() { }

	// RVA: 0x21508D8 Offset: 0x214C8D8 VA: 0x21508D8
	public void GameEnd() { }

	// RVA: 0x21508E0 Offset: 0x214C8E0 VA: 0x21508E0
	public void ThrowDarts(int id) { }

	// RVA: 0x2150964 Offset: 0x214C964 VA: 0x2150964
	public void ReceiveThrowDarts(byte num) { }

	// RVA: 0x2150974 Offset: 0x214C974 VA: 0x2150974
	public void RewardItem(int rewardId) { }

	// RVA: 0x21509EC Offset: 0x214C9EC VA: 0x21509EC
	public void ReceiveRewardItem(RewardData[] reward) { }

	// RVA: 0x2150AB0 Offset: 0x214CAB0 VA: 0x2150AB0
	public void .ctor() { }
}
