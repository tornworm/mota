using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Data_Terrain
{
private static Data_Terrain instance;
public static Data_Terrain Singleton {
	get {
		if (instance==null)
			instance = new Data_Terrain();
		return instance;
	}	
}
public Data_Terrain(){
	Onload();
}
private int row = 5;//列数
public List<int>list0=new List<int>();//0
public List<int>list1=new List<int>();//1
public List<int>list2=new List<int>();//2
public List<string>list3=new List<string>();//3
public List<string>list4=new List<string>();//4
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
  public string GetTexturePrafab(int id)
{
    return list4[id-1];
}
public void Onload()
 {       StreamReader sr = File.OpenText(Application.dataPath+"/StreamingAssets/Data_Terrain.txt");
       string lineText;
       lineText=sr.ReadLine();
       string[] lines = File.ReadAllLines(Application.dataPath+"/StreamingAssets/Data_Terrain.txt");
      // while ((lineText = sr.ReadLine()) != null){

        for(int i=2;i<lines.Length;i++)
        {
       string[] lineArray = lines[i].Split('\t');  
             list0.Add(int.Parse(lineArray[0]));
             list1.Add(int.Parse(lineArray[1]));
             list2.Add(int.Parse(lineArray[2]));
             list3.Add(lineArray[3]);
             list4.Add(lineArray[4]);
        }

    
}
    
}
