// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MapInfo : MonoBehaviour // TypeDefIndex: 3980
{
	// Fields
	private Transform typeRoomObj; // 0x20
	[SerializeField]
	private TextAsset fieldQuestBytes; // 0x28
	[SerializeField]
	private TextAsset fieldMissionBytes; // 0x30
	[SerializeField]
	private TextAsset fieldScriptBytes; // 0x38
	[SerializeField]
	private NPCModelData[] fieldNPCBytes; // 0x40
	[SerializeField]
	private TextAsset mobDb; // 0x48
	[SerializeField]
	private bool isFieldAreaLocalizeLoad; // 0x50

	// Properties
	public TextAsset FieldQuestBytes { get; }
	public TextAsset FieldMissionBytes { get; }
	public TextAsset FieldScriptBytes { get; }
	public TextAsset MobDb { get; }
	public bool IsFieldAreaLocalizeLoad { get; }

	// Methods

	// RVA: 0x242B61C Offset: 0x242761C VA: 0x242B61C
	public TextAsset get_FieldQuestBytes() { }

	// RVA: 0x242B624 Offset: 0x2427624 VA: 0x242B624
	public TextAsset get_FieldMissionBytes() { }

	// RVA: 0x242B62C Offset: 0x242762C VA: 0x242B62C
	public TextAsset get_FieldScriptBytes() { }

	// RVA: 0x242B634 Offset: 0x2427634 VA: 0x242B634
	public TextAsset get_MobDb() { }

	// RVA: 0x242B63C Offset: 0x242763C VA: 0x242B63C
	public bool get_IsFieldAreaLocalizeLoad() { }

	// RVA: 0x242B644 Offset: 0x2427644 VA: 0x242B644
	public NPCModelData LoadNPC(string path) { }

	// RVA: 0x242B744 Offset: 0x2427744 VA: 0x242B744
	public List<MobPopPoint> GetMobPopPoint() { }

	// RVA: 0x242B854 Offset: 0x2427854 VA: 0x242B854
	public List<EventArea> GetEventArea() { }

	// RVA: 0x242B964 Offset: 0x2427964 VA: 0x242B964
	public BlackKnightStageData GetAction2DStageData() { }

	// RVA: 0x242B9FC Offset: 0x24279FC VA: 0x242B9FC
	public List<FieldArea> GetFieldArea() { }

	// RVA: 0x242BB0C Offset: 0x2427B0C VA: 0x242BB0C
	public EventActionBase[] GetEventActionBase() { }

	// RVA: 0x242BBA8 Offset: 0x2427BA8 VA: 0x242BBA8
	public void Initialize(FieldRoomType roomType, byte roomId) { }

	// RVA: 0x242C3FC Offset: 0x24283FC VA: 0x242C3FC
	public void .ctor() { }
}
