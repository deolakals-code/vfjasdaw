// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class ModelObjectBase : MonoBehaviour, IUserArchetype // TypeDefIndex: 1193
{
	// Fields
	private NewArchetypeProperties modelProperty; // 0x20
	protected SkinnedMeshRenderer skinRender; // 0x28
	private GameObject model; // 0x30
	private List<LinkBones> cloneWeaponLinkList; // 0x38
	protected bool priorityPlayer; // 0x40
	private byte regionCode; // 0x41
	[CompilerGenerated]
	private ArchetypeUid <ArchetypeUid>k__BackingField; // 0x48
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x50
	[CompilerGenerated]
	private CharacterActionManagerBase <actionManagerBase>k__BackingField; // 0x58
	[CompilerGenerated]
	private CharacterMove <CharacterMove>k__BackingField; // 0x60
	[CompilerGenerated]
	private FloorLightMap <FloorLightMap>k__BackingField; // 0x68
	[CompilerGenerated]
	private AnimationBase <AnimationBase>k__BackingField; // 0x70
	[CompilerGenerated]
	private bool <IsMerging>k__BackingField; // 0x78

	// Properties
	public ArchetypeUid ArchetypeUid { get; set; }
	public virtual bool IsAvatarArchetype { get; }
	public virtual bool IsServantArchetype { get; }
	public virtual Archetype Archetype { get; }
	public string UserName { get; set; }
	public byte RegionCode { get; }
	public virtual bool IsPartyMember { get; }
	public virtual bool IsGuildMember { get; }
	public virtual bool IsFriend { get; }
	public virtual bool IsRenderEnabled { get; set; }
	public virtual bool IsVisibleRenderer { get; }
	public virtual bool IsGMEventPlayer { get; }
	public virtual bool IsHideUser { get; }
	public virtual string MoodMessage { get; }
	public virtual string GuildName { get; }
	protected CharacterActionManagerBase actionManagerBase { get; set; }
	public CharacterMove CharacterMove { get; set; }
	protected FloorLightMap FloorLightMap { get; set; }
	public AnimationBase AnimationBase { get; set; }
	protected PlayerAnimation playerAnimation { get; }
	public bool IsMerging { get; set; }
	public float PlayerHeight { get; }
	public bool IsMan { get; }
	public bool IsManAnimation { get; }
	public CacheArchetypeUid CacheArchetypeUid { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1F7C274 Offset: 0x1F78274 VA: 0x1F7C274 Slot: 5
	public ArchetypeUid get_ArchetypeUid() { }

	[CompilerGenerated]
	// RVA: 0x1F7C27C Offset: 0x1F7827C VA: 0x1F7C27C
	private void set_ArchetypeUid(ArchetypeUid value) { }

	// RVA: 0x1F7C284 Offset: 0x1F78284 VA: 0x1F7C284 Slot: 9
	public virtual bool get_IsAvatarArchetype() { }

	// RVA: 0x1F7C2E0 Offset: 0x1F782E0 VA: 0x1F7C2E0 Slot: 10
	public virtual bool get_IsServantArchetype() { }

	// RVA: 0x1F7C380 Offset: 0x1F78380 VA: 0x1F7C380 Slot: 11
	public virtual Archetype get_Archetype() { }

	[CompilerGenerated]
	// RVA: 0x1F7C388 Offset: 0x1F78388 VA: 0x1F7C388 Slot: 6
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x1F7C390 Offset: 0x1F78390 VA: 0x1F7C390
	protected void set_UserName(string value) { }

	// RVA: 0x1F7C398 Offset: 0x1F78398 VA: 0x1F7C398 Slot: 8
	public byte get_RegionCode() { }

	// RVA: 0x1F7C3A0 Offset: 0x1F783A0 VA: 0x1F7C3A0 Slot: 12
	public virtual bool get_IsPartyMember() { }

	// RVA: 0x1F7C3A8 Offset: 0x1F783A8 VA: 0x1F7C3A8 Slot: 13
	public virtual bool get_IsGuildMember() { }

	// RVA: 0x1F7C3B0 Offset: 0x1F783B0 VA: 0x1F7C3B0 Slot: 14
	public virtual bool get_IsFriend() { }

	// RVA: 0x1F7C3B8 Offset: 0x1F783B8 VA: 0x1F7C3B8 Slot: 15
	public virtual bool get_IsRenderEnabled() { }

	// RVA: 0x1F7C3C0 Offset: 0x1F783C0 VA: 0x1F7C3C0 Slot: 16
	public virtual void set_IsRenderEnabled(bool value) { }

	// RVA: 0x1F7C3C4 Offset: 0x1F783C4 VA: 0x1F7C3C4 Slot: 17
	public virtual bool get_IsVisibleRenderer() { }

	// RVA: 0x1F7C44C Offset: 0x1F7844C VA: 0x1F7C44C Slot: 18
	public virtual bool get_IsGMEventPlayer() { }

	// RVA: 0x1F7C454 Offset: 0x1F78454 VA: 0x1F7C454 Slot: 19
	public virtual bool get_IsHideUser() { }

	// RVA: 0x1F7C45C Offset: 0x1F7845C VA: 0x1F7C45C Slot: 20
	public virtual string get_MoodMessage() { }

	// RVA: 0x1F7C464 Offset: 0x1F78464 VA: 0x1F7C464 Slot: 21
	public virtual string get_GuildName() { }

	[CompilerGenerated]
	// RVA: 0x1F7C4A4 Offset: 0x1F784A4 VA: 0x1F7C4A4
	protected CharacterActionManagerBase get_actionManagerBase() { }

	[CompilerGenerated]
	// RVA: 0x1F7C4AC Offset: 0x1F784AC VA: 0x1F7C4AC
	private void set_actionManagerBase(CharacterActionManagerBase value) { }

	[CompilerGenerated]
	// RVA: 0x1F7C4B4 Offset: 0x1F784B4 VA: 0x1F7C4B4 Slot: 22
	public CharacterMove get_CharacterMove() { }

	[CompilerGenerated]
	// RVA: 0x1F7C4BC Offset: 0x1F784BC VA: 0x1F7C4BC
	private void set_CharacterMove(CharacterMove value) { }

	[CompilerGenerated]
	// RVA: 0x1F7C4C4 Offset: 0x1F784C4 VA: 0x1F7C4C4
	protected FloorLightMap get_FloorLightMap() { }

	[CompilerGenerated]
	// RVA: 0x1F7C4CC Offset: 0x1F784CC VA: 0x1F7C4CC
	private void set_FloorLightMap(FloorLightMap value) { }

	[CompilerGenerated]
	// RVA: 0x1F7C4D4 Offset: 0x1F784D4 VA: 0x1F7C4D4
	public AnimationBase get_AnimationBase() { }

	[CompilerGenerated]
	// RVA: 0x1F7C4DC Offset: 0x1F784DC VA: 0x1F7C4DC
	protected void set_AnimationBase(AnimationBase value) { }

	// RVA: 0x1F755E0 Offset: 0x1F715E0 VA: 0x1F755E0
	protected PlayerAnimation get_playerAnimation() { }

	[CompilerGenerated]
	// RVA: 0x1F7C4E4 Offset: 0x1F784E4 VA: 0x1F7C4E4 Slot: 23
	public bool get_IsMerging() { }

	[CompilerGenerated]
	// RVA: 0x1F7C4EC Offset: 0x1F784EC VA: 0x1F7C4EC
	private void set_IsMerging(bool value) { }

	// RVA: 0x1F7C4F8 Offset: 0x1F784F8 VA: 0x1F7C4F8 Slot: 24
	public float get_PlayerHeight() { }

	// RVA: 0x1F75078 Offset: 0x1F71078 VA: 0x1F75078 Slot: 25
	public bool get_IsMan() { }

	// RVA: 0x1F7C590 Offset: 0x1F78590 VA: 0x1F7C590 Slot: 26
	public bool get_IsManAnimation() { }

	// RVA: 0x1F7C604 Offset: 0x1F78604 VA: 0x1F7C604
	public CacheArchetypeUid get_CacheArchetypeUid() { }

	// RVA: 0x1F7C678 Offset: 0x1F78678 VA: 0x1F7C678
	protected void Initialize(GameObject model, int id, byte type, string userName, AnimationBase animationBase, CharacterMove characterMove) { }

	// RVA: 0x1F73EC8 Offset: 0x1F6FEC8 VA: 0x1F73EC8
	protected void Initialize(int id, byte type, string userName, AnimationBase animationBase, CharacterMove characterMove) { }

	// RVA: 0x1F740F4 Offset: 0x1F700F4 VA: 0x1F740F4
	protected void SetBattleData(CharacterActionManagerBase actionManager) { }

	// RVA: 0x1F7750C Offset: 0x1F7350C VA: 0x1F7750C Slot: 27
	public virtual void StartActionFieldEvent(bool isColl, int actionId) { }

	// RVA: 0x1F776EC Offset: 0x1F736EC VA: 0x1F776EC Slot: 28
	public virtual void EndActionFieldEvent(int connectionId) { }

	// RVA: 0x1F7C748 Offset: 0x1F78748 VA: 0x1F7C748 Slot: 29
	public virtual GameObject CloneModelObject() { }

	// RVA: 0x1F7CC40 Offset: 0x1F78C40 VA: 0x1F7CC40 Slot: 30
	public virtual void CloneNonWeaponModelObject(int checkLayer, Action<GameObject> callback) { }

	// RVA: 0x1F7CD7C Offset: 0x1F78D7C VA: 0x1F7CD7C Slot: 31
	public virtual void CloneEquipWeapon(bool isMainWeapon, bool isSubWeapon, int checkLayer, Action<GameObject> callback) { }

	// RVA: 0x1F7CF08 Offset: 0x1F78F08 VA: 0x1F7CF08 Slot: 32
	public virtual void CloneDualEquipMainWeapon(bool isMain, bool isReverseHand, int checkLayer, Action<GameObject> callback) { }

	// RVA: 0x1F7D0CC Offset: 0x1F790CC VA: 0x1F7D0CC
	private void CloneWeaponLink(Action<GameObject> callback, GameObject cloneWeapon, int checkLayer) { }

	// RVA: 0x1F7D5FC Offset: 0x1F795FC VA: 0x1F7D5FC
	private void RestoreModelLinkedState() { }

	// RVA: 0x1F7D910 Offset: 0x1F79910 VA: 0x1F7D910
	public void UpdateLinkModelTrans(GameObject linkModel) { }

	// RVA: 0x1F7DA3C Offset: 0x1F79A3C VA: 0x1F7DA3C Slot: 33
	protected virtual bool OnPropertyUpdateStart() { }

	// RVA: 0x1F7DA44 Offset: 0x1F79A44 VA: 0x1F7DA44 Slot: 34
	protected virtual void UpdateModelProperty(NewArchetypeProperties property, Action endAction) { }

	// RVA: 0x1F7DF40 Offset: 0x1F79F40 VA: 0x1F7DF40 Slot: 35
	protected virtual void UpdateModelProperty(NewArchetypeProperties property) { }

	// RVA: 0x1F76E90 Offset: 0x1F72E90 VA: 0x1F76E90 Slot: 36
	protected virtual void OnPropertyUpdateEnd() { }

	// RVA: 0x1F7DFCC Offset: 0x1F79FCC VA: 0x1F7DFCC Slot: 37
	protected virtual void OnPropertyUpdateEndReCheck() { }

	// RVA: 0x1F7DD7C Offset: 0x1F79D7C VA: 0x1F7DD7C
	protected bool CheckModelDifference(NewArchetypeProperties updateProperty) { }

	// RVA: 0x1F7DFD0 Offset: 0x1F79FD0 VA: 0x1F7DFD0
	protected void .ctor() { }
}
