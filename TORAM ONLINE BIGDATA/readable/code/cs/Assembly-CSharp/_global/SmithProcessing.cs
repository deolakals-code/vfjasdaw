// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SmithProcessing : MonoBehaviour // TypeDefIndex: 8533
{
	// Fields
	[SerializeField]
	private SmithProcessingDialog Dialog; // 0x20
	private SmithItemManager itemManager; // 0x28
	private SystemTextManager systemTextManager; // 0x30
	private ItemTextManager itemTextManager; // 0x38
	private bool isGuildStaff; // 0x40
	private PlayerDataManager playerDataManager; // 0x48
	private bool isConnect; // 0x50
	private MaterialProcessingResponse connectResponse; // 0x58

	// Methods

	// RVA: 0x1D9D084 Offset: 0x1D99084 VA: 0x1D9D084
	private void Start() { }

	// RVA: 0x1D9D2D4 Offset: 0x1D992D4 VA: 0x1D9D2D4
	public void ActiveGuildStaff() { }

	// RVA: 0x1D9D3C8 Offset: 0x1D993C8 VA: 0x1D9D3C8
	private void Update() { }

	// RVA: 0x1D9D3CC Offset: 0x1D993CC VA: 0x1D9D3CC
	public void CallProcessing(Object obj) { }

	[IteratorStateMachine(typeof(SmithProcessing.<ProcessingConnectWait>d__13))]
	// RVA: 0x1D9D3EC Offset: 0x1D993EC VA: 0x1D9D3EC
	private IEnumerator ProcessingConnectWait(Object obj) { }

	[IteratorStateMachine(typeof(SmithProcessing.<ProcessConnect>d__14))]
	// RVA: 0x1D9D49C Offset: 0x1D9949C VA: 0x1D9D49C
	private IEnumerator ProcessConnect() { }

	// RVA: 0x1D9D530 Offset: 0x1D99530 VA: 0x1D9D530
	public void .ctor() { }
}
