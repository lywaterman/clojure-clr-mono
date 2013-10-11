using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clojure.lang;
using fuck;

namespace test
{
	class MainClass
	{
		//private static readonly Symbol CLOJURE_MAIN = Symbol.intern("clojure.main");
		//private static readonly Var REQUIRE = RT.var("clojure.core", "require");
		//private static readonly Var LEGACY_REPL = RT.var("clojure.main", "legacy-repl");
		//private static readonly Var LEGACY_SCRIPT = RT.var("clojure.main", "legacy-script");
		//private static readonly Var MAIN = RT.var("clojure.main", "main");

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");

			new you ();

			RuntimeBootstrapFlag.DisableFileLoad = true;


			RT.readString ("(def x 1)");
		}
	}
}
