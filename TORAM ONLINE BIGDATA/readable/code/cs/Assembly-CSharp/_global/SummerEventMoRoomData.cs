// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SummerEventMoRoomData : SummerEventRoomData // TypeDefIndex: 2470
{
	// Fields
	public const int MaxEntryUserNum = 8;
	[CompilerGenerated]
	private SummerRecruitType <RecruitType>k__BackingField; // 0x154
	[CompilerGenerated]
	private bool <IsLeader>k__BackingField; // 0x158
	[CompilerGenerated]
	private bool <IsEnterRoomData>k__BackingField; // 0x159
	[CompilerGenerated]
	private int <MemberNum>k__BackingField; // 0x15C
	[CompilerGenerated]
	private int <JoinMemberNum>k__BackingField; // 0x160
	[CompilerGenerated]
	private int <AliveMemberNum>k__BackingField; // 0x164
	[CompilerGenerated]
	private int <RoomLevel>k__BackingField; // 0x168
	[CompilerGenerated]
	private bool <IsBossResult>k__BackingField; // 0x16C
	private float resultTimer; // 0x170
	private float recoveryTimer; // 0x174
	private int startSeaPoint; // 0x178
	private int roomPoint; // 0x17C
	private List<int> deadUserIdList; // 0x180
	private byte roomState; // 0x188
	private bool isResultPop; // 0x189

	// Properties
	public override byte RoomType { get; }
	protected override UIActiveState fieldMainUIState { get; }
	public bool IsStart { get; }
	public bool IsEnd { get; }
	public bool IsRemoved { get; }
	public bool IsOwnerLeave { get; }
	public int RoomPoint { get; }
	public override bool IsDead { get; }
	public bool IsBossPop { get; }
	public SummerRecruitType RecruitType { get; set; }
	public bool IsLeader { get; set; }
	public bool IsEnterRoomData { get; set; }
	public int MemberNum { get; set; }
	public int JoinMemberNum { get; set; }
	public int AliveMemberNum { get; set; }
	public int RoomLevel { get; set; }
	public bool IsBossResult { get; set; }

	// Methods

	// RVA: 0x21BC8A0 Offset: 0x21B88A0 VA: 0x21BC8A0 Slot: 4
	public override byte get_RoomType() { }

	// RVA: 0x21BC8A8 Offset: 0x21B88A8 VA: 0x21BC8A8 Slot: 40
	protected override UIActiveState get_fieldMainUIState() { }

	// RVA: 0x21BC8B0 Offset: 0x21B88B0 VA: 0x21BC8B0
	public bool get_IsStart() { }

	// RVA: 0x21BC8BC Offset: 0x21B88BC VA: 0x21BC8BC
	public bool get_IsEnd() { }

	// RVA: 0x21BC8CC Offset: 0x21B88CC VA: 0x21BC8CC
	public bool get_IsRemoved() { }

	// RVA: 0x21BC8D8 Offset: 0x21B88D8 VA: 0x21BC8D8
	public bool get_IsOwnerLeave() { }

	// RVA: 0x21BC8E4 Offset: 0x21B88E4 VA: 0x21BC8E4
	public int get_RoomPoint() { }

	// RVA: 0x21BC8F8 Offset: 0x21B88F8 VA: 0x21BC8F8 Slot: 41
	public override bool get_IsDead() { }

	// RVA: 0x21BC914 Offset: 0x21B8914 VA: 0x21BC914
	public bool get_IsBossPop() { }

	[CompilerGenerated]
	// RVA: 0x21BC924 Offset: 0x21B8924 VA: 0x21BC924
	public SummerRecruitType get_RecruitType() { }

	[CompilerGenerated]
	// RVA: 0x21BC92C Offset: 0x21B892C VA: 0x21BC92C
	private void set_RecruitType(SummerRecruitType value) { }

	[CompilerGenerated]
	// RVA: 0x21BC934 Offset: 0x21B8934 VA: 0x21BC934
	public bool get_IsLeader() { }

	[CompilerGenerated]
	// RVA: 0x21BC93C Offset: 0x21B893C VA: 0x21BC93C
	private void set_IsLeader(bool value) { }

	[CompilerGenerated]
	// RVA: 0x21BC948 Offset: 0x21B8948 VA: 0x21BC948
	public bool get_IsEnterRoomData() { }

	[CompilerGenerated]
	// RVA: 0x21BC950 Offset: 0x21B8950 VA: 0x21BC950
	private void set_IsEnterRoomData(bool value) { }

	[CompilerGenerated]
	// RVA: 0x21BC95C Offset: 0x21B895C VA: 0x21BC95C
	public int get_MemberNum() { }

	[CompilerGenerated]
	// RVA: 0x21BC964 Offset: 0x21B8964 VA: 0x21BC964
	private void set_MemberNum(int value) { }

	[CompilerGenerated]
	// RVA: 0x21BC96C Offset: 0x21B896C VA: 0x21BC96C
	public int get_JoinMemberNum() { }

	[CompilerGenerated]
	// RVA: 0x21BC974 Offset: 0x21B8974 VA: 0x21BC974
	private void set_JoinMemberNum(int value) { }

	[CompilerGenerated]
	// RVA: 0x21BC97C Offset: 0x21B897C VA: 0x21BC97C
	private void set_AliveMemberNum(int value) { }

	[CompilerGenerated]
	// RVA: 0x21BC984 Offset: 0x21B8984 VA: 0x21BC984
	public int get_AliveMemberNum() { }

	[CompilerGenerated]
	// RVA: 0x21BC98C Offset: 0x21B898C VA: 0x21BC98C
	public int get_RoomLevel() { }

	[CompilerGenerated]
	// RVA: 0x21BC994 Offset: 0x21B8994 VA: 0x21BC994
	private void set_RoomLevel(int value) { }

	[CompilerGenerated]
	// RVA: 0x21BC99C Offset: 0x21B899C VA: 0x21BC99C
	public bool get_IsBossResult() { }

	[CompilerGenerated]
	// RVA: 0x21BC9A4 Offset: 0x21B89A4 VA: 0x21BC9A4
	private void set_IsBossResult(bool value) { }

	// RVA: 0x21BC9B0 Offset: 0x21B89B0 VA: 0x21BC9B0 Slot: 13
	public override void Enter() { }

	// RVA: 0x21BCA3C Offset: 0x21B8A3C VA: 0x21BCA3C Slot: 15
	public override void Update() { }

	// RVA: 0x21BCDB8 Offset: 0x21B8DB8 VA: 0x21BCDB8
	public void UpdateRuleChange(SummerRecruitType type) { }

	// RVA: 0x21BCDC0 Offset: 0x21B8DC0 VA: 0x21BCDC0
	public void UpdateRoomData(int memberNum, int joinMemberNum, int aliveMemberNum, int point, int seaLevel) { }

	// RVA: 0x21BCDD8 Offset: 0x21B8DD8 VA: 0x21BCDD8
	public void UpdateEventState(byte state) { }

	// RVA: 0x21BCF78 Offset: 0x21B8F78 VA: 0x21BCF78
	public void UpdateMemberData(SummerMemberData member, int hp) { }

	// RVA: 0x21BD1D0 Offset: 0x21B91D0 VA: 0x21BD1D0
	public void DeadMemberData(SummerMemberData member) { }

	// RVA: 0x21BD3C8 Offset: 0x21B93C8 VA: 0x21BD3C8
	public void BossResult() { }

	// RVA: 0x21BD3D4 Offset: 0x21B93D4 VA: 0x21BD3D4 Slot: 21
	public override void OnGameEventLogin(GameEventLoginResponse login, short returnCode) { }

	// RVA: 0x21BD924 Offset: 0x21B9924 VA: 0x21BD924
	public bool ChangeRoomSetting(SummerRecruitType settingType) { }

	// RVA: 0x21BD9A4 Offset: 0x21B99A4 VA: 0x21BD9A4
	public bool StartRoomGame() { }

	// RVA: 0x21BDA18 Offset: 0x21B9A18 VA: 0x21BDA18 Slot: 27
	public override void ReceiveUpdate(OperationResponse response) { }

	// RVA: 0x21BDB50 Offset: 0x21B9B50 VA: 0x21BDB50 Slot: 43
	public override int CheckHitBulletToFish(DivingAttack bullet, int removeId) { }

	// RVA: 0x21BDB68 Offset: 0x21B9B68 VA: 0x21BDB68
	public bool CheckDeadOtherPlayer(int uid) { }

	// RVA: 0x21BDBC0 Offset: 0x21B9BC0 VA: 0x21BDBC0 Slot: 44
	public override void OnPlayerDamaged(DivingMob mob) { }

	// RVA: 0x21B89D8 Offset: 0x21B49D8 VA: 0x21B89D8
	public void .ctor() { }
}
