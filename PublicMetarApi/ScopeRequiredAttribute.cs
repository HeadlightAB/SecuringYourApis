using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace PublicMetarApi
{
    public abstract class ScopeRequiredAttribute : ActionFilterAttribute
    {
        private readonly string _requiredScope;

        protected ScopeRequiredAttribute(string requiredScope)
        {
            _requiredScope = requiredScope;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.User.Identity.IsAuthenticated &&
                context.HttpContext.User.HasClaim("scope", _requiredScope))
            {
                base.OnActionExecuting(context);
            }
            else
            {
                context.Result = new UnauthorizedResult();
            }
        }
    }
}