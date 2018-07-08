using Microsoft.AspNetCore.Blazor.Browser.Interop; 
using Microsoft.AspNetCore.Blazor.Components; 
using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Threading.Tasks; 


namespace BlazerJSDemo.Pages{
    public class JSDemoModel : BlazorComponent{
        protected void CallJSMethod(){
            RegisteredFunction.Invoke<bool>("JSMethod"); 
        }
        protected static string message {
            get; set;
        }
        public static void CSCallBackMethod(){
            message = "C# Method invoked"; 
        }
        protected void CallCSMethod(){
            RegisteredFunction.Invoke<bool>("CSMethod"); 
        }
    }
}