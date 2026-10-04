// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DefenceMapRouteSearch // TypeDefIndex: 3876
{
	// Fields
	private int startPosX; // 0x10
	private int startPosY; // 0x14
	private int goalPosX; // 0x18
	private int goalPosY; // 0x1C
	private List<DefencePoint2> route; // 0x20
	private List<DefenceMapNode> openList; // 0x28
	private DefenceMapNode[,] map; // 0x30
	private int mapWidth; // 0x38
	private int mapHeight; // 0x3C
	private bool isError; // 0x40

	// Methods

	// RVA: 0x2403E5C Offset: 0x23FFE5C VA: 0x2403E5C
	public void .ctor(int mapWidth, int mapHeight, int startX, int startY, int goalX, int goalY) { }

	// RVA: 0x2403F70 Offset: 0x23FFF70 VA: 0x2403F70
	private DefenceMapNode[,] CloneMapBase(DefenceMapNode[,] map) { }

	// RVA: 0x2404138 Offset: 0x2400138 VA: 0x2404138
	private void Init() { }

	// RVA: 0x24041C8 Offset: 0x24001C8 VA: 0x24041C8
	public static List<DefencePoint2> Start(int mapWidth, int mapHeight, int startX, int startY, int goalX, int goalY, DefenceMapNode[,] map) { }

	// RVA: 0x2404278 Offset: 0x2400278 VA: 0x2404278
	private void Search(DefenceMapNode[,] map) { }

	// RVA: 0x2404460 Offset: 0x2400460 VA: 0x2404460
	private void ReSearch() { }

	// RVA: 0x2404528 Offset: 0x2400528 VA: 0x2404528
	private void Open() { }

	// RVA: 0x2404A9C Offset: 0x2400A9C VA: 0x2404A9C
	private void Open(int offsetX, int offsetY) { }

	// RVA: 0x24046B4 Offset: 0x24006B4 VA: 0x24046B4
	private void Close() { }

	// RVA: 0x2404958 Offset: 0x2400958 VA: 0x2404958
	private void SetRoute() { }
}
