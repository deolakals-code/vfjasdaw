// Assembly: Assembly-CSharp.dll
// Namespace: 
[CompilerGenerated]
private sealed class ModelManager.<MergeLoadModel>d__61 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 5351
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ModelManager <>4__this; // 0x20
	public int baseBoneId; // 0x28
	public List<MergeList> mergeList; // 0x30
	public int skinTextureId; // 0x38
	public int hairTextureId; // 0x3C
	public int eyeTextureId; // 0x40
	public float height; // 0x44
	public Dictionary<string, Vector3> boneScaleList; // 0x48
	public bool priority; // 0x50
	private ModelManager.<>c__DisplayClass61_0 <>8__1; // 0x58
	public Color skinColor; // 0x60
	public Color eyeColor; // 0x70
	public Color oddEyeColor; // 0x80
	public Color hairStreakColor; // 0x90
	public Color hairColor; // 0xA0
	public bool player; // 0xB0
	public Action<GameObject, float> callback; // 0xB8
	private BoneData <boneMatrixData>5__2; // 0xC0
	private List<Texture2D> <textures>5__3; // 0xC8
	private List<Shader> <shaders>5__4; // 0xD0
	private ModelData <modelData>5__5; // 0xD8
	private Color32[] <bodyColor>5__6; // 0xE0
	private float <offsetHeight>5__7; // 0xE8
	private Texture2D <skinTex>5__8; // 0xF0
	private Texture2D <hairTex>5__9; // 0xF8
	private Texture2D <eyeTex>5__10; // 0x100
	private ModelData[] <catchModelList>5__11; // 0x108
	private List<string> <weightBoneList>5__12; // 0x110
	private Dictionary<string, BoneData.BoneTrans> <exBoneList>5__13; // 0x118
	private int <mergeIndex>5__14; // 0x120
	private int <mergeCatchIndex>5__15; // 0x124
	private GameObject <mainSkin>5__16; // 0x128
	private SkinnedMeshRenderer <rootskin>5__17; // 0x130
	private Mesh <meshobj>5__18; // 0x138
	private List.Enumerator<MergeList> <>7__wrap18; // 0x140
	private MergeList <merge>5__20; // 0x158

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x2642D18 Offset: 0x263ED18 VA: 0x2642D18
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x2642D40 Offset: 0x263ED40 VA: 0x2642D40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2642D6C Offset: 0x263ED6C VA: 0x2642D6C Slot: 6
	private bool MoveNext() { }

	// RVA: 0x26461EC Offset: 0x26421EC VA: 0x26461EC
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x264623C Offset: 0x264223C VA: 0x264623C Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x2646244 Offset: 0x2642244 VA: 0x2646244 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x264627C Offset: 0x264227C VA: 0x264627C Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}
