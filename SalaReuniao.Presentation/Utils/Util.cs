using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.ModelBinding;

namespace SalaReuniao.Presentation.Utils
{
    public class Util
    {
        public static Hashtable ValidationUtil(ModelStateDictionary modelState)
        {
            var erros = new Hashtable();

            foreach (var state in modelState)
            {
                if(state.Value.Errors.Count > 0)
                {
                    erros[state.Key] = state.Value.Errors.Select(e => e.ErrorMessage).ToList();
                }
            }

            return erros;
        }
    }
}