namespace Beginningx
{
    public class CustomConsterint : IRouteConstraint
    {
        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            var routhvalue = values[routeKey].ToString();
            if (!string.IsNullOrEmpty(routhvalue) && routhvalue.Length == 10) return true;                    
            return false;
        }
    }
}
