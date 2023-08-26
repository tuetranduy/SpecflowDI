using Specflow.Common;

namespace Specflow.Core
{
    public static class Conventions
    {
        public static void Enforce<T>(T target, Predicate<T> condition, string message)
        {
            if (target is null)
            {
                throw new ArgumentException("Arguments cannot be null");
            }

            if (!condition.Invoke(target))
            {
                throw new ConventionException($"[{target.GetFriendlyTypeName()}] convention error: {message}");
            }
        }
    }
}

