
#pragma warning disable 109, 114, 219, 429, 168, 162
public  class Std 
{
	public    Std()
	{
		unchecked 
		{
			#line 26 "/usr/lib/haxe/std/cs/_std/Std.hx"
			{
			}
			
		}
		#line default
	}
	
	
	public static   bool @is(object v, object t)
	{
		unchecked 
		{
			#line 29 "/usr/lib/haxe/std/cs/_std/Std.hx"
			if (global::haxe.lang.Runtime.eq(v, default(object))) 
			{
				return global::haxe.lang.Runtime.eq(t, typeof(object));
			}
			
			if (global::haxe.lang.Runtime.eq(t, default(object))) 
			{
				return false;
			}
			
			global::System.Type clt = ((global::System.Type) (t) );
			if (global::haxe.lang.Runtime.typeEq(clt, default(global::System.Type))) 
			{
				return false;
			}
			
			string name = global::haxe.lang.Runtime.toString(clt);
			#line 38 "/usr/lib/haxe/std/cs/_std/Std.hx"
			switch (name)
			{
				case "System.Double":
				{
					#line 40 "/usr/lib/haxe/std/cs/_std/Std.hx"
					return v is double || v is int;
				}
				
				
				case "System.Int32":
				{
					#line 42 "/usr/lib/haxe/std/cs/_std/Std.hx"
					return haxe.lang.Runtime.isInt(v);
				}
				
				
				case "System.Boolean":
				{
					#line 44 "/usr/lib/haxe/std/cs/_std/Std.hx"
					return v is bool;
				}
				
				
				case "System.Object":
				{
					#line 46 "/usr/lib/haxe/std/cs/_std/Std.hx"
					return true;
				}
				
				
			}
			
			#line 50 "/usr/lib/haxe/std/cs/_std/Std.hx"
			global::System.Type clv = v.GetType();
			#line 52 "/usr/lib/haxe/std/cs/_std/Std.hx"
			return clt.IsAssignableFrom(clv);
		}
		#line default
	}
	
	
	public static   string @string(object s)
	{
		unchecked 
		{
			#line 56 "/usr/lib/haxe/std/cs/_std/Std.hx"
			if (global::haxe.lang.Runtime.eq(s, default(object))) 
			{
				return "null";
			}
			
			if (( s is bool )) 
			{
				return ( (((bool) (s) )) ? ("true") : ("false") );
			}
			
			#line 61 "/usr/lib/haxe/std/cs/_std/Std.hx"
			return s.ToString();
		}
		#line default
	}
	
	
}


