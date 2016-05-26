/*
 * 由SharpDevelop创建。
 * 用户： EmingK
 * 日期: 2013/8/22
 * 时间: 15:23
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace osm
{
	class Program
	{
		public static void Main(string[] args)
		{
			osmProcessor p=new osmProcessor();
			p.setFile(args[0]);
			p.writeOutput();
		}
	}
}