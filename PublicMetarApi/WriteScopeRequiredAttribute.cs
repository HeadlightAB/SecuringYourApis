namespace PublicMetarApi
{
    public class WriteScopeRequiredAttribute : ScopeRequiredAttribute
    {
        public WriteScopeRequiredAttribute() : base("public.api.write")
        {}
    }
}