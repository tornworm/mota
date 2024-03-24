using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Data_MapTerrain
{
private static Data_MapTerrain instance;
public static Data_MapTerrain Singleton {
	get {
		if (instance==null)
			instance = new Data_MapTerrain();
		return instance;
	}	
}
public Data_MapTerrain(){
	Onload();
}
private int row = 13;//列数
public List<int>list0=new List<int>();//0
public List<int>list1=new List<int>();//1
public List<string>list2=new List<string>();//2
public List<string>list3=new List<string>();//3
public List<string>list4=new List<string>();//4
public List<string>list5=new List<string>();//5
public List<string>list6=new List<string>();//6
public List<string>list7=new List<string>();//7
public List<string>list8=new List<string>();//8
public List<string>list9=new List<string>();//9
public List<string>list10=new List<string>();//10
public List<string>list11=new List<string>();//11
public List<string>list12=new List<string>();//12
  public int GetWord(int id)
{
    return list1[id-1];
}
  public string GetName(int id)
{
    return list2[id-1];
}
  public string GetTerrain_0(int id)
{
    return list3[id-1];
}
  public string GetTerrain_1(int id)
{
    return list4[id-1];
}
  public string GetTerrain_2(int id)
{
    return list5[id-1];
}
  public string GetTerrain_3(int id)
{
    return list6[id-1];
}
  public string GetTerrain_4(int id)
{
    return list7[id-1];
}
  public string GetTerrain_5(int id)
{
    return list8[id-1];
}
  public string GetTerrain_6(int id)
{
    return list9[id-1];
}
  public string GetTerrain_7(int id)
{
    return list10[id-1];
}
  public string GetTerrain_8(int id)
{
    return list11[id-1];
}
  public string GetTerrain_9(int id)
{
    return list12[id-1];
}
public void Onload()
 {       StreamReader sr = File.OpenText(Application.dataPath+"/StreamingAssets/Data_MapTerrain.txt");
       string lineText;
       lineText=sr.ReadLine();
       string[] lines = File.ReadAllLines(Application.dataPath+"/StreamingAssets/Data_MapTerrain.txt");
      // while ((lineText = sr.ReadLine()) != null){

        for(int i=2;i<lines.Length;i++)
        {
       string[] lineArray = lines[i].Split('\t');  
             list0.Add(int.Parse(lineArray[0]));
             list1.Add(int.Parse(lineArray[1]));
             list2.Add(lineArray[2]);
             list3.Add(lineArray[3]);
             list4.Add(lineArray[4]);
             list5.Add(lineArray[5]);
             list6.Add(lineArray[6]);
             list7.Add(lineArray[7]);
             list8.Add(lineArray[8]);
             list9.Add(lineArray[9]);
             list10.Add(lineArray[10]);
             list11.Add(lineArray[11]);
             list12.Add(lineArray[12]);
        }

    
}
    
}
