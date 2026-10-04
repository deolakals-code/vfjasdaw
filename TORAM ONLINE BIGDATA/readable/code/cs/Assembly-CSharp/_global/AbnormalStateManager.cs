// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class AbnormalStateManager // TypeDefIndex: 1657
{
	// Fields
	private static readonly AbnormalType[] NonRecoverableState; // 0x0
	private static readonly AbnormalType[] DamagedRecoverableState; // 0x8
	private BufferEffectManager bufferEffectManager; // 0x10
	private Dictionary<AbnormalType, AbnormalData> abnormalList; // 0x18
	private List<AbnormalIntervalData> intervalAbnormalList; // 0x20
	private Dictionary<AbnormalType, AbnormalData> resistTimeList; // 0x28
	private List<AbnormalData> allAbnormalList; // 0x30
	private float lastUpdateTime; // 0x38
	private Dictionary<AbnormalStateManager.InvinciblityType, AbnormalStateManager.InvincibilityBaseData> invincibilityList; // 0x40
	private CountUpIdManager invinciblityLocalIdManager; // 0x48
	private readonly bool isMonster; // 0x50
	[CompilerGenerated]
	private bool <IsActionLock>k__BackingField; // 0x51

	// Properties
	public int AbnormalCount { get; }
	public IList<AbnormalData> AbnormalList { get; }
	public Dictionary<AbnormalType, AbnormalData> ResistList { get; }
	public bool IsActionLock { get; set; }

	// Methods

	// RVA: 0x20A03E8 Offset: 0x209C3E8 VA: 0x20A03E8
	public static float GetDefaultAnbormalStateTime(AbnormalType type) { }

	// RVA: 0x20A043C Offset: 0x209C43C VA: 0x20A043C
	public static float GetDefaultAnbormalStateTime(int type) { }

	// RVA: 0x20A0460 Offset: 0x209C460 VA: 0x20A0460
	public static float GetAnbormalStateResistTime(AbnormalType type) { }

	// RVA: 0x20A04BC Offset: 0x209C4BC VA: 0x20A04BC
	public static float GetAnbormalStateResistTime(AbnormalType type, float time) { }

	// RVA: 0x20A0520 Offset: 0x209C520 VA: 0x20A0520
	public static float GetAnbormalStateResistTime(int type, float time) { }

	// RVA: 0x20A05B4 Offset: 0x209C5B4 VA: 0x20A05B4
	public static bool IsBuffIcon(AbnormalType type) { }

	// RVA: 0x20A0604 Offset: 0x209C604 VA: 0x20A0604
	public int get_AbnormalCount() { }

	// RVA: 0x20A0724 Offset: 0x209C724 VA: 0x20A0724
	public IList<AbnormalData> get_AbnormalList() { }

	// RVA: 0x20A0774 Offset: 0x209C774 VA: 0x20A0774
	public Dictionary<AbnormalType, AbnormalData> get_ResistList() { }

	[CompilerGenerated]
	// RVA: 0x20A077C Offset: 0x209C77C VA: 0x20A077C
	public bool get_IsActionLock() { }

	[CompilerGenerated]
	// RVA: 0x20A0784 Offset: 0x209C784 VA: 0x20A0784
	private void set_IsActionLock(bool value) { }

	// RVA: 0x20A0790 Offset: 0x209C790 VA: 0x20A0790
	public void .ctor(BufferEffectManager manager, bool isMonster) { }

	// RVA: 0x20A09A4 Offset: 0x209C9A4 VA: 0x20A09A4
	public void Update() { }

	// RVA: 0x20A1BEC Offset: 0x209DBEC VA: 0x20A1BEC
	public bool Contains(AbnormalType type) { }

	// RVA: 0x20A1B94 Offset: 0x209DB94 VA: 0x20A1B94
	public bool Contains(int type) { }

	// RVA: 0x20A1C44 Offset: 0x209DC44 VA: 0x20A1C44
	public bool ContainsAbnormal(AbnormalType type) { }

	// RVA: 0x20A1CC4 Offset: 0x209DCC4 VA: 0x20A1CC4
	public bool HasRecoverable() { }

	// RVA: 0x20A1DF0 Offset: 0x209DDF0 VA: 0x20A1DF0
	public void Recovery(byte[] list, byte[] ids) { }

	// RVA: 0x20A1E5C Offset: 0x209DE5C VA: 0x20A1E5C
	public void DamagedRecovery() { }

	// RVA: 0x20A2200 Offset: 0x209E200 VA: 0x20A2200
	public void ActionLockAbnormalRecovery() { }

	[Obsolete("サーバ処理にする")]
	// RVA: 0x20A239C Offset: 0x209E39C VA: 0x20A239C
	public void Vaccine(int type) { }

	[Obsolete("サーバ処理にする")]
	// RVA: 0x20A2828 Offset: 0x209E828 VA: 0x20A2828
	public void Recovery() { }

	// RVA: 0x20A297C Offset: 0x209E97C VA: 0x20A297C
	public void Clear() { }

	// RVA: 0x20A2A88 Offset: 0x209EA88 VA: 0x20A2A88
	public void ClearWithoutType(AbnormalType[] types) { }

	// RVA: 0x20A2DA8 Offset: 0x209EDA8 VA: 0x20A2DA8
	public bool CheckAbnormalType(int type) { }

	// RVA: 0x20A2DAC Offset: 0x209EDAC VA: 0x20A2DAC
	public bool CheckAbnormalType(AbnormalType type) { }

	// RVA: 0x20A2E30 Offset: 0x209EE30 VA: 0x20A2E30
	private bool checkActionLockPriority(int type) { }

	[Obsolete("未使用")]
	// RVA: 0x20A2EFC Offset: 0x209EEFC VA: 0x20A2EFC
	public bool AddAbnormalStateData(AbnormalData data) { }

	// RVA: 0x20A31FC Offset: 0x209F1FC VA: 0x20A31FC
	public void ForceAddAbnormalStateData(AbnormalData data) { }

	// RVA: 0x20A3458 Offset: 0x209F458 VA: 0x20A3458
	public bool AddAbnormalState(AbnormalType type, byte localId, bool isForce) { }

	// RVA: 0x20A34D4 Offset: 0x209F4D4 VA: 0x20A34D4
	public bool AddAbnormalState(int type, byte localId, bool isForce) { }

	// RVA: 0x20A3464 Offset: 0x209F464 VA: 0x20A3464
	public bool AddAbnormalState(AbnormalType type, byte localId, bool isForce, Action<AbnormalData> callback) { }

	[Obsolete("未使用")]
	// RVA: 0x20A3588 Offset: 0x209F588 VA: 0x20A3588
	public bool AddAbnormalState(int type, byte localId, bool isForce, Action<AbnormalData> callback) { }

	// RVA: 0x20A3590 Offset: 0x209F590 VA: 0x20A3590
	public bool AddAbnormalState(AbnormalType type, float time, float resist, byte localId, bool isForce) { }

	// RVA: 0x20A3880 Offset: 0x209F880 VA: 0x20A3880
	public bool AddAbnormalState(int type, float time, float resist, byte localId, bool isForce) { }

	// RVA: 0x20A3888 Offset: 0x209F888 VA: 0x20A3888
	public bool AddAbnormalState(AbnormalType type, float time, float resist, byte localId, bool isForce, Action<AbnormalData> callback) { }

	// RVA: 0x20A3A44 Offset: 0x209FA44 VA: 0x20A3A44
	public bool AddAbnormalState(int type, float time, float resist, byte localId, bool isForce, Action<AbnormalData> callback) { }

	// RVA: 0x20A3A4C Offset: 0x209FA4C VA: 0x20A3A4C
	public bool AddAbnormalState(AbnormalType type, AnimationBase animation, int motionId, float resist, byte localId, bool isForce, Action<AbnormalData> callback) { }

	// RVA: 0x20A3C34 Offset: 0x209FC34 VA: 0x20A3C34
	public bool AddAbnormalState(int type, AnimationBase animation, int motionId, float resist, byte localId, bool isForce, Action<AbnormalData> callback) { }

	// RVA: 0x20A3C3C Offset: 0x209FC3C VA: 0x20A3C3C
	public float GetEffectTime(AbnormalType type) { }

	// RVA: 0x20A3CD0 Offset: 0x209FCD0 VA: 0x20A3CD0
	public float GetResistTime(AbnormalType type) { }

	// RVA: 0x20A34E0 Offset: 0x209F4E0 VA: 0x20A34E0
	private bool addDefaultAnbormalState(AbnormalType type, byte localId, bool isForce, Action<AbnormalData> callback) { }

	// RVA: 0x20A3618 Offset: 0x209F618 VA: 0x20A3618
	private bool addAbnormalState(AbnormalType type, float time, float resist, byte localId, bool isForce, Action<AbnormalData> callback) { }

	// RVA: 0x20A3B84 Offset: 0x209FB84 VA: 0x20A3B84
	private bool addMotionEndAbnormalState(AbnormalType type, AnimationBase animation, int motionId, float resist, byte localId, bool isForce, Action<AbnormalData> callback) { }

	// RVA: 0x20A2F54 Offset: 0x209EF54 VA: 0x20A2F54
	private bool addAbnormalData(AbnormalData data) { }

	// RVA: 0x20A3200 Offset: 0x209F200 VA: 0x20A3200
	private void addForceAbnormalData(AbnormalData data) { }

	// RVA: 0x20A3D88 Offset: 0x209FD88 VA: 0x20A3D88
	public bool CheckEffectAbnormal(AbnormalType type) { }

	// RVA: 0x20A3E14 Offset: 0x209FE14 VA: 0x20A3E14
	public bool CheckEffectAbnormal(AbnormalType[] types) { }

	// RVA: 0x20A1B8C Offset: 0x209DB8C VA: 0x20A1B8C
	public void RemoveAbnormalState(AbnormalType type) { }

	// RVA: 0x20A4010 Offset: 0x20A0010 VA: 0x20A4010
	public void RemoveAbnormalState(int type) { }

	// RVA: 0x20A4018 Offset: 0x20A0018 VA: 0x20A4018
	public void RemoveAbnormalState(int type, bool force) { }

	// RVA: 0x20A3E8C Offset: 0x209FE8C VA: 0x20A3E8C
	public void RemoveAbnormalState(AbnormalType type, bool force) { }

	// RVA: 0x20A1FF8 Offset: 0x209DFF8 VA: 0x20A1FF8
	public void DamageRecoveryAbnormalState(AbnormalType type) { }

	// RVA: 0x20A4020 Offset: 0x20A0020 VA: 0x20A4020
	public AbnormalData GetAbnormalData(AbnormalType type) { }

	// RVA: 0x20A40B4 Offset: 0x20A00B4 VA: 0x20A40B4
	public bool TryGetAbnormalStateData(AbnormalType type, out AbnormalData abnormalData) { }

	// RVA: 0x20A4148 Offset: 0x20A0148 VA: 0x20A4148
	public List<AbnormalData> GetNameLabelAbnormalState() { }

	// RVA: 0x20A42AC Offset: 0x20A02AC VA: 0x20A42AC
	public bool IsInvincibility() { }

	// RVA: 0x20A43AC Offset: 0x20A03AC VA: 0x20A43AC
	public byte AddInvincibilityTemporarilyInAction(float time) { }

	// RVA: 0x20A45C0 Offset: 0x20A05C0 VA: 0x20A45C0
	public void RemoveTemporarilyInvincibility(byte id) { }

	// RVA: 0x20A47FC Offset: 0x20A07FC VA: 0x20A47FC
	public void AddMotionInvincibility(Animation animation, int motionId, float addTime) { }

	// RVA: 0x20A4A48 Offset: 0x20A0A48 VA: 0x20A4A48
	public void AddSkillMotionInvincibility(SkillId skillId, Animation animation, int motionId, float addTime) { }

	// RVA: 0x20A4BEC Offset: 0x20A0BEC VA: 0x20A4BEC
	public void RemoveSkillMotionInvincibility(SkillId skillId) { }

	// RVA: 0x20A4F90 Offset: 0x20A0F90 VA: 0x20A4F90
	public void AddTimeInvincibility(float time, bool overwrite) { }

	// RVA: 0x20A517C Offset: 0x20A117C VA: 0x20A517C
	public void AddTimeInvincibility(float time, int id, bool overwrite) { }

	// RVA: 0x20A5334 Offset: 0x20A1334 VA: 0x20A5334
	public void RemoveTimeInvincibility(int id) { }

	// RVA: 0x20A5720 Offset: 0x20A1720 VA: 0x20A5720
	public void RemoveTimeInvincibility() { }

	// RVA: 0x20A5430 Offset: 0x20A1430 VA: 0x20A5430
	private void CheckInvincibility() { }

	// RVA: 0x20A57B4 Offset: 0x20A17B4 VA: 0x20A57B4
	private static void .cctor() { }
}
