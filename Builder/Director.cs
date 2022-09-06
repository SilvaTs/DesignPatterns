using Builder.Build;

namespace Builder
{
    public class Director
    {
        public Director(MediaSocialBuilder builder)
        {
            builder.BuildPost();
            builder.BuildLike();
        }
    }
}
