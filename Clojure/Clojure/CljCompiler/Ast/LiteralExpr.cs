﻿/**
 *   Copyright (c) Rich Hickey. All rights reserved.
 *   The use and distribution terms for this software are covered by the
 *   Eclipse Public License 1.0 (http://opensource.org/licenses/eclipse-1.0.php)
 *   which can be found in the file epl-v10.html at the root of this distribution.
 *   By using this software in any fashion, you are agreeing to be bound by
 * 	 the terms of this license.
 *   You must not remove this notice, or any other, from this software.
 **/

/**
 *   Author: David Miller
 **/

using System;


namespace clojure.lang.CljCompiler.Ast
{
    abstract class LiteralExpr : Expr
    {
        public abstract object Val { get; }

        #region Expr Members

        public object Eval()
        {
            return Val;
        }

        public abstract bool HasClrType { get; }
        public abstract Type ClrType { get; }
        public abstract void Emit(RHC rhc, ObjExpr objx, CljILGen ilg);

        public bool HasNormalExit() { return true; }


        #endregion
    }
}
