// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[UsedByNativeCode]
[Serializable]
public struct BoneWeight : IEquatable<BoneWeight> // TypeDefIndex: 16278
{
	// Fields
	[SerializeField]
	private float m_Weight0; // 0x0
	[SerializeField]
	private float m_Weight1; // 0x4
	[SerializeField]
	private float m_Weight2; // 0x8
	[SerializeField]
	private float m_Weight3; // 0xC
	[SerializeField]
	private int m_BoneIndex0; // 0x10
	[SerializeField]
	private int m_BoneIndex1; // 0x14
	[SerializeField]
	private int m_BoneIndex2; // 0x18
	[SerializeField]
	private int m_BoneIndex3; // 0x1C

	// Properties
	public float weight0 { get; set; }
	public float weight1 { get; set; }
	public float weight2 { get; set; }
	public float weight3 { get; set; }
	public int boneIndex0 { get; set; }
	public int boneIndex1 { get; set; }
	public int boneIndex2 { get; set; }
	public int boneIndex3 { get; set; }

	// Methods

	// RVA: 0x37D97EC Offset: 0x37D57EC VA: 0x37D97EC
	public float get_weight0() { }

	// RVA: 0x37D97F4 Offset: 0x37D57F4 VA: 0x37D97F4
	public void set_weight0(float value) { }

	// RVA: 0x37D97FC Offset: 0x37D57FC VA: 0x37D97FC
	public float get_weight1() { }

	// RVA: 0x37D9804 Offset: 0x37D5804 VA: 0x37D9804
	public void set_weight1(float value) { }

	// RVA: 0x37D980C Offset: 0x37D580C VA: 0x37D980C
	public float get_weight2() { }

	// RVA: 0x37D9814 Offset: 0x37D5814 VA: 0x37D9814
	public void set_weight2(float value) { }

	// RVA: 0x37D981C Offset: 0x37D581C VA: 0x37D981C
	public float get_weight3() { }

	// RVA: 0x37D9824 Offset: 0x37D5824 VA: 0x37D9824
	public void set_weight3(float value) { }

	// RVA: 0x37D982C Offset: 0x37D582C VA: 0x37D982C
	public int get_boneIndex0() { }

	// RVA: 0x37D9834 Offset: 0x37D5834 VA: 0x37D9834
	public void set_boneIndex0(int value) { }

	// RVA: 0x37D983C Offset: 0x37D583C VA: 0x37D983C
	public int get_boneIndex1() { }

	// RVA: 0x37D9844 Offset: 0x37D5844 VA: 0x37D9844
	public void set_boneIndex1(int value) { }

	// RVA: 0x37D984C Offset: 0x37D584C VA: 0x37D984C
	public int get_boneIndex2() { }

	// RVA: 0x37D9854 Offset: 0x37D5854 VA: 0x37D9854
	public void set_boneIndex2(int value) { }

	// RVA: 0x37D985C Offset: 0x37D585C VA: 0x37D985C
	public int get_boneIndex3() { }

	// RVA: 0x37D9864 Offset: 0x37D5864 VA: 0x37D9864
	public void set_boneIndex3(int value) { }

	// RVA: 0x37D986C Offset: 0x37D586C VA: 0x37D986C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37D9974 Offset: 0x37D5974 VA: 0x37D9974 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x37D99FC Offset: 0x37D59FC VA: 0x37D99FC Slot: 4
	public bool Equals(BoneWeight other) { }
}
