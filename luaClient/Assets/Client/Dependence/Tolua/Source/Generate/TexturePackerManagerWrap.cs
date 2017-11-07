﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class TexturePackerManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(TexturePackerManager), typeof(System.Object));
		L.RegFunction("GetSprite", GetSprite);
		L.RegFunction("UnLoadAllAtlas", UnLoadAllAtlas);
		L.RegFunction("UnLoadAtlas", UnLoadAtlas);
		L.RegFunction("New", _CreateTexturePackerManager);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("spritePackers", get_spritePackers, set_spritePackers);
		L.RegVar("Instance", get_Instance, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateTexturePackerManager(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				TexturePackerManager obj = new TexturePackerManager();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: TexturePackerManager.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSprite(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			TexturePackerManager obj = (TexturePackerManager)ToLua.CheckObject(L, 1, typeof(TexturePackerManager));
			string arg0 = ToLua.CheckString(L, 2);
			string arg1 = ToLua.CheckString(L, 3);
			UnityEngine.Sprite o = obj.GetSprite(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnLoadAllAtlas(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			TexturePackerManager obj = (TexturePackerManager)ToLua.CheckObject(L, 1, typeof(TexturePackerManager));
			obj.UnLoadAllAtlas();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnLoadAtlas(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			TexturePackerManager obj = (TexturePackerManager)ToLua.CheckObject(L, 1, typeof(TexturePackerManager));
			string arg0 = ToLua.CheckString(L, 2);
			obj.UnLoadAtlas(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_spritePackers(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TexturePackerManager obj = (TexturePackerManager)o;
			System.Collections.Generic.Dictionary<string,TexturePacker> ret = obj.spritePackers;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index spritePackers on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Instance(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, TexturePackerManager.Instance);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_spritePackers(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TexturePackerManager obj = (TexturePackerManager)o;
			System.Collections.Generic.Dictionary<string,TexturePacker> arg0 = (System.Collections.Generic.Dictionary<string,TexturePacker>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.Dictionary<string,TexturePacker>));
			obj.spritePackers = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index spritePackers on a nil value" : e.Message);
		}
	}
}
