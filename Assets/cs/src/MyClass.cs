
#pragma warning disable 109, 114, 219, 429, 168, 162
public  class MyClass : global::UnityEngine.MonoBehaviour, global::haxe.lang.IHxObject 
{
	public    MyClass(global::haxe.lang.EmptyObject empty) : base()
	{
		unchecked 
		{
		}
		#line default
	}
	
	
	public    MyClass() : base()
	{
		unchecked 
		{
		}
		#line default
	}
	
	
	public static   object __hx_createEmpty()
	{
		unchecked 
		{
			#line 8 "src/MyClass.hx"
			return new global::MyClass(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
		}
		#line default
	}
	
	
	public static   object __hx_create(global::Array arr)
	{
		unchecked 
		{
			#line 8 "src/MyClass.hx"
			return new global::MyClass();
		}
		#line default
	}
	
	
	public  global::UnityEngine.GameObject target;
	
	public  float speed;
	
	public virtual   void Start()
	{
		unchecked 
		{
			#line 11 "src/MyClass.hx"
			{
			}
			
		}
		#line default
	}
	
	
	public virtual   void Update()
	{
		unchecked 
		{
			#line 15 "src/MyClass.hx"
			global::haxe.Log.trace.__hx_invoke2_o(default(double), default(double), "hahhahha", new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{302979532, 1547539107, 1648581351}), new global::Array<object>(new object[]{"Update", "MyClass", "MyClass.hx"}), new global::Array<int>(new int[]{1981972957}), new global::Array<double>(new double[]{((double) (15) )})));
			#line 17 "src/MyClass.hx"
			if (( this.speed == 0 )) 
			{
				#line 17 "src/MyClass.hx"
				return ;
			}
			
