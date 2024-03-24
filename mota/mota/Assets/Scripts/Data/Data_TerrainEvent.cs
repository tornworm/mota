using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Data_TerrainEvent
{
private static Data_TerrainEvent instance;
public static Data_TerrainEvent Singleton {
	get {
		if (instance==null)
			instance = new Data_TerrainEvent();
		return instance;
	}	
}
public Data_TerrainEvent(){
	Onload();
}
private int row = 17;//列数
public List<int>list0=new List<int>();//0
public List<int>list1=new List<int>();//1
public List<int>list2=new List<int>();//2
public List<string>list3=new List<string>();//3
public List<string>list4=new List<string>();//4
public List<int>list5=new List<int>();//5
public List<float>list6=new List<float>();//6
public List<int>list7=new List<int>();//7
public List<int>list8=new List<int>();//8
public List<int>list9=new List<int>();//9
public List<int>list10=new List<int>();//10
public List<int>list11=new List<int>();//11
public List<int>list12=new List<int>();//12
public List<int>list13=new List<int>();//13
public List<int>list14=new List<int>();//14
public List<int>list15=new List<int>();//15
public List<int>list16=new List<int>();//16
  public int GetWord(int id)
{
    return list1[id-1];
}
  public int GetGroup(int id)
{
    return list2[id-1];
}
  public string GetName(int id)
{
    return list3[id-1];
}
  public string GetPrafab(int id)
{
    return list4[id-1];
}
  public int GetTriggerType(int id)
{
    return list5[id-1];
}
  public float GetTriggerTypeValue(int id)
{
    return list6[id-1];
}
  public int GetPropertyKey(int id)
{
    return list7[id-1];
}
  public int GetPropertyValue(int id)
{
    return list8[id-1];
}
  public int GetItemKey(int id)
{
    return list9[id-1];
}
  public int GetItemValue(int id)
{
    return list10[id-1];
}
  public int GetEventKey(int id)
{
    return list11[id-1];
}
  public int GetEvnetValue(int id)
{
    return list12[id-1];
}
  public int GetTaskKey(int id)
{
    return list13[id-1];
}
  public int GetTaskValue(int id)
{
    return list14[id-1];
}
  public int GetUIKey(int id)
{
    return list15[id-1];
}
  public int GetUI_Value(int id)
{
    return list16[id-1];
}
public void Onload()
 {       StreamReader sr = File.OpenText(Application.dataPath+"/StreamingAssets/Data_TerrainEvent.txt");
       string lineText;
       lineText=sr.ReadLine();
       string[] lines = File.ReadAllLines(Application.dataPath+"/StreamingAssets/Data_TerrainEvent.txt");
      // while ((lineText = sr.ReadLine()) != null){

        for(int i=2;i<lines.Length;i++)
        {
       string[] lineArray = lines[i].Split('\t');  
             list0.Add(int.Parse(lineArray[0]));
             list1.Add(int.Parse(lineArray[1]));
             list2.Add(int.Parse(lineArray[2]));
             list3.Add(lineArray[3]);
             list4.Add(lineArray[4]);
             list5.Add(int.Parse(lineArray[5]));
             list6.Add(float.Parse(lineArray[6]));
             list7.Add(int.Parse(lineArray[7]));
             list8.Add(int.Parse(lineArray[8]));
             list9.Add(int.Parse(lineArray[9]));
             list10.Add(int.Parse(lineArray[10]));
             list11.Add(int.Parse(lineArray[11]));
             list12.Add(int.Parse(lineArray[12]));
             list13.Add(int.Parse(lineArray[13]));
             list14.Add(int.Parse(lineArray[14]));
             list15.Add(int.Parse(lineArray[15]));
             list16.Add(int.Parse(lineArray[16]));
        }

    
}
    
}
