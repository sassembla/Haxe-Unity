
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang
{
	public  class FieldLookup : global::haxe.lang.HxObject 
	{
		public    FieldLookup(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 25 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    FieldLookup()
		{
			unchecked 
			{
				#line 25 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
				global::haxe.lang.FieldLookup.__hx_ctor_haxe_lang_FieldLookup(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_haxe_lang_FieldLookup(global::haxe.lang.FieldLookup __temp_me13)
		{
			unchecked 
			{
				#line 25 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static  global::Array<int> fieldIds = new global::Array<int>(new int[]{98, 4745537, 5442204, 5594513, 5790298, 23697287, 76061764, 87367608, 89600725, 116192081, 139469119, 276486854, 294420221, 295397041, 302979532, 304123084, 328878574, 389604418, 407283053, 452737314, 501039929, 520590566, 589796196, 602588383, 674101152, 757431474, 801759432, 853263683, 896046654, 931940005, 946786476, 967979664, 987108662, 999946793, 1003238327, 1041537810, 1067353468, 1103412149, 1167273324, 1181037546, 1204816148, 1224700491, 1224901875, 1247875546, 1261760260, 1280845662, 1282943179, 1328964235, 1352786672, 1416948632, 1431885287, 1471506513, 1532710347, 1547539107, 1575675685, 1620824029, 1621420777, 1635357710, 1641152943, 1648581351, 1705629508, 1723652455, 1744813180, 1836776262, 1856815770, 1895479501, 1909937370, 1915412854, 1916009602, 1955029599, 1962709206, 1981972957, 2025055113, 2082663554, 2084789794, 2084823382, 2117141633, 2122408236, 2127021138, 2134927590});
		
		public static  global::Array<object> fields = new global::Array<object>(new object[]{"b", "__a", "map", "pop", "tag", "speed", "remove", "filter", "CompareTag", "target", "SendMessage", "GetInstanceID", "SendMessageUpwards", "GetHashCode", "methodName", "ToString", "iterator", "Start", "hasNext", "reverse", "insert", "length", "getTag", "IsInvoking", "guiTexture", "CancelInvoke", "guiText", "renderer", "useGUILayout", "camera", "toString", "GetComponentsInChildren", "StartCoroutine", "Update", "DestroyImmediate", "index", "splice", "copy", "transform", "join", "concat", "name", "next", "push", "animation", "sort", "quicksort", "GetComponentInChildren", "spliceVoid", "Invoke", "constantForce", "gameObject", "concatNative", "className", "hideFlags", "__unsafe_get", "__unsafe_set", "DontDestroyOnLoad", "InvokeRepeating", "fileName", "toDynamic", "GetComponent", "constructs", "params", "StopAllCoroutines", "rigidbody", "Destroy", "__get", "__set", "Equals", "light", "lineNumber", "unshift", "shift", "__hx_createEmpty", "StopCoroutine", "enabled", "GetComponents", "slice", "BroadcastMessage"});
		
		public static   int doHash(string s)
		{
			unchecked 
			{
				#line 34 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
				int acc = 0;
				{
					#line 35 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
					int _g1 = 0;
					#line 35 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
					int _g = s.Length;
					#line 35 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
					while (( _g1 < _g ))
					{
						#line 35 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
						int i = _g1++;
						#line 37 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
						acc = ( ( ( 223 * (( acc >> 1 )) ) + global::haxe.lang.StringExt.charCodeAt(s, i).@value ) << 1 );
					}
					
				}
				
				#line 40 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
				return ((int) (( ((uint) (acc) ) >> 1 )) );
			}
			#line default
		}
		
		
		public static   string lookupHash(int key)
		{
			unchecked 
			{
				#line 46 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
				global::Array<int> ids = global::haxe.lang.FieldLookup.fieldIds;
				int min = 0;
				int max = ids.length;
				#line 50 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
				while (( min < max ))
				{
					#line 52 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
					int mid = ( min + ( (( max - min )) / 2 ) );
					int imid = ids[mid];
					if (( key < imid )) 
					{
						max = mid;
					}
					 else 
					{
						#line 57 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
						if (( key > imid )) 
						{
							#line 57 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
							min = ( mid + 1 );
						}
						 else 
						{
							#line 59 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
							return global::haxe.lang.Runtime.toString(global::haxe.lang.FieldLookup.fields[mid]);
						}
						
					}
					
				}
				
				#line 64 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
				throw global::haxe.lang.HaxeException.wrap(global::haxe.lang.Runtime.concat("Field not found for hash ", global::haxe.lang.Runtime.toString(key)));
			}
			#line default
		}
		
		
		public static   int hash(string s)
		{
			unchecked 
			{
				#line 69 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
				if (string.Equals(s, default(string))) 
				{
					#line 69 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
					return 0;
				}
				
				#line 71 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
				int key = default(int);
				#line 71 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
				{
					#line 71 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
					int acc = 0;
					#line 71 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
					{
						#line 71 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
						int _g1 = 0;
						#line 71 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
						int _g = s.Length;
						#line 71 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
						while (( _g1 < _g ))
						{
							#line 71 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
							int i = _g1++;
							#line 71 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
							acc = ( ( ( 223 * (( acc >> 1 )) ) + global::haxe.lang.StringExt.charCodeAt(s, i).@value ) << 1 );
						}
						
					}
					
					#line 71 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
					key = ((int) (( ((uint) (acc) ) >> 1 )) );
				}
				
				#line 74 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
				global::Array<int> ids = global::haxe.lang.FieldLookup.fieldIds;
				int min = 0;
				int max = ids.length;
				#line 78 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
				while (( min < max ))
				{
					#line 80 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
					int mid = ((int) (( min + ( ((double) ((( max - min ))) ) / 2 ) )) );
					int imid = ids[mid];
					if (( key < imid )) 
					{
						max = mid;
					}
					 else 
					{
						#line 85 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
						if (( key > imid )) 
						{
							#line 85 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
							min = ( mid + 1 );
						}
						 else 
						{
							#line 88 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
							string field = global::haxe.lang.Runtime.toString(global::haxe.lang.FieldLookup.fields[mid]);
							if ( ! (string.Equals(field, s)) ) 
							{
								return  ~ (key) ;
							}
							
							return key;
						}
						
					}
					
				}
				
				#line 95 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
				ids.insert(min, key);
				global::haxe.lang.FieldLookup.fields.insert(min, s);
				return key;
			}
			#line default
		}
		
		
		public static   int findHash(int hash, global::Array<int> hashs)
		{
			unchecked 
			{
				#line 102 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
				int min = 0;
				int max = hashs.length;
				#line 105 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
				while (( min < max ))
				{
					#line 107 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
					int mid = ( (( max + min )) / 2 );
					int imid = hashs[mid];
					if (( hash < imid )) 
					{
						max = mid;
					}
					 else 
					{
						#line 112 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
						if (( hash > imid )) 
						{
							#line 112 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
							min = ( mid + 1 );
						}
						 else 
						{
							#line 114 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
							return mid;
						}
						
					}
					
				}
				
				#line 119 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
				return  ~ (min) ;
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 25 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
				return new global::haxe.lang.FieldLookup(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 25 "/usr/lib/haxe/std/cs/internal/FieldLookup.hx"
				return new global::haxe.lang.FieldLookup();
			}
			#line default
		}
		
		
	}
}