			((global::UnityEngine.Transform) (global::haxe.lang.Runtime.getField(this, "transform", 1167273324, true)) ).position = global::UnityEngine.Vector3.MoveTowards(((global::UnityEngine.Transform) (global::haxe.lang.Runtime.getField(this, "transform", 1167273324, true)) ).position, this.target.transform.position, ( global::UnityEngine.Time.deltaTime * this.speed ));
		}
		#line default
	}
	
	
	public virtual   bool __hx_deleteField(string field, int hash)
	{
		unchecked 
		{
			#line 8 "src/MyClass.hx"
			return false;
		}
		#line default
	}
	
	
	public virtual   object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck)
	{
		unchecked 
		{
			#line 8 "src/MyClass.hx"
			if (isCheck) 
			{
				#line 8 "src/MyClass.hx"
				return global::haxe.lang.Runtime.undefined;
			}
			 else 
			{
				#line 8 "src/MyClass.hx"
				if (throwErrors) 
				{
					#line 8 "src/MyClass.hx"
					throw global::haxe.lang.HaxeException.wrap("Field not found.");
				}
				 else 
				{
					#line 8 "src/MyClass.hx"
					return default(object);
				}
				
			}
			
		}
		#line default
	}
	
	
	public virtual   double __hx_lookupField_f(string field, int hash, bool throwErrors)
	{
		unchecked 
		{
			#line 8 "src/MyClass.hx"
			if (throwErrors) 
			{
				#line 8 "src/MyClass.hx"
				throw global::haxe.lang.HaxeException.wrap("Field not found or incompatible field type.");
			}
			 else 
			{
				#line 8 "src/MyClass.hx"
				return default(double);
			}
			
		}
		#line default
	}
	
	
	public virtual   object __hx_lookupSetField(string field, int hash, object @value)
	{
		unchecked 
		{
			#line 8 "src/MyClass.hx"
			throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing.");
		}
		#line default
	}
	
	
	public virtual   double __hx_lookupSetField_f(string field, int hash, double @value)
	{
		unchecked 
		{
			#line 8 "src/MyClass.hx"
			throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing or incompatible type.");
		}
		#line default
	}
	
	
	public virtual   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
	{
		unchecked 
		{
			#line 8 "src/MyClass.hx"
			switch (hash)
			{
				case 23697287:
				{
					#line 8 "src/MyClass.hx"
					this.speed = ((float) (@value) );
					#line 8 "src/MyClass.hx"
					return @value;
				}
				
				
				default:
				{
					#line 8 "src/MyClass.hx"
					return this.__hx_lookupSetField_f(field, hash, @value);
				}
				
			}
			
		}
		#line default
	}
	
	
	public virtual   object __hx_setField(string field, int hash, object @value, bool handleProperties)
	{
		unchecked 
		{
			#line 8 "src/MyClass.hx"
			switch (hash)
			{
				case 1575675685:
				{
					#line 8 "src/MyClass.hx"
					this.hideFlags = ((global::UnityEngine.HideFlags) (@value) );
					#line 8 "src/MyClass.hx"
					return @value;
				}
				
				
				case 1224700491:
				{
					#line 8 "src/MyClass.hx"
					this.name = global::haxe.lang.Runtime.toString(@value);
					#line 8 "src/MyClass.hx"
					return @value;
				}
				
				
				case 5790298:
				{
					#line 8 "src/MyClass.hx"
					this.tag = global::haxe.lang.Runtime.toString(@value);
					#line 8 "src/MyClass.hx"
					return @value;
				}
				
				
				case 2117141633:
				{
					#line 8 "src/MyClass.hx"
					this.enabled = ((bool) (@value) );
					#line 8 "src/MyClass.hx"
					return @value;
				}
				
				
				case 896046654:
				{
					#line 8 "src/MyClass.hx"
					this.useGUILayout = ((bool) (@value) );
					#line 8 "src/MyClass.hx"
					return @value;
				}
				
				
				case 23697287:
				{
					#line 8 "src/MyClass.hx"
					this.speed = ((float) (global::haxe.lang.Runtime.toInt(@value)) );
					#line 8 "src/MyClass.hx"
					return @value;
				}
				
				
				case 116192081:
				{
					#line 8 "src/MyClass.hx"
					this.target = ((global::UnityEngine.GameObject) (@value) );
					#line 8 "src/MyClass.hx"
					return @value;
				}
				
				
				default:
				{
					#line 8 "src/MyClass.hx"
					return this.__hx_lookupSetField(field, hash, @value);
				}
				
			}
			
		}
		#line default
	}
	
	
	public virtual   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties)
	{
		unchecked 
		{
			#line 8 "src/MyClass.hx"
			switch (hash)
			{
				case 1635357710:
				{
					#line 8 "src/MyClass.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("DontDestroyOnLoad"), ((int) (1635357710) ))) );
				}
				
				
				case 1003238327:
				{
					#line 8 "src/MyClass.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("DestroyImmediate"), ((int) (1003238327) ))) );
				}
				
				
				case 1909937370:
				{
					#line 8 "src/MyClass.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Destroy"), ((int) (1909937370) ))) );
				}
				
				
				case 304123084:
				{
					#line 8 "src/MyClass.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("ToString"), ((int) (304123084) ))) );
				}
				
				
				case 276486854:
				{
					#line 8 "src/MyClass.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetInstanceID"), ((int) (276486854) ))) );
				}
				
				
				case 1575675685:
				{
					#line 8 "src/MyClass.hx"
					return this.hideFlags;
				}
				
				
				case 1224700491:
				{
					#line 8 "src/MyClass.hx"
					return this.name;
				}
				
				
				case 2134927590:
				{
					#line 8 "src/MyClass.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("BroadcastMessage"), ((int) (2134927590) ))) );
				}
				
				
				case 139469119:
				{
					#line 8 "src/MyClass.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("SendMessage"), ((int) (139469119) ))) );
				}
				
				
				case 294420221:
				{
					#line 8 "src/MyClass.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("SendMessageUpwards"), ((int) (294420221) ))) );
				}
				
				
				case 89600725:
				{
					#line 8 "src/MyClass.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("CompareTag"), ((int) (89600725) ))) );
				}
				
				
				case 2122408236:
				{
					#line 8 "src/MyClass.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponents"), ((int) (2122408236) ))) );
				}
				
				
				case 967979664:
				{
					#line 8 "src/MyClass.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponentsInChildren"), ((int) (967979664) ))) );
				}
				
				
				case 1328964235:
				{
					#line 8 "src/MyClass.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponentInChildren"), ((int) (1328964235) ))) );
				}
				
				
				case 1723652455:
				{
					#line 8 "src/MyClass.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponent"), ((int) (1723652455) ))) );
				}
				
				
				case 5790298:
				{
					#line 8 "src/MyClass.hx"
					return this.tag;
				}
				
				
				case 2117141633:
				{
					#line 8 "src/MyClass.hx"
					return this.enabled;
				}
				
				
				case 1856815770:
				{
					#line 8 "src/MyClass.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StopAllCoroutines"), ((int) (1856815770) ))) );
				}
				
				
				case 2084823382:
				{
					#line 8 "src/MyClass.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StopCoroutine"), ((int) (2084823382) ))) );
				}
				
				
				case 987108662:
				{
					#line 8 "src/MyClass.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StartCoroutine"), ((int) (987108662) ))) );
				}
				
				
				case 602588383:
				{
					#line 8 "src/MyClass.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("IsInvoking"), ((int) (602588383) ))) );
				}
				
				
				case 757431474:
				{
					#line 8 "src/MyClass.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("CancelInvoke"), ((int) (757431474) ))) );
				}
				
				
				case 1641152943:
				{
					#line 8 "src/MyClass.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("InvokeRepeating"), ((int) (1641152943) ))) );
				}
				
				
				case 1416948632:
				{
					#line 8 "src/MyClass.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Invoke"), ((int) (1416948632) ))) );
				}
				
				
				case 896046654:
				{
					#line 8 "src/MyClass.hx"
					return this.useGUILayout;
				}
				
				
				case 999946793:
				{
					#line 8 "src/MyClass.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Update"), ((int) (999946793) ))) );
				}
				
				
				case 389604418:
				{
					#line 8 "src/MyClass.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Start"), ((int) (389604418) ))) );
				}
				
				
				case 23697287:
				{
					#line 8 "src/MyClass.hx"
					return this.speed;
				}
				
				
				case 116192081:
				{
					#line 8 "src/MyClass.hx"
					return this.target;
				}
				
				
				default:
				{
					#line 8 "src/MyClass.hx"
					return this.__hx_lookupField(field, hash, throwErrors, isCheck);
				}
				
			}
			
		}
		#line default
	}
	
	
	public virtual   double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties)
	{
		unchecked 
		{
			#line 8 "src/MyClass.hx"
			switch (hash)
			{
				case 23697287:
				{
					#line 8 "src/MyClass.hx"
					return ((double) (this.speed) );
				}
				
				
				default:
				{
					#line 8 "src/MyClass.hx"
					return this.__hx_lookupField_f(field, hash, throwErrors);
				}
				
			}
			
		}
		#line default
	}
	
	
	public virtual   object __hx_invokeField(string field, int hash, global::Array dynargs)
	{
		unchecked 
		{
			#line 8 "src/MyClass.hx"
			switch (hash)
			{
				case 1416948632:case 1641152943:case 757431474:case 602588383:case 987108662:case 2084823382:case 1856815770:case 1723652455:case 1328964235:case 967979664:case 2122408236:case 89600725:case 294420221:case 139469119:case 2134927590:case 276486854:case 304123084:case 1909937370:case 1003238327:case 1635357710:
				{
					#line 8 "src/MyClass.hx"
					return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
				}
				
				
				case 999946793:
				{
					#line 8 "src/MyClass.hx"
					this.Update();
					#line 8 "src/MyClass.hx"
					break;
				}
				
				
				case 389604418:
				{
					#line 8 "src/MyClass.hx"
					this.Start();
					#line 8 "src/MyClass.hx"
					break;
				}
				
				
				default:
				{
					#line 8 "src/MyClass.hx"
					return ((global::haxe.lang.Function) (this.__hx_getField(field, hash, true, false, false)) ).__hx_invokeDynamic(dynargs);
				}
				
			}
			
			#line 8 "src/MyClass.hx"
			return default(object);
		}
		#line default
	}
	
	
	public virtual   void __hx_getFields(global::Array<object> baseArr)
	{
		unchecked 
		{
			#line 8 "src/MyClass.hx"
			baseArr.push("hideFlags");
			#line 8 "src/MyClass.hx"
			baseArr.push("name");
			#line 8 "src/MyClass.hx"
			baseArr.push("tag");
			#line 8 "src/MyClass.hx"
			baseArr.push("enabled");
			#line 8 "src/MyClass.hx"
			baseArr.push("useGUILayout");
			#line 8 "src/MyClass.hx"
			baseArr.push("speed");
			#line 8 "src/MyClass.hx"
			baseArr.push("target");
		}
		#line default
	}
	
	
}


