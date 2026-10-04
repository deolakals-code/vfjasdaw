// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class PlayerGameStatus // TypeDefIndex: 1459
{
	// Fields
	[SerializeField]
	private int serverHp; // 0x10
	[SerializeField]
	private int localHp; // 0x14
	[SerializeField]
	private int serverMp; // 0x18
	[SerializeField]
	private int localMp; // 0x1C
	[SerializeField]
	private int serverExHp; // 0x20
	[SerializeField]
	private int localExHp; // 0x24
	[SerializeField]
	private int serverExMp; // 0x28
	[SerializeField]
	private int localExMp; // 0x2C
	[SerializeField]
	private long exp; // 0x30
	[SerializeField]
	private int serverGold; // 0x38
	[SerializeField]
	private int localGold; // 0x3C
	[SerializeField]
	private float serverYellsTime; // 0x40
	[SerializeField]
	private float serverRespawnTime; // 0x44
	[SerializeField]
	private float localRespawnTime; // 0x48
	[SerializeField]
	private int combExp; // 0x4C
	[SerializeField]
	private short serverMagicGauge; // 0x50
	[SerializeField]
	private TimeSpan serverMagicTimeSpan; // 0x58
	[SerializeField]
	private DateTime magicUpdateDateTime; // 0x60

	// Properties
	public int Hp { get; }
	public int LocalHp { get; }
	public int Mp { get; }
	public int LocalMp { get; }
	public int ExHp { get; }
	public int LocalExHp { get; }
	public int ExMp { get; }
	public int LocalExMp { get; }
	public long Exp { get; }
	public int Gold { get; }
	public int LocalGold { get; }
	public float RespawnTime { get; }
	public float LocalRespawnTime { get; }
	public float ServerYellsTime { get; }
	public int CombExp { get; }

	// Methods

	// RVA: 0x203DD50 Offset: 0x2039D50 VA: 0x203DD50
	public static PlayerGameStatus CreateStatus(GameStatusData statusData, AvatarGameStatusData avatarGameStatus) { }

	// RVA: 0x203E690 Offset: 0x203A690 VA: 0x203E690
	public static PlayerGameStatus CreateStatus(PlayerGameStatus oldStatusData, GameStatusData statusData) { }

	// RVA: 0x204A8F0 Offset: 0x20468F0 VA: 0x204A8F0
	public int get_Hp() { }

	// RVA: 0x204A8F8 Offset: 0x20468F8 VA: 0x204A8F8
	public int get_LocalHp() { }

	// RVA: 0x204A900 Offset: 0x2046900 VA: 0x204A900
	public int get_Mp() { }

	// RVA: 0x204A908 Offset: 0x2046908 VA: 0x204A908
	public int get_LocalMp() { }

	// RVA: 0x204A910 Offset: 0x2046910 VA: 0x204A910
	public int get_ExHp() { }

	// RVA: 0x204A918 Offset: 0x2046918 VA: 0x204A918
	public int get_LocalExHp() { }

	// RVA: 0x204A920 Offset: 0x2046920 VA: 0x204A920
	public int get_ExMp() { }

	// RVA: 0x204A928 Offset: 0x2046928 VA: 0x204A928
	public int get_LocalExMp() { }

	// RVA: 0x204A930 Offset: 0x2046930 VA: 0x204A930
	public long get_Exp() { }

	// RVA: 0x204A938 Offset: 0x2046938 VA: 0x204A938
	public int get_Gold() { }

	// RVA: 0x204A940 Offset: 0x2046940 VA: 0x204A940
	public int get_LocalGold() { }

	// RVA: 0x204A948 Offset: 0x2046948 VA: 0x204A948
	public float get_RespawnTime() { }

	// RVA: 0x204A950 Offset: 0x2046950 VA: 0x204A950
	public float get_LocalRespawnTime() { }

	// RVA: 0x204A958 Offset: 0x2046958 VA: 0x204A958
	public float get_ServerYellsTime() { }

	// RVA: 0x204A960 Offset: 0x2046960 VA: 0x204A960
	public int get_CombExp() { }

	// RVA: 0x204A968 Offset: 0x2046968 VA: 0x204A968
	public void ResetServerHp() { }

	// RVA: 0x203E5C4 Offset: 0x203A5C4 VA: 0x203E5C4
	public void SetHp(int hp, int exHp) { }

	// RVA: 0x204A97C Offset: 0x204697C VA: 0x204A97C
	public void SetLocalHp(int hp, bool actDead) { }

	// RVA: 0x204A990 Offset: 0x2046990 VA: 0x204A990
	public void SetLocalExHp(int hp) { }

	// RVA: 0x204A99C Offset: 0x204699C VA: 0x204A99C
	public void ResetServerMp() { }

	// RVA: 0x203E5D0 Offset: 0x203A5D0 VA: 0x203E5D0
	public void SetMp(int mp, int exMp) { }

	// RVA: 0x204A9B0 Offset: 0x20469B0 VA: 0x204A9B0
	public void SetLocalMp(int mp) { }

	// RVA: 0x204A9BC Offset: 0x20469BC VA: 0x204A9BC
	public void SetLocalExMp(int mp) { }

	// RVA: 0x204A9C8 Offset: 0x20469C8 VA: 0x204A9C8
	public void SetExp(long exp) { }

	// RVA: 0x204A9D0 Offset: 0x20469D0 VA: 0x204A9D0
	public void SetCombExp(int combExp) { }

	// RVA: 0x204A9D8 Offset: 0x20469D8 VA: 0x204A9D8
	public void ResetServerGold() { }

	// RVA: 0x204A9E4 Offset: 0x20469E4 VA: 0x204A9E4
	public void SetGold(int gold) { }

	// RVA: 0x204A9EC Offset: 0x20469EC VA: 0x204A9EC
	public void SetLocalGold(int gold) { }

	// RVA: 0x20481C4 Offset: 0x20441C4 VA: 0x20481C4
	public void SetRespawnTime(float respawnTime, float yellsTime) { }

	// RVA: 0x204A9F4 Offset: 0x20469F4 VA: 0x204A9F4
	public void SetLocalRespawnTime(float respawnTime) { }

	// RVA: 0x204A9FC Offset: 0x20469FC VA: 0x204A9FC
	public void SetMagicGage(short magicGage, TimeSpan magicTimeSpan) { }

	// RVA: 0x204AA70 Offset: 0x2046A70 VA: 0x204AA70
	public short GetMagicGauge(short max) { }

	// RVA: 0x204A8E8 Offset: 0x20468E8 VA: 0x204A8E8
	public void .ctor() { }
}
