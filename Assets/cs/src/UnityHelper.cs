
#pragma warning disable 109, 114, 219, 429, 168, 162
public  class UnityHelper : global::haxe.lang.HxObject 
{
	public    UnityHelper(global::haxe.lang.EmptyObject empty)
	{
		unchecked 
		{
			#line 6 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
			{
			}
			
		}
		#line default
	}
	
	
	public    UnityHelper()
	{
		unchecked 
		{
			#line 6 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
			global::UnityHelper.__hx_ctor__UnityHelper(this);
		}
		#line default
	}
	
	
	public static   void __hx_ctor__UnityHelper(global::UnityHelper __temp_me9)
	{
		unchecked 
		{
			#line 6 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
			{
			}
			
		}
		#line default
	}
	
	
	public static   global::Array<T> toArray<T>(T[] na)
	{
		unchecked 
		{
			#line 8 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
			global::Array<T> a = new global::Array<T>(new T[]{});
			{
				#line 9 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
				int _g1 = 0;
				#line 9 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
				int _g = na.Length;
				#line 9 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
				while (( _g1 < _g ))
				{
					#line 9 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
					int i = _g1++;
					#line 9 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
					a.push(na[i]);
				}
				
			}
			
			return a;
		}
		#line default
	}
	
	
	public static   global::UnityEngine.Transform getTransform(global::UnityEngine.Component c)
	{
		unchecked 
		{
			#line 13 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
			return ((global::UnityEngine.Transform) (global::haxe.lang.Runtime.getField(c, "transform", 1167273324, true)) );
		}
		#line default
	}
	
	
	public static   global::UnityEngine.Renderer getRenderer(global::UnityEngine.Component c)
	{
		unchecked 
		{
			#line 14 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
			return ((global::UnityEngine.Renderer) (global::haxe.lang.Runtime.getField(c, "renderer", 853263683, true)) );
		}
		#line default
	}
	
	
	public static   global::UnityEngine.Rigidbody getRigidbody(global::UnityEngine.Component c)
	{
		unchecked 
		{
			#line 15 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
			return ((global::UnityEngine.Rigidbody) (global::haxe.lang.Runtime.getField(c, "rigidbody", 1895479501, true)) );
		}
		#line default
	}
	
	
	public static   global::UnityEngine.Camera getCamera(global::UnityEngine.Component c)
	{
		unchecked 
		{
			#line 16 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
			return ((global::UnityEngine.Camera) (global::haxe.lang.Runtime.getField(c, "camera", 931940005, true)) );
		}
		#line default
	}
	
	
	public static   global::UnityEngine.Light getLight(global::UnityEngine.Component c)
	{
		unchecked 
		{
			#line 17 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
			return ((global::UnityEngine.Light) (global::haxe.lang.Runtime.getField(c, "light", 1962709206, true)) );
		}
		#line default
	}
	
	
	public static   global::UnityEngine.Animation getAnimation(global::UnityEngine.Component c)
	{
		unchecked 
		{
			#line 18 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
			return ((global::UnityEngine.Animation) (global::haxe.lang.Runtime.getField(c, "animation", 1261760260, true)) );
		}
		#line default
	}
	
	
	public static   global::UnityEngine.ConstantForce getConstantForce(global::UnityEngine.Component c)
	{
		unchecked 
		{
			#line 19 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
			return ((global::UnityEngine.ConstantForce) (global::haxe.lang.Runtime.getField(c, "constantForce", 1431885287, true)) );
		}
		#line default
	}
	
	
	public static   global::UnityEngine.GameObject getGameObject(global::UnityEngine.Component c)
	{
		unchecked 
		{
			#line 20 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
			return ((global::UnityEngine.GameObject) (global::haxe.lang.Runtime.getField(c, "gameObject", 1471506513, true)) );
		}
		#line default
	}
	
	
	public static   global::UnityEngine.GUITexture getGuiTexture(global::UnityEngine.Component c)
	{
		unchecked 
		{
			#line 21 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
			return ((global::UnityEngine.GUITexture) (global::haxe.lang.Runtime.getField(c, "guiTexture", 674101152, true)) );
		}
		#line default
	}
	
	
	public static   global::UnityEngine.GUIText getGuiText(global::UnityEngine.Component c)
	{
		unchecked 
		{
			#line 22 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
			return ((global::UnityEngine.GUIText) (global::haxe.lang.Runtime.getField(c, "guiText", 801759432, true)) );
		}
		#line default
	}
	
	
	public static   global::UnityEngine.Renderer chRenderer(global::UnityEngine.Component c)
	{
		unchecked 
		{
			#line 24 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
			return ((global::UnityEngine.Renderer) (c.GetComponentInChildren(typeof(global::UnityEngine.Renderer))) );
		}
		#line default
	}
	
	
	public static   global::Array<object> chsRenderers(global::UnityEngine.Component c)
	{
		unchecked 
		{
			#line 28 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
			return global::UnityHelper.toArray<object>(c.GetComponentsInChildren(typeof(global::UnityEngine.Renderer)));
		}
		#line default
	}
	
	
	public static  new object __hx_createEmpty()
	{
		unchecked 
		{
			#line 6 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
			return new global::UnityHelper(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
		}
		#line default
	}
	
	
	public static  new object __hx_create(global::Array arr)
	{
		unchecked 
		{
			#line 6 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
			return new global::UnityHelper();
		}
		#line default
	}
	
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public  class UnityHelperGO : global::haxe.lang.HxObject 
{
	public    UnityHelperGO(global::haxe.lang.EmptyObject empty)
	{
		unchecked 
		{
			#line 31 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
			{
			}
			
		}
		#line default
	}
	
	
	public    UnityHelperGO()
	{
		unchecked 
		{
			#line 31 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
			global::UnityHelperGO.__hx_ctor__UnityHelperGO(this);
		}
		#line default
	}
	
	
	public static   void __hx_ctor__UnityHelperGO(global::UnityHelperGO __temp_me10)
	{
		unchecked 
		{
			#line 31 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
			{
			}
			
		}
		#line default
	}
	
	
	public static   global::UnityEngine.Transform getTransform(global::UnityEngine.GameObject c)
	{
		unchecked 
		{
			#line 32 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
			return c.transform;
		}
		#line default
	}
	
	
	public static   global::UnityEngine.Renderer getRenderer(global::UnityEngine.GameObject c)
	{
		unchecked 
		{
			#line 33 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
			return c.renderer;
		}
		#line default
	}
	
	
	public static   global::UnityEngine.Rigidbody getRigidbody(global::UnityEngine.GameObject c)
	{
		unchecked 
		{
			#line 34 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
			return c.rigidbody;
		}
		#line default
	}
	
	
	public static   global::UnityEngine.Camera getCamera(global::UnityEngine.GameObject c)
	{
		unchecked 
		{
			#line 35 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
			return c.camera;
		}
		#line default
	}
	
	
	public static   global::UnityEngine.Light getLight(global::UnityEngine.GameObject c)
	{
		unchecked 
		{
			#line 36 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
			return c.light;
		}
		#line default
	}
	
	
	public static   global::UnityEngine.Animation getAnimation(global::UnityEngine.GameObject c)
	{
		unchecked 
		{
			#line 37 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
			return c.animation;
		}
		#line default
	}
	
	
	public static   global::UnityEngine.ConstantForce getConstantForce(global::UnityEngine.GameObject c)
	{
		unchecked 
		{
			#line 38 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
			return c.constantForce;
		}
		#line default
	}
	
	
	public static   global::UnityEngine.GameObject getGameObject(global::UnityEngine.GameObject c)
	{
		unchecked 
		{
			#line 39 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
			return c;
		}
		#line default
	}
	
	
	public static   global::UnityEngine.GUITexture getGuiTexture(global::UnityEngine.GameObject c)
	{
		unchecked 
		{
			#line 40 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
			return c.guiTexture;
		}
		#line default
	}
	
	
	public static   global::UnityEngine.GUIText getGuiText(global::UnityEngine.GameObject c)
	{
		unchecked 
		{
			#line 41 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
			return c.guiText;
		}
		#line default
	}
	
	
	public static   T getComp<T>(global::UnityEngine.GameObject g, global::System.Type cl)
	{
		unchecked 
		{
			#line 43 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
			return global::haxe.lang.Runtime.genericCast<T>(((object) (g.GetComponent(global::haxe.lang.Runtime.toString(global::haxe.lang.StringExt.split(global::Type.getClassName(cl), ".").pop().@value))) ));
		}
		#line default
	}
	
	
	public static  new object __hx_createEmpty()
	{
		unchecked 
		{
			#line 31 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
			return new global::UnityHelperGO(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
		}
		#line default
	}
	
	
	public static  new object __hx_create(global::Array arr)
	{
		unchecked 
		{
			#line 31 "/usr/lib/haxe/lib/unity3d/0,0,5/UnityHelper.hx"
			return new global::UnityHelperGO();
		}
		#line default
	}
	
	
}


