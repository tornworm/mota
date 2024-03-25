using UnityEditor;
using UnityEngine;

public class GridEditorWindow : EditorWindow
{
    private const int GridWidth = 12;
    private const int GridHeight = 9;
    private const int CellSize = 50;
    private const int CellPadding = 2;
    private const int TotalCellSize = CellSize + CellPadding;
    private bool[] cellStates;

    [MenuItem("Tools/BattleMapEdit")]
    static void Init()
    {
        GridEditorWindow window = (GridEditorWindow)EditorWindow.GetWindow(typeof(GridEditorWindow), false, "BattleMapEdit");
        window.Show();
        window.InitCells();
    }

    void InitCells()
    {
        cellStates = new bool[GridWidth * GridHeight];
    }

    void OnGUI()
    {
        // 计算格子绘制的起始X坐标，使得格子部分在窗口中靠左居中
        int gridStartX = 10;
        int gridStartY = (int)((position.height - (GridHeight * TotalCellSize)) / 2);

        DrawGrid(gridStartX, gridStartY);
        ProcessClicks(gridStartX, gridStartY);

        // 将按钮绘制在右上角
        GUILayout.BeginArea(new Rect(position.width - 110, 10, 100, 30));
        if (GUILayout.Button("Print States"))
        {
            PrintCellStates();
        }
        GUILayout.EndArea();
    }

    void DrawGrid(int startX, int startY)
    {
        for (int y = 0; y < GridHeight; y++)
        {
            for (int x = 0; x < GridWidth; x++)
            {
                int index = y * GridWidth + x;
                Rect cellRect = new Rect(startX + x * TotalCellSize, startY + y * TotalCellSize, CellSize, CellSize);
                EditorGUI.DrawRect(cellRect, cellStates[index] ? Color.gray : Color.white);
            }
        }
    }

    void ProcessClicks(int startX, int startY)
    {
        if (Event.current.type == EventType.MouseDown)
        {
            Vector2 mousePosition = Event.current.mousePosition;
            int x = (int)(mousePosition.x - startX) / TotalCellSize;
            int y = (int)(mousePosition.y - startY) / TotalCellSize;
            if (x >= 0 && x < GridWidth && y >= 0 && y < GridHeight)
            {
                int index = y * GridWidth + x;
                cellStates[index] = !cellStates[index];
                Repaint();
            }
        }
    }

    void PrintCellStates()
    {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        for (int y = 0; y < GridHeight; y++)
        {
            for (int x = 0; x < GridWidth; x++)
            {
                int index = y * GridWidth + x;
                sb.Append(cellStates[index] ? "1" : "0");
            }
            sb.AppendLine();
        }
        Debug.Log(sb.ToString());
    }
}