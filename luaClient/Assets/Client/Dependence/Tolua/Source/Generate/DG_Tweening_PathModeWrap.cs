﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class DG_Tweening_PathModeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(DG.Tweening.PathMode));
		L.RegVar("Ignore", get_Ignore, null);
		L.RegVar("Full3D", get_Full3D, null);
		L.RegVar("TopDown2D", get_TopDown2D, null);
		L.RegVar("Sidescroller2D", get_Sidescroller2D, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Ignore(IntPtr L)
	{
		ToLua.Push(L, DG.Tweening.PathMode.Ignore);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Full3D(IntPtr L)
	{
		ToLua.Push(L, DG.Tweening.PathMode.Full3D);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_TopDown2D(IntPtr L)
	{
		ToLua.Push(L, DG.Tweening.PathMode.TopDown2D);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Sidescroller2D(IntPtr L)
	{
		ToLua.Push(L, DG.Tweening.PathMode.Sidescroller2D);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		DG.Tweening.PathMode o = (DG.Tweening.PathMode)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}
